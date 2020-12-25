using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ConstLS.CoordinationCenter.Units.Actions
{
    abstract class ActionBase
    {
        private Process client;
        private Random random;

        public ActionBase(Process client)
        {
            this.client = client;
            this.random = new Random();
        }

        protected void pressKey(Keys key)
        {
            ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYDOWN, (int)key, 0);
            this.randomDelay(100, 100);
            ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYUP, (int)key, 0);
            this.randomDelay(40, 20);
        }

        protected void pressKeyCombo(Keys keyFirst, Keys keySecond, Keys keyThird = 0)
        {
            ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYDOWN, (int)keyFirst, 0);
            this.randomDelay(40, 40);
            ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYDOWN, (int)keySecond, 0);
            this.randomDelay(20, 10);
            if (keyThird != 0)
            {
                ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYDOWN, (int)keyThird, 0);
                this.randomDelay(20, 10);
                ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYUP, (int)keyThird, 0);
                this.randomDelay(20, 10);
            }
            ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYUP, (int)keySecond, 0);
            this.randomDelay(40, 40);
            ActionBase.PostMessage(this.client.MainWindowHandle, ActionBase.WM_KEYUP, (int)keyFirst, 0);
            this.randomDelay(40, 20);
        }

        private void randomDelay(int meanValue, int range = 40)
        {
            int minValue = (meanValue - (range / 2));
            int maxValue = (meanValue + (range / 2));
            Thread.Sleep(this.random.Next(minValue, maxValue));
        }

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool PostMessage(IntPtr hWnd, uint msg, int wParam, int lParam);
    }
}
