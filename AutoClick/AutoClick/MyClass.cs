using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoClick;

namespace AutoClick
{
    partial class hezhu
    {
        static Timer myTimer = new Timer();
        static bool exitFlag = false;
        [DllImport("user32")]
        private static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        const int MOUSEEVENTF_LEFTDOWN = 0x0002; //模拟鼠标左键按下
        const int MOUSEEVENTF_LEFTUP = 0x0004; //模拟鼠标左键抬起
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008; //模拟鼠标右键按下
        const int MOUSEEVENTF_RIGHTUP = 0x0010; //模拟鼠标右键抬起
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; //模拟鼠标中键按下
        const int MOUSEEVENTF_MIDDLEUP = 0x0040; //模拟鼠标中键抬起

        void MyLog(string log)
        {
            LogText.AppendText(/*DateTime.Now.ToString()*/ log + Environment.NewLine);
        }

        void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
        {
            myTimer.Interval = trackBarTime.Value;
            if (exitFlag)
            {
                myTimer.Tick -= TimerEventProcessor;
                myTimer.Stop();
            }
            //MyLog("");
            leftBtn();
            LogText.ScrollToCaret();
        }

        public void MyTimer()
        {
            exitFlag = false;
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = trackBarTime.Value;
            myTimer.Start();
        }

        public void leftBtn()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }
    }
}
