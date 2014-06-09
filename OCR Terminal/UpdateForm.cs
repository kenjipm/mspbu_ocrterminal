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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void cancelUpdateBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmUpdateBtn_Click(object sender, EventArgs e)
        {
            dynamic result = WebService.Request(Url.Service, Url.UpdateStock, "text/json", "POST",
                     new
                     {
                         product = productUpdateComboBox.Text,
                         volume = volumeUpdateTextBox.Text,
                         //verification_date = DateTime.Now.ToString()
                         //another attributes here
                     });

            if ((int)result == 0)
            {
                const string message = "Update stock success.";
                const string caption = "Update stock result";
                var messagebox_result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }

            else
            {
                const string message = "Update stock failed. Check internet connection or user identity!";
                const string caption = "Update stock result";
                var messagebox_result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Error);
            }
        }

        private void updateButtonTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
