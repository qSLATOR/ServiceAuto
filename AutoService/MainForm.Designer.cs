namespace AutoService
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label lblServiceCost;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Button btnAddRequest;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.ListBox lstRequests;

        private void InitializeComponent()
        {
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.btnAddRequest = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(12, 15);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(34, 13);
            this.lblOwnerName.TabIndex = 0;
            this.lblOwnerName.Text = "ФИО";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(96, 12);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(200, 20);
            this.txtOwnerName.TabIndex = 1;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(12, 41);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(66, 13);
            this.lblCarModel.TabIndex = 2;
            this.lblCarModel.Text = "Марка авто";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(96, 38);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(200, 20);
            this.txtCarModel.TabIndex = 3;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(12, 67);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(66, 13);
            this.lblServiceType.TabIndex = 4;
            this.lblServiceType.Text = "Вид работы";
            // 
            // txtServiceType
            // 
            this.txtServiceType.Location = new System.Drawing.Point(96, 64);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(200, 20);
            this.txtServiceType.TabIndex = 5;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(12, 93);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(74, 13);
            this.lblServiceDate.TabIndex = 6;
            this.lblServiceDate.Text = "Дата приема";
            this.lblServiceDate.Click += new System.EventHandler(this.lblServiceDate_Click);
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Location = new System.Drawing.Point(96, 90);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(200, 20);
            this.dtpServiceDate.TabIndex = 7;
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Location = new System.Drawing.Point(12, 119);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(62, 13);
            this.lblServiceCost.TabIndex = 8;
            this.lblServiceCost.Text = "Стоимость";
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(96, 116);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(200, 20);
            this.txtServiceCost.TabIndex = 9;
            // 
            // btnAddRequest
            // 
            this.btnAddRequest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddRequest.Location = new System.Drawing.Point(15, 142);
            this.btnAddRequest.Name = "btnAddRequest";
            this.btnAddRequest.Size = new System.Drawing.Size(75, 23);
            this.btnAddRequest.TabIndex = 10;
            this.btnAddRequest.Text = "Добавить";
            this.btnAddRequest.UseVisualStyleBackColor = false;
            this.btnAddRequest.Click += new System.EventHandler(this.btnAddRequest_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintReceipt.Location = new System.Drawing.Point(96, 142);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(83, 23);
            this.btnPrintReceipt.TabIndex = 11;
            this.btnPrintReceipt.Text = "Посмотреть";
            this.btnPrintReceipt.UseVisualStyleBackColor = false;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // lstRequests
            // 
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.Location = new System.Drawing.Point(15, 171);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(281, 95);
            this.lstRequests.TabIndex = 12;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(314, 282);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnAddRequest);
            this.Controls.Add(this.txtServiceCost);
            this.Controls.Add(this.lblServiceCost);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.lblOwnerName);
            this.Name = "MainForm";
            this.Text = "Автосервис";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}