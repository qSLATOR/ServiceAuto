using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AutoService
{
    public partial class MainForm : Form
    {
        private List<ServiceRequest> serviceRequests = new List<ServiceRequest>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            var serviceRequest = new ServiceRequest
            {
                OwnerName = txtOwnerName.Text,
                CarModel = txtCarModel.Text,
                ServiceType = txtServiceType.Text,
                ServiceDate = dtpServiceDate.Value,
                ServiceCost = decimal.Parse(txtServiceCost.Text)
            };

            serviceRequests.Add(serviceRequest);
            MessageBox.Show("Заявка добавлена!");
            lstRequests.Items.Add(serviceRequest);
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (lstRequests.SelectedItem is ServiceRequest selectedRequest)
            {
                var receipt = new Receipt
                {
                    OwnerName = selectedRequest.OwnerName,
                    CarModel = selectedRequest.CarModel,
                    ServiceType = selectedRequest.ServiceType,
                    ServiceDate = selectedRequest.ServiceDate,
                    ServiceCost = selectedRequest.ServiceCost
                };

                var receiptForm = new ReceiptForm(receipt);
                receiptForm.Show();
            }
        }

        private void btnAddRequest_Click_1(object sender, EventArgs e)
        {
            var serviceRequest = new ServiceRequest
            {
                OwnerName = txtOwnerName.Text,
                CarModel = txtCarModel.Text,
                ServiceType = txtServiceType.Text,
                ServiceDate = dtpServiceDate.Value,
                ServiceCost = decimal.Parse(txtServiceCost.Text)
            };

            serviceRequests.Add(serviceRequest);
            MessageBox.Show("Заявка добавлена!");
            lstRequests.Items.Add(serviceRequest);
        }

        private void lblServiceDate_Click(object sender, EventArgs e)
        {

        }
    }

    public class ServiceRequest
    {
        public string OwnerName { get; set; }
        public string CarModel { get; set; }
        public string ServiceType { get; set; }
        public DateTime ServiceDate { get; set; }
        public decimal ServiceCost { get; set; }

        public override string ToString()
        {
            return $"{OwnerName} - {CarModel} - {ServiceType}";
        }
    }

    public class Receipt
    {
        public string OwnerName { get; set; }
        public string CarModel { get; set; }
        public string ServiceType { get; set; }
        public DateTime ServiceDate { get; set; }
        public decimal ServiceCost { get; set; }
    }
}
