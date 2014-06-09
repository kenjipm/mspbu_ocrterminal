namespace OCR_Terminal
{
    partial class UpdateForm
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
            this.updateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.productUpdateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cancelUpdateBtn = new System.Windows.Forms.Button();
            this.confirmUpdateBtn = new System.Windows.Forms.Button();
            this.productUpdateComboBox = new System.Windows.Forms.ComboBox();
            this.volumeUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updateTableLayoutPanel.SuspendLayout();
            this.updateButtonTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateTableLayoutPanel
            // 
            this.updateTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.updateTableLayoutPanel.ColumnCount = 2;
            this.updateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.updateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.updateTableLayoutPanel.Controls.Add(this.productUpdateLabel, 0, 0);
            this.updateTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.updateTableLayoutPanel.Controls.Add(this.updateButtonTableLayoutPanel, 1, 2);
            this.updateTableLayoutPanel.Controls.Add(this.productUpdateComboBox, 1, 0);
            this.updateTableLayoutPanel.Controls.Add(this.volumeUpdateTextBox, 1, 1);
            this.updateTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.updateTableLayoutPanel.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
            this.updateTableLayoutPanel.Name = "updateTableLayoutPanel";
            this.updateTableLayoutPanel.RowCount = 3;
            this.updateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.updateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.updateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.updateTableLayoutPanel.Size = new System.Drawing.Size(519, 145);
            this.updateTableLayoutPanel.TabIndex = 0;
            // 
            // productUpdateLabel
            // 
            this.productUpdateLabel.AutoSize = true;
            this.productUpdateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productUpdateLabel.Location = new System.Drawing.Point(6, 3);
            this.productUpdateLabel.Name = "productUpdateLabel";
            this.productUpdateLabel.Size = new System.Drawing.Size(111, 30);
            this.productUpdateLabel.TabIndex = 0;
            this.productUpdateLabel.Text = "Product";
            this.productUpdateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volume";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateButtonTableLayoutPanel
            // 
            this.updateButtonTableLayoutPanel.ColumnCount = 2;
            this.updateButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.updateButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.updateButtonTableLayoutPanel.Controls.Add(this.cancelUpdateBtn, 0, 0);
            this.updateButtonTableLayoutPanel.Controls.Add(this.confirmUpdateBtn, 1, 0);
            this.updateButtonTableLayoutPanel.Location = new System.Drawing.Point(126, 72);
            this.updateButtonTableLayoutPanel.Name = "updateButtonTableLayoutPanel";
            this.updateButtonTableLayoutPanel.RowCount = 1;
            this.updateButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.updateButtonTableLayoutPanel.Size = new System.Drawing.Size(200, 82);
            this.updateButtonTableLayoutPanel.TabIndex = 2;
            this.updateButtonTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.updateButtonTableLayoutPanel_Paint);
            // 
            // cancelUpdateBtn
            // 
            this.cancelUpdateBtn.Image = global::OCR_Terminal.Properties.Resources.cancel;
            this.cancelUpdateBtn.Location = new System.Drawing.Point(3, 3);
            this.cancelUpdateBtn.Name = "cancelUpdateBtn";
            this.cancelUpdateBtn.Size = new System.Drawing.Size(75, 57);
            this.cancelUpdateBtn.TabIndex = 0;
            this.cancelUpdateBtn.Text = "Cancel";
            this.cancelUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cancelUpdateBtn.UseVisualStyleBackColor = true;
            this.cancelUpdateBtn.Click += new System.EventHandler(this.cancelUpdateBtn_Click);
            // 
            // confirmUpdateBtn
            // 
            this.confirmUpdateBtn.Image = global::OCR_Terminal.Properties.Resources.edit;
            this.confirmUpdateBtn.Location = new System.Drawing.Point(103, 3);
            this.confirmUpdateBtn.Name = "confirmUpdateBtn";
            this.confirmUpdateBtn.Size = new System.Drawing.Size(75, 57);
            this.confirmUpdateBtn.TabIndex = 1;
            this.confirmUpdateBtn.Text = "Update";
            this.confirmUpdateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.confirmUpdateBtn.UseVisualStyleBackColor = true;
            this.confirmUpdateBtn.Click += new System.EventHandler(this.confirmUpdateBtn_Click);
            // 
            // productUpdateComboBox
            // 
            this.productUpdateComboBox.FormattingEnabled = true;
            this.productUpdateComboBox.Items.AddRange(new object[] {
            "Premium",
            "Pertamax",
            "Solar"});
            this.productUpdateComboBox.Location = new System.Drawing.Point(126, 6);
            this.productUpdateComboBox.Name = "productUpdateComboBox";
            this.productUpdateComboBox.Size = new System.Drawing.Size(200, 23);
            this.productUpdateComboBox.TabIndex = 3;
            this.productUpdateComboBox.Text = "Premium";
            // 
            // volumeUpdateTextBox
            // 
            this.volumeUpdateTextBox.Location = new System.Drawing.Point(126, 39);
            this.volumeUpdateTextBox.Name = "volumeUpdateTextBox";
            this.volumeUpdateTextBox.Size = new System.Drawing.Size(200, 22);
            this.volumeUpdateTextBox.TabIndex = 4;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 145);
            this.Controls.Add(this.updateTableLayoutPanel);
            this.Font = new System.Drawing.Font("Lato", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.updateTableLayoutPanel.ResumeLayout(false);
            this.updateTableLayoutPanel.PerformLayout();
            this.updateButtonTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel updateTableLayoutPanel;
        private System.Windows.Forms.Label productUpdateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel updateButtonTableLayoutPanel;
        private System.Windows.Forms.ComboBox productUpdateComboBox;
        private System.Windows.Forms.TextBox volumeUpdateTextBox;
        private System.Windows.Forms.Button cancelUpdateBtn;
        private System.Windows.Forms.Button confirmUpdateBtn;
    }
}