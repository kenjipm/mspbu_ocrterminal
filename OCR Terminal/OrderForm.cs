using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCR_Terminal
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void cancelOrderBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            dynamic result = WebService.Request(Url.Service, Url.UploadOrder, "text/json", "POST",
                     new
                     {
                         product = productOrderComboBox.Text,
                         volume = volumeOrderComboBox.Text,
                         depo = depoOrderComboBox.Text,
                         shipment_date = dateTimePicker1.Text,
                         ritase = ritaseOrderComboBox.Text,
                         //verification_date = DateTime.Now.ToString()
                         //another attributes here
                     });

            if ((int)result == 0)
            {
                const string message = "Place order success.";
                const string caption = "Place order result";
                var messagebox_result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }

            else
            {
                const string message = "Place order failed. Check internet connection or user identity!";
                const string caption = "Place order result";
                var messagebox_result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }
    }
}
