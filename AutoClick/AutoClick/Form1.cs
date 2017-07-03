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
        public hezhu()
        {
            InitializeComponent();
            trackBarTime.Value = trackBarTime.Maximum / 2;
            textBoxTime.Text = trackBarTime.Value.ToString();
            KeyBegin(this.Handle, 100, Keys.F7, KeyBeginCallBack);
            
        }

        private void trackBarTime_Scroll(object sender, EventArgs e)
        {
            textBoxTime.Text = trackBarTime.Value.ToString();
        }


    }
}
