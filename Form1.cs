using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

        public Srak()
        {
            InitializeComponent();
        }

        private async void Srak_Load(object sender, EventArgs e)
        {
            int time = 0;
            while (time < 10)
            {
                await SimulerAppuiToucheAsync(Keys.B);
                Thread.Sleep(1000);
                time++;
            }
        }
        static Task SimulerAppuiToucheAsync(Keys touche)
        {
            return Task.Run(() =>
            {
                keybd_event((byte)touche, 0, KEYEVENTF_KEYDOWN, UIntPtr.Zero);
                keybd_event((byte)touche, 0, KEYEVENTF_KEYUP, UIntPtr.Zero);
            });
        }

        static void SimulerClicSouris(int x, int y)
        {
            SetCursorPos(x, y);
            mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, UIntPtr.Zero);
            mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, UIntPtr.Zero);
        }
    }
}
