namespace AutoService
{
    partial class ReceiptForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblServiceCost;

        private void InitializeComponent()
        {
            this.lblOwnerName = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(13, 13);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(0, 13);
            this.lblOwnerName.TabIndex = 0;
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Location = new System.Drawing.Point(13, 40);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(0, 13);
            this.lblCarModel.TabIndex = 1;
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(13, 67);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(0, 13);
            this.lblServiceType.TabIndex = 2;
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(13, 94);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(0, 13);
            this.lblServiceDate.TabIndex = 3;
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Location = new System.Drawing.Point(13, 121);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(0, 13);
            this.lblServiceCost.TabIndex = 4;
            // 
            // ReceiptForm
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.lblServiceCost);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblOwnerName);
            this.Name = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}