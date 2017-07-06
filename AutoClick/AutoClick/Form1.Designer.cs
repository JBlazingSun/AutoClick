namespace AutoClick
{
    partial class hezhu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.trackBarTime = new System.Windows.Forms.TrackBar();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).BeginInit();
            this.SuspendLayout();
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(12, 82);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(404, 142);
            this.LogText.TabIndex = 1;
            this.LogText.Text = "";
            // 
            // trackBarTime
            // 
            this.trackBarTime.LargeChange = 100;
            this.trackBarTime.Location = new System.Drawing.Point(12, 31);
            this.trackBarTime.Maximum = 1000;
            this.trackBarTime.Minimum = 100;
            this.trackBarTime.Name = "trackBarTime";
            this.trackBarTime.Size = new System.Drawing.Size(322, 45);
            this.trackBarTime.SmallChange = 100;
            this.trackBarTime.TabIndex = 2;
            this.trackBarTime.Value = 100;
            this.trackBarTime.Scroll += new System.EventHandler(this.trackBarTime_Scroll);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(340, 41);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(76, 21);
            this.textBoxTime.TabIndex = 3;
            // 
            // hezhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 247);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.trackBarTime);
            this.Controls.Add(this.LogText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "hezhu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贺猪专用";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hezhu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.TrackBar trackBarTime;
        private System.Windows.Forms.TextBox textBoxTime;
    }
}

