namespace OCR_Terminal
{
    partial class OrderForm
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
            this.orderFormLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.productOrderLabel = new System.Windows.Forms.Label();
            this.volumeOrderLabel = new System.Windows.Forms.Label();
            this.dateOrderForm = new System.Windows.Forms.Label();
            this.ritaseOrderForm = new System.Windows.Forms.Label();
            this.depoOrderLabel = new System.Windows.Forms.Label();
            this.productOrderComboBox = new System.Windows.Forms.ComboBox();
            this.depoOrderComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ritaseOrderComboBox = new System.Windows.Forms.ComboBox();
            this.loInformationLabel = new System.Windows.Forms.Label();
            this.volumeOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.volumeOrderComboBox = new System.Windows.Forms.ComboBox();
            this.literOrderFormLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cancelOrderBtn = new System.Windows.Forms.Button();
            this.placeOrderBtn = new System.Windows.Forms.Button();
            this.orderFormLayoutPanel.SuspendLayout();
            this.volumeOrderTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderFormLayoutPanel
            // 
            this.orderFormLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.orderFormLayoutPanel.ColumnCount = 2;
            this.orderFormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.orderFormLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.orderFormLayoutPanel.Controls.Add(this.productOrderLabel, 0, 0);
            this.orderFormLayoutPanel.Controls.Add(this.volumeOrderLabel, 0, 1);
            this.orderFormLayoutPanel.Controls.Add(this.dateOrderForm, 0, 4);
            this.orderFormLayoutPanel.Controls.Add(this.ritaseOrderForm, 0, 5);
            this.orderFormLayoutPanel.Controls.Add(this.depoOrderLabel, 0, 3);
            this.orderFormLayoutPanel.Controls.Add(this.productOrderComboBox, 1, 0);
            this.orderFormLayoutPanel.Controls.Add(this.depoOrderComboBox, 1, 3);
            this.orderFormLayoutPanel.Controls.Add(this.dateTimePicker1, 1, 4);
            this.orderFormLayoutPanel.Controls.Add(this.ritaseOrderComboBox, 1, 5);
            this.orderFormLayoutPanel.Controls.Add(this.loInformationLabel, 1, 2);
            this.orderFormLayoutPanel.Controls.Add(this.volumeOrderTableLayoutPanel, 1, 1);
            this.orderFormLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 6);
            this.orderFormLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderFormLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.orderFormLayoutPanel.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.orderFormLayoutPanel.Name = "orderFormLayoutPanel";
            this.orderFormLayoutPanel.RowCount = 7;
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.orderFormLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.orderFormLayoutPanel.Size = new System.Drawing.Size(535, 415);
            this.orderFormLayoutPanel.TabIndex = 0;
            // 
            // productOrderLabel
            // 
            this.productOrderLabel.AutoSize = true;
            this.productOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productOrderLabel.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productOrderLabel.Location = new System.Drawing.Point(6, 3);
            this.productOrderLabel.Name = "productOrderLabel";
            this.productOrderLabel.Size = new System.Drawing.Size(111, 35);
            this.productOrderLabel.TabIndex = 0;
            this.productOrderLabel.Text = "Product";
            this.productOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeOrderLabel
            // 
            this.volumeOrderLabel.AutoSize = true;
            this.volumeOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeOrderLabel.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeOrderLabel.Location = new System.Drawing.Point(6, 41);
            this.volumeOrderLabel.Name = "volumeOrderLabel";
            this.volumeOrderLabel.Size = new System.Drawing.Size(111, 35);
            this.volumeOrderLabel.TabIndex = 1;
            this.volumeOrderLabel.Text = "Volume";
            this.volumeOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateOrderForm
            // 
            this.dateOrderForm.AutoSize = true;
            this.dateOrderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateOrderForm.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOrderForm.Location = new System.Drawing.Point(6, 155);
            this.dateOrderForm.Name = "dateOrderForm";
            this.dateOrderForm.Size = new System.Drawing.Size(111, 35);
            this.dateOrderForm.TabIndex = 3;
            this.dateOrderForm.Text = "Shipment Date";
            this.dateOrderForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ritaseOrderForm
            // 
            this.ritaseOrderForm.AutoSize = true;
            this.ritaseOrderForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ritaseOrderForm.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritaseOrderForm.Location = new System.Drawing.Point(6, 193);
            this.ritaseOrderForm.Name = "ritaseOrderForm";
            this.ritaseOrderForm.Size = new System.Drawing.Size(111, 35);
            this.ritaseOrderForm.TabIndex = 4;
            this.ritaseOrderForm.Text = "Ritase";
            this.ritaseOrderForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // depoOrderLabel
            // 
            this.depoOrderLabel.AutoSize = true;
            this.depoOrderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depoOrderLabel.Location = new System.Drawing.Point(6, 117);
            this.depoOrderLabel.Name = "depoOrderLabel";
            this.depoOrderLabel.Size = new System.Drawing.Size(111, 35);
            this.depoOrderLabel.TabIndex = 5;
            this.depoOrderLabel.Text = "Depo";
            this.depoOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productOrderComboBox
            // 
            this.productOrderComboBox.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productOrderComboBox.FormattingEnabled = true;
            this.productOrderComboBox.Items.AddRange(new object[] {
            "Premium",
            "Pertamax",
            "Solar"});
            this.productOrderComboBox.Location = new System.Drawing.Point(126, 6);
            this.productOrderComboBox.Name = "productOrderComboBox";
            this.productOrderComboBox.Size = new System.Drawing.Size(233, 23);
            this.productOrderComboBox.TabIndex = 6;
            this.productOrderComboBox.Text = "Premium";
            // 
            // depoOrderComboBox
            // 
            this.depoOrderComboBox.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depoOrderComboBox.FormattingEnabled = true;
            this.depoOrderComboBox.Items.AddRange(new object[] {
            "Plumpang",
            "Cikampek",
            "Ujung Berung",
            "Padalarang",
            "Tanjung Gurem"});
            this.depoOrderComboBox.Location = new System.Drawing.Point(126, 120);
            this.depoOrderComboBox.Name = "depoOrderComboBox";
            this.depoOrderComboBox.Size = new System.Drawing.Size(233, 23);
            this.depoOrderComboBox.TabIndex = 8;
            this.depoOrderComboBox.Text = "Plumpang";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 158);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // ritaseOrderComboBox
            // 
            this.ritaseOrderComboBox.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritaseOrderComboBox.FormattingEnabled = true;
            this.ritaseOrderComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ritaseOrderComboBox.Location = new System.Drawing.Point(126, 196);
            this.ritaseOrderComboBox.Name = "ritaseOrderComboBox";
            this.ritaseOrderComboBox.Size = new System.Drawing.Size(233, 23);
            this.ritaseOrderComboBox.TabIndex = 10;
            this.ritaseOrderComboBox.Text = "1";
            // 
            // loInformationLabel
            // 
            this.loInformationLabel.AutoSize = true;
            this.loInformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loInformationLabel.Location = new System.Drawing.Point(126, 79);
            this.loInformationLabel.Name = "loInformationLabel";
            this.loInformationLabel.Size = new System.Drawing.Size(403, 35);
            this.loInformationLabel.TabIndex = 11;
            this.loInformationLabel.Text = "Sisa Loading Order 51000 liter";
            this.loInformationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volumeOrderTableLayoutPanel
            // 
            this.volumeOrderTableLayoutPanel.ColumnCount = 2;
            this.volumeOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.88963F));
            this.volumeOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.11037F));
            this.volumeOrderTableLayoutPanel.Controls.Add(this.volumeOrderComboBox, 0, 0);
            this.volumeOrderTableLayoutPanel.Controls.Add(this.literOrderFormLabel, 1, 0);
            this.volumeOrderTableLayoutPanel.Location = new System.Drawing.Point(126, 44);
            this.volumeOrderTableLayoutPanel.Name = "volumeOrderTableLayoutPanel";
            this.volumeOrderTableLayoutPanel.RowCount = 1;
            this.volumeOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.volumeOrderTableLayoutPanel.Size = new System.Drawing.Size(349, 28);
            this.volumeOrderTableLayoutPanel.TabIndex = 12;
            // 
            // volumeOrderComboBox
            // 
            this.volumeOrderComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.volumeOrderComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.volumeOrderComboBox.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeOrderComboBox.FormattingEnabled = true;
            this.volumeOrderComboBox.Items.AddRange(new object[] {
            "Premium",
            "Pertamax",
            "Solar"});
            this.volumeOrderComboBox.Location = new System.Drawing.Point(3, 3);
            this.volumeOrderComboBox.Name = "volumeOrderComboBox";
            this.volumeOrderComboBox.Size = new System.Drawing.Size(227, 23);
            this.volumeOrderComboBox.TabIndex = 0;
            this.volumeOrderComboBox.Text = "8000";
            // 
            // literOrderFormLabel
            // 
            this.literOrderFormLabel.AutoSize = true;
            this.literOrderFormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.literOrderFormLabel.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.literOrderFormLabel.Location = new System.Drawing.Point(236, 0);
            this.literOrderFormLabel.Name = "literOrderFormLabel";
            this.literOrderFormLabel.Size = new System.Drawing.Size(110, 28);
            this.literOrderFormLabel.TabIndex = 1;
            this.literOrderFormLabel.Text = "liter";
            this.literOrderFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cancelOrderBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.placeOrderBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(126, 234);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 115);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // cancelOrderBtn
            // 
            this.cancelOrderBtn.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrderBtn.Image = global::OCR_Terminal.Properties.Resources.cancel;
            this.cancelOrderBtn.Location = new System.Drawing.Point(8, 23);
            this.cancelOrderBtn.Margin = new System.Windows.Forms.Padding(8, 23, 3, 3);
            this.cancelOrderBtn.Name = "cancelOrderBtn";
            this.cancelOrderBtn.Size = new System.Drawing.Size(98, 55);
            this.cancelOrderBtn.TabIndex = 0;
            this.cancelOrderBtn.Text = "Cancel";
            this.cancelOrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelOrderBtn.UseVisualStyleBackColor = true;
            this.cancelOrderBtn.Click += new System.EventHandler(this.cancelOrderBtn_Click);
            // 
            // placeOrderBtn
            // 
            this.placeOrderBtn.Image = global::OCR_Terminal.Properties.Resources.verify;
            this.placeOrderBtn.Location = new System.Drawing.Point(124, 23);
            this.placeOrderBtn.Margin = new System.Windows.Forms.Padding(8, 23, 3, 3);
            this.placeOrderBtn.Name = "placeOrderBtn";
            this.placeOrderBtn.Size = new System.Drawing.Size(98, 55);
            this.placeOrderBtn.TabIndex = 1;
            this.placeOrderBtn.Text = "Place Order";
            this.placeOrderBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.placeOrderBtn.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 415);
            this.Controls.Add(this.orderFormLayoutPanel);
            this.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Form";
            this.orderFormLayoutPanel.ResumeLayout(false);
            this.orderFormLayoutPanel.PerformLayout();
            this.volumeOrderTableLayoutPanel.ResumeLayout(false);
            this.volumeOrderTableLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel orderFormLayoutPanel;
        private System.Windows.Forms.Label productOrderLabel;
        private System.Windows.Forms.Label volumeOrderLabel;
        private System.Windows.Forms.Label dateOrderForm;
        private System.Windows.Forms.Label ritaseOrderForm;
        private System.Windows.Forms.Label depoOrderLabel;
        private System.Windows.Forms.ComboBox productOrderComboBox;
        private System.Windows.Forms.ComboBox depoOrderComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox ritaseOrderComboBox;
        private System.Windows.Forms.Label loInformationLabel;
        private System.Windows.Forms.TableLayoutPanel volumeOrderTableLayoutPanel;
        private System.Windows.Forms.ComboBox volumeOrderComboBox;
        private System.Windows.Forms.Label literOrderFormLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cancelOrderBtn;
        private System.Windows.Forms.Button placeOrderBtn;
    }
}