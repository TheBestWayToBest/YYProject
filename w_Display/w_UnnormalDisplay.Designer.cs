namespace w_Display
{
    partial class w_UnnormalDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_UnnormalDisplay));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnPosition = new System.Windows.Forms.Button();
            this.lblCus = new System.Windows.Forms.Label();
            this.lblPackagenum = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblBillCode = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLineSeq = new System.Windows.Forms.Label();
            this.lblLineCusTotal = new System.Windows.Forms.Label();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.lblLineName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BgwReadPlc = new System.ComponentModel.BackgroundWorker();
            this.BgwLoad = new System.ComponentModel.BackgroundWorker();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblCus);
            this.groupBox4.Controls.Add(this.lblPackagenum);
            this.groupBox4.Controls.Add(this.lblCusName);
            this.groupBox4.Controls.Add(this.lblBillCode);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(4, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(504, 21);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "客户信息";
            // 
            // BtnPosition
            // 
            this.BtnPosition.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPosition.Location = new System.Drawing.Point(436, 41);
            this.BtnPosition.Name = "BtnPosition";
            this.BtnPosition.Size = new System.Drawing.Size(30, 10);
            this.BtnPosition.TabIndex = 8;
            this.BtnPosition.Text = "定 位";
            this.BtnPosition.UseVisualStyleBackColor = true;
            this.BtnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // lblCus
            // 
            this.lblCus.AutoSize = true;
            this.lblCus.Location = new System.Drawing.Point(405, 8);
            this.lblCus.Name = "lblCus";
            this.lblCus.Size = new System.Drawing.Size(52, 7);
            this.lblCus.TabIndex = 7;
            this.lblCus.Text = "客户总包数：";
            // 
            // lblPackagenum
            // 
            this.lblPackagenum.AutoSize = true;
            this.lblPackagenum.Location = new System.Drawing.Point(286, 8);
            this.lblPackagenum.Name = "lblPackagenum";
            this.lblPackagenum.Size = new System.Drawing.Size(44, 7);
            this.lblPackagenum.TabIndex = 6;
            this.lblPackagenum.Text = "该包数量：";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(189, 8);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(44, 7);
            this.lblCusName.TabIndex = 5;
            this.lblCusName.Text = "客户名称：";
            // 
            // lblBillCode
            // 
            this.lblBillCode.AutoSize = true;
            this.lblBillCode.Location = new System.Drawing.Point(61, 9);
            this.lblBillCode.Name = "lblBillCode";
            this.lblBillCode.Size = new System.Drawing.Size(36, 7);
            this.lblBillCode.TabIndex = 4;
            this.lblBillCode.Text = "订单号：";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lblLineSeq);
            this.groupBox3.Controls.Add(this.lblLineCusTotal);
            this.groupBox3.Controls.Add(this.lblLineTotal);
            this.groupBox3.Controls.Add(this.lblLineName);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(4, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 21);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车组信息";
            // 
            // lblLineSeq
            // 
            this.lblLineSeq.AutoSize = true;
            this.lblLineSeq.Location = new System.Drawing.Point(189, 8);
            this.lblLineSeq.Name = "lblLineSeq";
            this.lblLineSeq.Size = new System.Drawing.Size(44, 7);
            this.lblLineSeq.TabIndex = 3;
            this.lblLineSeq.Text = "线路包序：";
            // 
            // lblLineCusTotal
            // 
            this.lblLineCusTotal.AutoSize = true;
            this.lblLineCusTotal.Location = new System.Drawing.Point(286, 8);
            this.lblLineCusTotal.Name = "lblLineCusTotal";
            this.lblLineCusTotal.Size = new System.Drawing.Size(44, 7);
            this.lblLineCusTotal.TabIndex = 2;
            this.lblLineCusTotal.Text = "线路户数：";
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Location = new System.Drawing.Point(405, 8);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(52, 7);
            this.lblLineTotal.TabIndex = 1;
            this.lblLineTotal.Text = "线路总包数：";
            // 
            // lblLineName
            // 
            this.lblLineName.AutoSize = true;
            this.lblLineName.Location = new System.Drawing.Point(61, 8);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(44, 7);
            this.lblLineName.TabIndex = 0;
            this.lblLineName.Text = "线路名称：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Font = new System.Drawing.Font("宋体", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(4, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(504, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前信息";
            // 
            // BgwReadPlc
            // 
            this.BgwReadPlc.WorkerSupportsCancellation = true;
            this.BgwReadPlc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwReadPlc_DoWork);
            this.BgwReadPlc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwReadPlc_RunWorkerCompleted);
            // 
            // BgwLoad
            // 
            this.BgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLoad_DoWork);
            this.BgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwLoad_RunWorkerCompleted);
            // 
            // w_UnnormalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(503, 239);
            this.Controls.Add(this.BtnPosition);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_UnnormalDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.w_UnnormalDisplay_FormClosed);
            this.Resize += new System.EventHandler(this.w_UnnormalDisplay_Resize);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCus;
        private System.Windows.Forms.Label lblPackagenum;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblBillCode;
        private System.Windows.Forms.Label lblLineSeq;
        private System.Windows.Forms.Label lblLineCusTotal;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.Label lblLineName;
        private System.ComponentModel.BackgroundWorker BgwReadPlc;
        private System.ComponentModel.BackgroundWorker BgwLoad;
        private System.Windows.Forms.Button BtnPosition;
    }
}