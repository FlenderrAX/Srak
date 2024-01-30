using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        const int KEYEVENTF_KEYDOWN = 0x0001;
        const int KEYEVENTF_KEYUP = 0x0002;
        const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        const int MOUSEEVENTF_LEFTUP = 0x0004;
        const int MOUSEEVENTF_RIGHTUP = 0x0010;
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008;

        bool isActive = false;
        Keys usrHotkey = Keys.None;
        Keys usrKybdHotkey = Keys.None;
        string clickAmount = "single";
        string usrBtn = "left";

        public Srak()
        {
            InitializeComponent();
            this.Load += Srak_Load;
            this.FormClosing += Srak_FormClosing;

            KeyboardHook.Start();
            KeyboardHook.KeyDown += KeyboardHook_KeyDown;
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == usrHotkey)
            {
                ToggleAuto();
            }
        }

        private void Srak_Load(object sender, EventArgs e)
        {
            enableMouseAuto.Click += (s, ev) => ToggleAuto();
            disableAuto.Click += (s, ev) => ToggleAuto();
            msTextbox.Text = "100";

            clickCombobox.Items.Clear();
            clickCombobox.Items.AddRange(new[] { "Left Button", "Right Button" });
            clickCombobox.SelectedIndex = 0;
            clickCombobox.DropDownStyle = ComboBoxStyle.DropDownList;

            hotkeyCombobox.Items.Clear();
            hotkeyCombobox.Items.AddRange(new[] {"F6", "SPACE", "K", "PageUp"});
            hotkeyCombobox.SelectedIndex = 0;
            hotkeyCombobox.DropDownStyle = ComboBoxStyle.DropDownList;

            kybdHotkeys.Items.Clear();
            kybdHotkeys.Items.AddRange(new[] {"F7", "J", "PageDown"});
            kybdHotkeys.SelectedIndex = 0;
            kybdHotkeys.DropDownStyle = ComboBoxStyle.DropDownList;

            mouseGBox.Text = "Mouse";
            kybdGBox.Text = "Keyboard";

            insertKey.Text = "Change Key";
            kybdKeyLabel.Text = "Space";

            clickNb.Text = "Click amount";
            singleClick.Text = "Single";
            doubleClick.Text = "Double";

            insertKey.Click += InsertKey_Click;

            singleClick.Checked = true;

            hotkeyLabel.Location = new System.Drawing.Point(5, 20);
            hotkeyCombobox.Location = new System.Drawing.Point(10, 40);

            clickCombo.Location = new System.Drawing.Point(5, 80);
            clickCombobox.Location = new System.Drawing.Point(10, 100);

            msLabel.Location = new System.Drawing.Point(5, 140);
            msTextbox.Location = new System.Drawing.Point(10, 160);

            sLabel.Location = new System.Drawing.Point(5, 200);
            sTextbox.Location = new System.Drawing.Point(10, 220);

            mLabel.Location = new System.Drawing.Point(5, 260);
            mTextbox.Location = new System.Drawing.Point(10, 280);


            kybdGBox.Controls.AddRange(new Control[] {insertKey, kybdKeyLabel, kybdHkLabel, kybdHotkeys});
            mouseGBox.Controls.AddRange(new Control[] {hotkeyCombobox, hotkeyLabel, clickCombo, clickCombobox, msTextbox, msLabel, sLabel, sTextbox, mLabel, mTextbox});
            clickNb.Controls.AddRange(new Control[] {singleClick, doubleClick});
        }

        private void _KeyPress(object sender, KeyEventArgs e)
        {
            usrKybdHotkey = e.KeyCode;
        }

        private void InsertKey_Click(object sender, EventArgs e)
        {
            insertKey.Text = "Press a key...";
            this.OnKeyDown(new KeyEventArgs(usrKybdHotkey));
            kybdKeyLabel.Text = usrKybdHotkey.ToString();
            insertKey.Text = "Change Key";
        }

        private void Srak_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHook.Stop();
        }

        private void ChangedCommitted_Click(object sender, EventArgs e)
        {
            switch (hotkeyCombobox.SelectedItem.ToString())
            {
                case "F6":
                    usrHotkey = Keys.F6;
                    break;
                case "SPACE":
                    usrHotkey = Keys.Space;
                    break;
                case "K":
                    usrHotkey = Keys.K;
                    break;
                case "PageUp":
                    usrHotkey = Keys.PageUp;
                    break;
            }

            enableMouseAuto.Text = $"Enable Autoclick ({usrHotkey})";
            disableAuto.Text = $"Disable Autoclick ({usrHotkey})";
        }
        private void ChangedKybdCommited_Click(object sender, EventArgs e)
        {
            switch (kybdHotkeys.SelectedItem.ToString())
            {
                case "F7":
                    usrKybdHotkey = Keys.F7;
                    break;
                case "J":
                    usrKybdHotkey = Keys.J;
                    break;
                case "PageDown":
                    usrKybdHotkey = Keys.PageDown;
                    break;
            }

            enableKybdAuto.Text = $"Enable Autoclick ({usrKybdHotkey})";
        }

        private void mouseBtn_ChangeCommited(object sender, EventArgs e)
        {
            usrBtn = clickCombobox.SelectedItem.ToString().ToLower().Split(' ')[0];
        }

        private async void ToggleAuto()
        {
            isActive = !isActive;
            if (isActive)
            {
                msTextbox.Enabled = false;
                sTextbox.Enabled = false;
                mTextbox.Enabled = false;
                enableMouseAuto.Enabled = false;
                disableAuto.Enabled = true;
                await Task.Run(() =>
                {
                    while (isActive)
                    {
                        if (!string.IsNullOrEmpty(usrBtn))
                        {
                            this.Invoke(new Action(() =>
                            {
                                if (clickAmount.Equals("single")) {
                                    PerformMouseClick(usrBtn, Cursor.Position.X, Cursor.Position.Y);
                                } 
                                else if (clickAmount.Equals("double")) {
                                    PerformDoubleMouseClick(usrBtn, Cursor.Position.X, Cursor.Position.Y);
                                }
                            }));

                            int ms;
                            ms = int.Parse(msTextbox.Text) + (int.Parse(sTextbox.Text) * 1000) + (int.Parse(mTextbox.Text) * 60000);
                            Thread.Sleep(ms);
                        }
                    }
                });
            }
            else
            {
                enableMouseAuto.Enabled = true;
                disableAuto.Enabled = false;
                msTextbox.Enabled = true;
            }
        }

        private static void PerformDoubleMouseClick(string button, int x, int y)
        {
            SetCursorPos(x, y);
            switch (button)
            {
                case "left":
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                    break;
                case "right":
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, UIntPtr.Zero);
                    break;
            }
        }

        private static void PerformMouseClick(string button, int x, int y)
        {
            SetCursorPos(x, y);
            switch (button)
            {
                case "left":
                    mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
                    break;
                case "right":
                    mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, UIntPtr.Zero);
                    mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, UIntPtr.Zero);
                    break;
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

        private void singleClick_CheckedChanged(object sender, EventArgs e)
        {
            if (singleClick.Checked) {
                clickAmount = "single";
            }
            else {
                clickAmount = "double";
            }
        }
    }
}