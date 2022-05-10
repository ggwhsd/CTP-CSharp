
namespace CTP6_5_1ReleaseDemo
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接行情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.订阅行情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctpToolStripMenuItem
            // 
            this.ctpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接行情ToolStripMenuItem,
            this.订阅行情ToolStripMenuItem});
            this.ctpToolStripMenuItem.Name = "ctpToolStripMenuItem";
            this.ctpToolStripMenuItem.Size = new System.Drawing.Size(38, 21);
            this.ctpToolStripMenuItem.Text = "ctp";
            // 
            // 连接行情ToolStripMenuItem
            // 
            this.连接行情ToolStripMenuItem.Name = "连接行情ToolStripMenuItem";
            this.连接行情ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.连接行情ToolStripMenuItem.Text = "连接行情";
            this.连接行情ToolStripMenuItem.Click += new System.EventHandler(this.连接行情ToolStripMenuItem_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 425);
            this.textBox1.TabIndex = 1;
            // 
            // 订阅行情ToolStripMenuItem
            // 
            this.订阅行情ToolStripMenuItem.Name = "订阅行情ToolStripMenuItem";
            this.订阅行情ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.订阅行情ToolStripMenuItem.Text = "订阅行情";
            this.订阅行情ToolStripMenuItem.Click += new System.EventHandler(this.订阅行情ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接行情ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 订阅行情ToolStripMenuItem;
    }
}

