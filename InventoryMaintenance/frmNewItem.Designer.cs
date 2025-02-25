﻿namespace InventoryMaintenance
{
    partial class frmNewItem
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
            label1 = new Label();
            txtItemNo = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            rdoPlant = new RadioButton();
            rdoSupply = new RadioButton();
            lblSizeOrManufacturer = new Label();
            cboSizeOrManufacturer = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 78);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Item no:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtItemNo
            // 
            txtItemNo.Location = new Point(151, 77);
            txtItemNo.Name = "txtItemNo";
            txtItemNo.Size = new Size(150, 31);
            txtItemNo.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(151, 125);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 31);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 128);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Description:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(151, 173);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 177);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 4;
            label3.Text = "Price:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(151, 292);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 38);
            btnSave.TabIndex = 6;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(320, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // rdoPlant
            // 
            rdoPlant.AutoSize = true;
            rdoPlant.Location = new Point(151, 28);
            rdoPlant.Name = "rdoPlant";
            rdoPlant.Size = new Size(76, 29);
            rdoPlant.TabIndex = 0;
            rdoPlant.Text = "Plant";
            rdoPlant.UseVisualStyleBackColor = true;
            rdoPlant.CheckedChanged += rdoPlant_CheckedChanged;
            // 
            // rdoSupply
            // 
            rdoSupply.AutoSize = true;
            rdoSupply.Checked = true;
            rdoSupply.Location = new Point(274, 28);
            rdoSupply.Name = "rdoSupply";
            rdoSupply.Size = new Size(92, 29);
            rdoSupply.TabIndex = 1;
            rdoSupply.TabStop = true;
            rdoSupply.Text = "Supply";
            rdoSupply.UseVisualStyleBackColor = true;
            // 
            // lblSizeOrManufacturer
            // 
            lblSizeOrManufacturer.AutoSize = true;
            lblSizeOrManufacturer.Location = new Point(27, 227);
            lblSizeOrManufacturer.Name = "lblSizeOrManufacturer";
            lblSizeOrManufacturer.Size = new Size(121, 25);
            lblSizeOrManufacturer.TabIndex = 10;
            lblSizeOrManufacturer.Text = "Manufacturer:";
            lblSizeOrManufacturer.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboSizeOrManufacturer
            // 
            cboSizeOrManufacturer.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSizeOrManufacturer.FormattingEnabled = true;
            cboSizeOrManufacturer.Location = new Point(151, 223);
            cboSizeOrManufacturer.Name = "cboSizeOrManufacturer";
            cboSizeOrManufacturer.Size = new Size(183, 33);
            cboSizeOrManufacturer.TabIndex = 5;
            // 
            // frmNewItem
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(450, 358);
            ControlBox = false;
            Controls.Add(cboSizeOrManufacturer);
            Controls.Add(lblSizeOrManufacturer);
            Controls.Add(rdoSupply);
            Controls.Add(rdoPlant);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtItemNo);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Inventory Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtItemNo;
        private TextBox txtDescription;
        private Label label2;
        private TextBox txtPrice;
        private Label label3;
        private Button btnSave;
        private Button btnCancel;
        private RadioButton rdoPlant;
        private RadioButton rdoSupply;
        private Label lblSizeOrManufacturer;
        private ComboBox cboSizeOrManufacturer;
    }
}