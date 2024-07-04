using System;
using System.Windows.Forms;

namespace AutoService
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(Receipt receipt)
        {
            InitializeComponent();
            lblOwnerName.Text = $"ФИО владельца: {receipt.OwnerName}";
            lblCarModel.Text = $"Марка автомобиля: {receipt.CarModel}";
            lblServiceType.Text = $"Вид работы: {receipt.ServiceType}";
            lblServiceDate.Text = $"Дата приема заказа: {receipt.ServiceDate.ToShortDateString()}";
            lblServiceCost.Text = $"Стоимость: {receipt.ServiceCost:C}";
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {

        }
    }
}