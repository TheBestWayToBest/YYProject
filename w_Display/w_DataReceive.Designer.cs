namespace w_Display
{
    partial class w_DataReceive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_DataReceive));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCusAddress = new System.Windows.Forms.Label();
            this.lblCusCount = new System.Windows.Forms.Label();
            this.lblPackageCount = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvOrderData = new System.Windows.Forms.DataGridView();
            this.packageno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelingStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnDataClear = new System.Windows.Forms.Button();
            this.BtnDataReceive = new System.Windows.Forms.Button();
            this.BtnChooseFile = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.BGWDataReceive = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblCusAddress);
            this.groupBox1.Controls.Add(this.lblCusCount);
            this.groupBox1.Controls.Add(this.lblPackageCount);
            this.groupBox1.Controls.Add(this.lblCusName);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前信息";
            // 
            // lblCusAddress
            // 
            this.lblCusAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCusAddress.AutoSize = true;
            this.lblCusAddress.Location = new System.Drawing.Point(499, 43);
            this.lblCusAddress.Name = "lblCusAddress";
            this.lblCusAddress.Size = new System.Drawing.Size(82, 14);
            this.lblCusAddress.TabIndex = 4;
            this.lblCusAddress.Text = "客户地址：";
            // 
            // lblCusCount
            // 
            this.lblCusCount.AutoSize = true;
            this.lblCusCount.Location = new System.Drawing.Point(78, 43);
            this.lblCusCount.Name = "lblCusCount";
            this.lblCusCount.Size = new System.Drawing.Size(82, 14);
            this.lblCusCount.TabIndex = 3;
            this.lblCusCount.Text = "商户总量：";
            // 
            // lblPackageCount
            // 
            this.lblPackageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPackageCount.AutoSize = true;
            this.lblPackageCount.Location = new System.Drawing.Point(682, 17);
            this.lblPackageCount.Name = "lblPackageCount";
            this.lblPackageCount.Size = new System.Drawing.Size(67, 14);
            this.lblPackageCount.TabIndex = 2;
            this.lblPackageCount.Text = "总包数：";
            // 
            // lblCusName
            // 
            this.lblCusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(499, 17);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(82, 14);
            this.lblCusName.TabIndex = 1;
            this.lblCusName.Text = "客户名称：";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(78, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 14);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "流水编号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DgvOrderData);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1011, 465);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据窗口";
            // 
            // DgvOrderData
            // 
            this.DgvOrderData.AllowUserToAddRows = false;
            this.DgvOrderData.AllowUserToDeleteRows = false;
            this.DgvOrderData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.packageno,
            this.CusName,
            this.LabelingStatus,
            this.LineName,
            this.BillCode,
            this.OrderDate,
            this.CusAddress});
            this.DgvOrderData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOrderData.Location = new System.Drawing.Point(3, 19);
            this.DgvOrderData.Name = "DgvOrderData";
            this.DgvOrderData.ReadOnly = true;
            this.DgvOrderData.RowTemplate.Height = 23;
            this.DgvOrderData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrderData.Size = new System.Drawing.Size(1005, 443);
            this.DgvOrderData.TabIndex = 0;
            this.DgvOrderData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvOrderData_CellFormatting);
            this.DgvOrderData.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgvOrderData_RowPostPaint);
            // 
            // packageno
            // 
            this.packageno.DataPropertyName = "packageno";
            this.packageno.HeaderText = "包号";
            this.packageno.Name = "packageno";
            this.packageno.ReadOnly = true;
            // 
            // CusName
            // 
            this.CusName.DataPropertyName = "CusName";
            this.CusName.HeaderText = "客户名称";
            this.CusName.Name = "CusName";
            this.CusName.ReadOnly = true;
            // 
            // LabelingStatus
            // 
            this.LabelingStatus.DataPropertyName = "LabelingStatus";
            this.LabelingStatus.HeaderText = "是否完成";
            this.LabelingStatus.Name = "LabelingStatus";
            this.LabelingStatus.ReadOnly = true;
            // 
            // LineName
            // 
            this.LineName.DataPropertyName = "LineName";
            this.LineName.HeaderText = "线路名称";
            this.LineName.Name = "LineName";
            this.LineName.ReadOnly = true;
            // 
            // BillCode
            // 
            this.BillCode.DataPropertyName = "BillCode";
            this.BillCode.HeaderText = "订单编号";
            this.BillCode.Name = "BillCode";
            this.BillCode.ReadOnly = true;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "订单日期";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // CusAddress
            // 
            this.CusAddress.DataPropertyName = "CusAddress";
            this.CusAddress.HeaderText = "客户地址";
            this.CusAddress.Name = "CusAddress";
            this.CusAddress.ReadOnly = true;
            // 
            // BtnDataClear
            // 
            this.BtnDataClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDataClear.Location = new System.Drawing.Point(688, 73);
            this.BtnDataClear.Name = "BtnDataClear";
            this.BtnDataClear.Size = new System.Drawing.Size(75, 23);
            this.BtnDataClear.TabIndex = 2;
            this.BtnDataClear.Text = "清除数据";
            this.BtnDataClear.UseVisualStyleBackColor = true;
            this.BtnDataClear.Click += new System.EventHandler(this.BtnDataClear_Click);
            // 
            // BtnDataReceive
            // 
            this.BtnDataReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDataReceive.Location = new System.Drawing.Point(808, 73);
            this.BtnDataReceive.Name = "BtnDataReceive";
            this.BtnDataReceive.Size = new System.Drawing.Size(75, 23);
            this.BtnDataReceive.TabIndex = 3;
            this.BtnDataReceive.Text = "数据接收";
            this.BtnDataReceive.UseVisualStyleBackColor = true;
            this.BtnDataReceive.Click += new System.EventHandler(this.BtnDataReceive_Click);
            // 
            // BtnChooseFile
            // 
            this.BtnChooseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChooseFile.Location = new System.Drawing.Point(568, 73);
            this.BtnChooseFile.Name = "BtnChooseFile";
            this.BtnChooseFile.Size = new System.Drawing.Size(75, 23);
            this.BtnChooseFile.TabIndex = 4;
            this.BtnChooseFile.Text = "选择文件";
            this.BtnChooseFile.UseVisualStyleBackColor = true;
            this.BtnChooseFile.Click += new System.EventHandler(this.BtnChooseFile_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisplay.Location = new System.Drawing.Point(928, 73);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(75, 23);
            this.BtnDisplay.TabIndex = 5;
            this.BtnDisplay.Text = "屏幕显示";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 78);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 12);
            this.lblPath.TabIndex = 6;
            // 
            // BGWDataReceive
            // 
            this.BGWDataReceive.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWDataReceive_DoWork);
            this.BGWDataReceive.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWDataReceive_RunWorkerCompleted);
            // 
            // w_DataReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1016, 567);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.BtnDisplay);
            this.Controls.Add(this.BtnChooseFile);
            this.Controls.Add(this.BtnDataReceive);
            this.Controls.Add(this.BtnDataClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_DataReceive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_DataReceive_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCusAddress;
        private System.Windows.Forms.Label lblCusCount;
        private System.Windows.Forms.Label lblPackageCount;
        private System.Windows.Forms.Label lblCusName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvOrderData;
        private System.Windows.Forms.Button BtnDataClear;
        private System.Windows.Forms.Button BtnDataReceive;
        private System.Windows.Forms.DataGridViewTextBoxColumn packageno;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelingStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusAddress;
        private System.Windows.Forms.Button BtnChooseFile;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Label lblPath;
        private System.ComponentModel.BackgroundWorker BGWDataReceive;
    }
}