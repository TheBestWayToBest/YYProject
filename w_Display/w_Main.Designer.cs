namespace w_Display
{
    partial class w_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据接收ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大屏幕显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常烟大屏显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.TTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据接收ToolStripMenuItem,
            this.大屏幕显示ToolStripMenuItem,
            this.正常烟大屏显示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据接收ToolStripMenuItem
            // 
            this.数据接收ToolStripMenuItem.Name = "数据接收ToolStripMenuItem";
            this.数据接收ToolStripMenuItem.ShortcutKeyDisplayString = "R";
            this.数据接收ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.数据接收ToolStripMenuItem.Size = new System.Drawing.Size(117, 21);
            this.数据接收ToolStripMenuItem.Text = "数据接收(&Ctrl+R)";
            this.数据接收ToolStripMenuItem.Click += new System.EventHandler(this.数据接收ToolStripMenuItem_Click);
            // 
            // 大屏幕显示ToolStripMenuItem
            // 
            this.大屏幕显示ToolStripMenuItem.Name = "大屏幕显示ToolStripMenuItem";
            this.大屏幕显示ToolStripMenuItem.ShortcutKeyDisplayString = "U";
            this.大屏幕显示ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.大屏幕显示ToolStripMenuItem.Size = new System.Drawing.Size(166, 21);
            this.大屏幕显示ToolStripMenuItem.Text = "异形烟大屏幕显示(&Ctrl+U)";
            this.大屏幕显示ToolStripMenuItem.Click += new System.EventHandler(this.大屏幕显示ToolStripMenuItem_Click);
            // 
            // 正常烟大屏显示ToolStripMenuItem
            // 
            this.正常烟大屏显示ToolStripMenuItem.Name = "正常烟大屏显示ToolStripMenuItem";
            this.正常烟大屏显示ToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.正常烟大屏显示ToolStripMenuItem.Text = "正常烟大屏显示";
            this.正常烟大屏显示ToolStripMenuItem.Click += new System.EventHandler(this.正常烟大屏显示ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TTimer,
            this.TTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TTimer
            // 
            this.TTimer.Name = "TTimer";
            this.TTimer.Size = new System.Drawing.Size(20, 17);
            this.TTimer.Text = "   ";
            // 
            // TTime
            // 
            this.TTime.Name = "TTime";
            this.TTime.Size = new System.Drawing.Size(68, 17);
            this.TTime.Text = "：当前时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // w_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "w_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.w_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据接收ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大屏幕显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常烟大屏显示ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TTimer;
        private System.Windows.Forms.ToolStripStatusLabel TTime;
        private System.Windows.Forms.Timer timer1;
    }
}