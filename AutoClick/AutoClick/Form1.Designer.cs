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
            this.SuspendLayout();
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(31, 12);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(278, 226);
            this.LogText.TabIndex = 1;
            this.LogText.Text = "";
            // 
            // hezhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 260);
            this.Controls.Add(this.LogText);
            this.MaximizeBox = false;
            this.Name = "hezhu";
            this.Text = "贺猪自动点击";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogText;
    }
}

