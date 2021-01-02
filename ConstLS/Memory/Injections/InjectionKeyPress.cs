using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ConstLS.Memory.Injections
{
    class InjectionKeyPress
    {
        private IntPtr mainWindowHandle;
        private Random random;

        public InjectionKeyPress(IntPtr mainWindowHandle)
        {
            this.mainWindowHandle = mainWindowHandle;
            this.random = new Random();
        }

        public void send(Keys key)
        {
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYDOWN, (int)key, 0);
            this.randomDelay(100, 100);
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYUP, (int)key, 0);
            this.randomDelay(40, 20);
        }

        public void sendCombo(Keys keyFirst, Keys keySecond, Keys keyThird = 0)
        {
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYDOWN, (int)keyFirst, 0);
            this.randomDelay(40, 40);
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYDOWN, (int)keySecond, 0);
            this.randomDelay(20, 10);
            if (keyThird != 0)
            {
                InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYDOWN, (int)keyThird, 0);
                this.randomDelay(20, 10);
                InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYUP, (int)keyThird, 0);
                this.randomDelay(20, 10);
            }
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYUP, (int)keySecond, 0);
            this.randomDelay(40, 40);
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.WM_KEYUP, (int)keyFirst, 0);
            this.randomDelay(40, 20);
        }

        public void sendMouseLeft(int x, int y)
        {
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.LeftButtonDown, 0, (y * 0x10000 + x));
            this.randomDelay(40, 20);
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.LeftButtonUp, 0, (y * 0x10000 + x));
            this.randomDelay(40, 20);
        }

        public void sendMouseRight(int x, int y)
        {
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.RightButtonDown, 0, (y * 0x10000 + x));
            this.randomDelay(40, 20);
            InjectionKeyPress.PostMessage(this.mainWindowHandle, InjectionKeyPress.RightButtonUp, 0, (y * 0x10000 + x));
            this.randomDelay(40, 20);
        }

        public void randomDelay(int meanValue, int range = 40)
        {
            int minValue = (meanValue - (range / 2));
            int maxValue = (meanValue + (range / 2));
            Thread.Sleep(this.random.Next(minValue, maxValue));
        }

        private const int
            WM_KEYDOWN = 0x100,
            WM_KEYUP = 0x101,

            LeftButtonDown = 0x201,
            LeftButtonUp = 0x202,

            RightButtonDown = 0x204,
            RightButtonUp = 0x205;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
    }
}
