namespace w_Display
{
    partial class w_NormalDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_NormalDisplay));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblLineSeq = new System.Windows.Forms.Label();
            this.lblLineCusTotal = new System.Windows.Forms.Label();
            this.lblLineTotal = new System.Windows.Forms.Label();
            this.lblLineName = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblBillCode = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblPackagenum = new System.Windows.Forms.Label();
            this.lblCus = new System.Windows.Forms.Label();
            this.BgwReadPlc = new System.ComponentModel.BackgroundWorker();
            this.BgwLoad = new System.ComponentModel.BackgroundWorker();
            this.BtnPosition = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 464);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "当前信息";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLineSeq);
            this.groupBox3.Controls.Add(this.lblLineCusTotal);
            this.groupBox3.Controls.Add(this.lblLineTotal);
            this.groupBox3.Controls.Add(this.lblLineName);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(657, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 177);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "车组信息";
            // 
            // lblLineSeq
            // 
            this.lblLineSeq.AutoSize = true;
            this.lblLineSeq.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLineSeq.Location = new System.Drawing.Point(6, 87);
            this.lblLineSeq.Name = "lblLineSeq";
            this.lblLineSeq.Size = new System.Drawing.Size(82, 14);
            this.lblLineSeq.TabIndex = 3;
            this.lblLineSeq.Text = "线路包序：";
            // 
            // lblLineCusTotal
            // 
            this.lblLineCusTotal.AutoSize = true;
            this.lblLineCusTotal.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLineCusTotal.Location = new System.Drawing.Point(6, 177);
            this.lblLineCusTotal.Name = "lblLineCusTotal";
            this.lblLineCusTotal.Size = new System.Drawing.Size(82, 14);
            this.lblLineCusTotal.TabIndex = 2;
            this.lblLineCusTotal.Text = "线路户数：";
            this.lblLineCusTotal.Visible = false;
            // 
            // lblLineTotal
            // 
            this.lblLineTotal.AutoSize = true;
            this.lblLineTotal.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLineTotal.Location = new System.Drawing.Point(6, 149);
            this.lblLineTotal.Name = "lblLineTotal";
            this.lblLineTotal.Size = new System.Drawing.Size(97, 14);
            this.lblLineTotal.TabIndex = 1;
            this.lblLineTotal.Text = "线路总包数：";
            // 
            // lblLineName
            // 
            this.lblLineName.AutoSize = true;
            this.lblLineName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLineName.Location = new System.Drawing.Point(6, 25);
            this.lblLineName.Name = "lblLineName";
            this.lblLineName.Size = new System.Drawing.Size(82, 14);
            this.lblLineName.TabIndex = 0;
            this.lblLineName.Text = "线路名称：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblBillCode);
            this.groupBox4.Controls.Add(this.lblCusName);
            this.groupBox4.Controls.Add(this.lblPackagenum);
            this.groupBox4.Controls.Add(this.lblCus);
            this.groupBox4.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(657, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 253);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "客户信息";
            // 
            // lblBillCode
            // 
            this.lblBillCode.AutoSize = true;
            this.lblBillCode.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBillCode.Location = new System.Drawing.Point(6, 30);
            this.lblBillCode.Name = "lblBillCode";
            this.lblBillCode.Size = new System.Drawing.Size(82, 14);
            this.lblBillCode.TabIndex = 4;
            this.lblBillCode.Text = "订单编号：";
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCusName.Location = new System.Drawing.Point(6, 89);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(82, 14);
            this.lblCusName.TabIndex = 5;
            this.lblCusName.Text = "客户名称：";
            // 
            // lblPackagenum
            // 
            this.lblPackagenum.AutoSize = true;
            this.lblPackagenum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPackagenum.Location = new System.Drawing.Point(6, 148);
            this.lblPackagenum.Name = "lblPackagenum";
            this.lblPackagenum.Size = new System.Drawing.Size(82, 14);
            this.lblPackagenum.TabIndex = 6;
            this.lblPackagenum.Text = "该包数量：";
            // 
            // lblCus
            // 
            this.lblCus.AutoSize = true;
            this.lblCus.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCus.Location = new System.Drawing.Point(6, 207);
            this.lblCus.Name = "lblCus";
            this.lblCus.Size = new System.Drawing.Size(97, 14);
            this.lblCus.TabIndex = 7;
            this.lblCus.Text = "客户总包数：";
            // 
            // BgwReadPlc
            // 
            this.BgwReadPlc.WorkerSupportsCancellation = true;
            this.BgwReadPlc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGReadPlc_DoWork);
            this.BgwReadPlc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGReadPlc_RunWorkerCompleted);
            // 
            // BgwLoad
            // 
            this.BgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLoad_DoWork);
            this.BgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwLoad_RunWorkerCompleted);
            // 
            // BtnPosition
            // 
            this.BtnPosition.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPosition.Location = new System.Drawing.Point(710, 183);
            this.BtnPosition.Name = "BtnPosition";
            this.BtnPosition.Size = new System.Drawing.Size(50, 18);
            this.BtnPosition.TabIndex = 0;
            this.BtnPosition.Text = "定 位";
            this.BtnPosition.UseVisualStyleBackColor = true;
            this.BtnPosition.Click += new System.EventHandler(this.BtnPosition_Click);
            // 
            // w_NormalDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(808, 468);
            this.Controls.Add(this.BtnPosition);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_NormalDisplay";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.w_NormalDisplay_FormClosed);
            this.Resize += new System.EventHandler(this.w_Display_Resize);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblLineSeq;
        private System.Windows.Forms.Label lblLineCusTotal;
        private System.Windows.Forms.Label lblLineTotal;
        private System.Windows.Forms.Label lblLineName;
        private System.Windows.Forms.Label lblBillCode;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblPackagenum;
        private System.Windows.Forms.Label lblCus;
        private System.ComponentModel.BackgroundWorker BgwReadPlc;
        private System.ComponentModel.BackgroundWorker BgwLoad;
        private System.Windows.Forms.Button BtnPosition;
    }
}