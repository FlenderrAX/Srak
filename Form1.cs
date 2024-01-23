using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Srak
{
    public partial class Srak : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        const int KEYEVENTF_KEYDOWN = 0x0001;
        const int KEYEVENTF_KEYUP = 0x0002;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;

        bool isActive = false;

        public Srak()
        {
            InitializeComponent();
            this.Load += Srak_Load;
            this.KeyPreview = true;
            this.KeyDown += Auto_Keydown;

            KeyboardHook.Start();
            KeyboardHook.KeyDown += KeyboardHook_KeyDown;
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                ToggleAuto(sender, e);
            }
        }

        private void Auto_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F6)
            {
                ToggleAuto(sender, e);
            }
        }

        private void Srak_Load(object sender, EventArgs e)
        {
            enableAuto.Click += ToggleAuto;
            disableAuto.Click += ToggleAuto;
            msTextbox.Text = "100";
            clickCombobox.Items.AddRange(new object[] { "Left Button", "Right Button" });
            clickCombobox.SelectedItem = 1;
        }

        private async void ToggleAuto(object sender, EventArgs e)
        {
            isActive = !isActive;
            if (isActive)
            {
                enableAuto.Enabled = false;
                disableAuto.Enabled = true;
                await Task.Run(() =>
                {
                    while (isActive)
                    {
                        mouseBtn(Cursor.Position.X, Cursor.Position.Y, "left");
                        int ms = int.Parse(msTextbox.Text);
                        Thread.Sleep(ms);
                    }
                });
            }
            else if (!isActive)
            {
                enableAuto.Enabled = true;
                disableAuto.Enabled = false;
            }
        }

        public static class KeyboardHook
        {
            private static LowLevelKeyboardListener _listener;

            public static event EventHandler<KeyEventArgs> KeyDown;

            static KeyboardHook()
            {
                _listener = new LowLevelKeyboardListener();
                _listener.OnKeyDown += (s, e) => KeyDown?.Invoke(s, e);
            }

            public static void Start()
            {
                _listener.HookKeyboard();
            }

            public static void Stop()
            {
                _listener.UnhookKeyboard();
            }
        }

        public class LowLevelKeyboardListener
        {
            private const int WH_KEYBOARD_LL = 13;
            private const int WM_KEYDOWN = 0x0100;

            private HookProc _proc;
            private IntPtr _hookID = IntPtr.Zero;

            public event EventHandler<KeyEventArgs> OnKeyDown;

            public LowLevelKeyboardListener()
            {
                _proc = HookCallback;
            }

            public void HookKeyboard()
            {
                _hookID = SetHook(_proc);
            }

            public void UnhookKeyboard()
            {
                UnhookWindowsHookEx(_hookID);
            }

            private IntPtr SetHook(HookProc proc)
            {
                using (ProcessModule module = Process.GetCurrentProcess().MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                        GetModuleHandle(module.ModuleName), 0);
                }
            }

            private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
            {
                if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                {
                    int vkCode = Marshal.ReadInt32(lParam);
                    OnKeyDown?.Invoke(this, new KeyEventArgs((Keys)vkCode));
                }
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }

            #region DllImports

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            private static extern bool UnhookWindowsHookEx(IntPtr hhk);

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

            [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
            private static extern IntPtr GetModuleHandle(string lpModuleName);

            #endregion

            #region Delegate

            private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);

            #endregion
        }

        static Task keyboardBtn(Keys key)
        {
            return Task.Run(() =>
            {
                keybd_event((byte)key, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
                keybd_event((byte)key, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            });
        }

        static void mouseBtn(int x, int y, string btn)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
        }
    }
}