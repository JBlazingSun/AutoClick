using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class hezhu : Form
    {
        KeyboardHook kh;
        public hezhu()
        {
            InitializeComponent();
            trackBarTime.Value = trackBarTime.Maximum / 2;
            textBoxTime.Text = trackBarTime.Value.ToString();

            
            kh = new KeyboardHook();
            kh.SetHook();
            kh.OnKeyDownEvent += kh_OnKeyDownEvent;
        }

        void kh_OnKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.F6))
            {
                MyLog("点击开始");
                MyTimer();
            }
            if (e.KeyData == (Keys.F7))
            {
                MyLog("点击结束");
                exitFlag = true;
            }
        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            textBoxTime.Text = trackBarTime.Value.ToString();
        }

        private void hezhu_FormClosing(object sender, FormClosingEventArgs e)
        {
            kh.UnHook();
        }
    }
}
