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
        [DllImport("user32")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint control, Keys vk, HotKeyCallBackHanlder callBack);
        //注册热键的api 
        [DllImport("user32")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        int keyid = 10;     //区分不同的快捷键
        Dictionary<int, HotKeyCallBackHanlder> keymap = new Dictionary<int, HotKeyCallBackHanlder>();   //每一个key对于一个处理函数
        public delegate void HotKeyCallBackHanlder();

        void MyLog(string log)
        {
            LogText.AppendText("log" + "\n");
        }

        public void KeyBegin(IntPtr hWnd, uint modifiers, Keys vk, HotKeyCallBackHanlder callBack)
        {
            int id = keyid++;
            if (!RegisterHotKey(hWnd, id, modifiers, vk, callBack))
                MyLog("开始热键注册失败");
            else
                MyLog("开始热键注册成功");
            keymap[id] = callBack;
        }

        public void KeyBeginCallBack()
        {
            MessageBox.Show("KeyBeginCallBack");
        }
    }
}
