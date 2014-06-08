using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Tesseract;

namespace OCR_Terminal
{
    public partial class mspbuTerminalForm : Form
    {

        public mspbuTerminalForm()
        {
            InitializeComponent();
        }

        struct SppForm
		{
            public string Name;
            public string Address;
            public string Police;
            public string Shipment;
            public string Volume;
            public string Quality;
            public string Buyer;
            public string Product;
		};

        private void tabDashboard_Click(object sender, EventArgs e)
        {

        }        

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == "") return;
            if (passwordBox.Text == "") return;

            dynamic result = WebService.Request(Url.Service, Url.Login,
                new
                {
                    username = usernameBox.Text,
                    password = login.createHash(usernameBox.Text, passwordBox.Text)
                });

            if ((int)result == 0)
            {
                navigationTab.Visible = true;
                toolStripPanel.Visible = true;
            }

            //Console.Out.WriteLine("Result = " + result);
            //Console.Out.WriteLine("Id = " + result["Id"]);
            //Console.Out.WriteLine("username = " + result["username"]);
            //Console.Out.WriteLine("password = " + result["password"]);
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openSppFileDialog.ShowDialog(this);
            pathTextBox.Text = openSppFileDialog.FileName;
            scanPictureBox.ImageLocation = openSppFileDialog.FileName;
            using (var engine = new TesseractEngine("./tessdata", "ind", EngineMode.Default))
            {
                Image original_img = new Bitmap(openSppFileDialog.FileName);
                Point crop_point = new Point(300,0);
                Size crop_size = new Size(original_img.Width - 300, original_img.Height);
                Rectangle crop_area = new Rectangle(crop_point, crop_size);
                Image cropped_img = cropImage(original_img, crop_area);
                cropped_img.Save("./cropped_img.png", System.Drawing.Imaging.ImageFormat.Png);
                using (var img = Pix.LoadFromFile("./cropped_img.png"))
                {
                    using (Page page = engine.Process(img))
                    {
                        string spp_str = page.GetText();
                        int parse_state = 0; // 0,2,4,6,8,10,12,14,16=none, 1=nama, 3=alamat, 5=nmrpolisi, 7=nmrshipment, 9=tujuan, 
                                             // 11=pemesanan, 13=denstemp, 15=pembeli, 17=produk
                        var i = 0;
                        SppForm spp = new SppForm();
                        Console.WriteLine(spp_str);
                        for(i=0; i<spp_str.Length; i++) {
                            if (spp_str[i] == ':') {
                                parse_state++;
                            }
                            else {
                                if (parse_state == 1)
                                { // name
                                    spp.Name = spp.Name + spp_str[i];
                                }
                                else if (parse_state == 2)
                                {
                                    spp.Address = spp.Address + spp_str[i];
                                }
                                else if (parse_state == 3)
                                {// nmrpolisi
                                    spp.Police = spp.Police + spp_str[i];
                                }
                                else if (parse_state == 4)
                                {// nmrshipment
                                    spp.Shipment = spp.Shipment + spp_str[i];
                                }
                                else if (parse_state == 6)
                                {// pemesanan
                                    spp.Volume = spp.Volume + spp_str[i];
                                }
                                else if (parse_state == 7)
                                {// denstemp
                                    spp.Quality = spp.Quality + spp_str[i];
                                }
                                else if (parse_state == 8)
                                {// pembeli
                                    spp.Buyer = spp.Buyer + spp_str[i];
                                }
                                else if (parse_state == 9)
                                {// produk
                                    spp.Product = spp.Product + spp_str[i];
                                }
                            }					
                        }

                        setSppTextBox(false);
                        sppNameTextbox.Text = spp.Name;
                        sppAddressTextbox.Text = spp.Address;
                        sppPoliceTextbox.Text = spp.Police;
                        sppShipmentTextbox.Text = spp.Shipment;
                        sppVolumeTextbox.Text = spp.Volume;
                        sppQualityTextbox.Text = spp.Quality;
                        sppBuyerTextbox.Text = spp.Buyer;
                        sppProductTextbox.Text = spp.Product;
                    }
                }
            }
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea, bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }

        private void setSppTextBox(bool isEnabled) {
            sppNameTextbox.Enabled = isEnabled;
            sppAddressTextbox.Enabled = isEnabled;
            sppPoliceTextbox.Enabled = isEnabled;
            sppShipmentTextbox.Enabled = isEnabled;
            sppVolumeTextbox.Enabled = isEnabled;
            sppQualityTextbox.Enabled = isEnabled;
            sppBuyerTextbox.Enabled = isEnabled;
            sppProductTextbox.Enabled = isEnabled;
        }

        private void saveSppBtn_Click(object sender, EventArgs e)
        {

            setSppTextBox(false);
        }

        private void editSppBtn_Click(object sender, EventArgs e)
        {
            setSppTextBox(true);
        }

        private void stockPremiumOrderBtn_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.ShowDialog(this);
        }

        private void stockPertamaxOrderBtn_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.ShowDialog(this);
        }

        private void stockSolarOrderBtn_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.ShowDialog(this);
        }

        private void stockPremiumUpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateForm newUpdateForm = new UpdateForm();
            newUpdateForm.ShowDialog(this);
        }

        private void stockPertamaxUpdateBtn_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.ShowDialog(this);
        }

        private void stockSolarUpdateBtn_Click(object sender, EventArgs e)
        {
            OrderForm newOrderForm = new OrderForm();
            newOrderForm.ShowDialog(this);
        }

    }
}
