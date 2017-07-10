namespace RealEstateInventory
{
    partial class ShopForm
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
            this.propertyTypeLabel = new System.Windows.Forms.Label();
            this.parkingLotLabel = new System.Windows.Forms.Label();
            this.officeRadioButton = new System.Windows.Forms.RadioButton();
            this.industrialRadioButton = new System.Windows.Forms.RadioButton();
            this.retailRadioButton = new System.Windows.Forms.RadioButton();
            this.invalidSquareFeetLabel = new System.Windows.Forms.Label();
            this.invalidAddressLabel = new System.Windows.Forms.Label();
            this.parkingLotGroupBox = new System.Windows.Forms.GroupBox();
            this.parkingLotYesRadioButton = new System.Windows.Forms.RadioButton();
            this.parkingLotNoRadioButton = new System.Windows.Forms.RadioButton();
            this.propertyTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.invalidYearBuiltLabel = new System.Windows.Forms.Label();
            this.addShopButton = new System.Windows.Forms.Button();
            this.yearBuiltTextBox = new System.Windows.Forms.TextBox();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.squareFeetLabel = new System.Windows.Forms.Label();
            this.yearBuiltLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.parkingLotGroupBox.SuspendLayout();
            this.propertyTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyTypeLabel
            // 
            this.propertyTypeLabel.AutoSize = true;
            this.propertyTypeLabel.Location = new System.Drawing.Point(55, 259);
            this.propertyTypeLabel.Name = "propertyTypeLabel";
            this.propertyTypeLabel.Size = new System.Drawing.Size(102, 17);
            this.propertyTypeLabel.TabIndex = 10;
            this.propertyTypeLabel.Text = "Property Type:";
            // 
            // parkingLotLabel
            // 
            this.parkingLotLabel.AutoSize = true;
            this.parkingLotLabel.Location = new System.Drawing.Point(55, 339);
            this.parkingLotLabel.Name = "parkingLotLabel";
            this.parkingLotLabel.Size = new System.Drawing.Size(84, 17);
            this.parkingLotLabel.TabIndex = 15;
            this.parkingLotLabel.Text = "Parking Lot:";
            // 
            // officeRadioButton
            // 
            this.officeRadioButton.AutoSize = true;
            this.officeRadioButton.Enabled = false;
            this.officeRadioButton.Location = new System.Drawing.Point(98, 11);
            this.officeRadioButton.Name = "officeRadioButton";
            this.officeRadioButton.Size = new System.Drawing.Size(66, 21);
            this.officeRadioButton.TabIndex = 13;
            this.officeRadioButton.Text = "Office";
            this.officeRadioButton.UseVisualStyleBackColor = true;
            // 
            // industrialRadioButton
            // 
            this.industrialRadioButton.AutoSize = true;
            this.industrialRadioButton.Enabled = false;
            this.industrialRadioButton.Location = new System.Drawing.Point(6, 11);
            this.industrialRadioButton.Name = "industrialRadioButton";
            this.industrialRadioButton.Size = new System.Drawing.Size(86, 21);
            this.industrialRadioButton.TabIndex = 12;
            this.industrialRadioButton.Text = "Industrial";
            this.industrialRadioButton.UseVisualStyleBackColor = true;
            // 
            // retailRadioButton
            // 
            this.retailRadioButton.AutoSize = true;
            this.retailRadioButton.Checked = true;
            this.retailRadioButton.Enabled = false;
            this.retailRadioButton.Location = new System.Drawing.Point(170, 11);
            this.retailRadioButton.Name = "retailRadioButton";
            this.retailRadioButton.Size = new System.Drawing.Size(65, 21);
            this.retailRadioButton.TabIndex = 14;
            this.retailRadioButton.TabStop = true;
            this.retailRadioButton.Text = "Retail";
            this.retailRadioButton.UseVisualStyleBackColor = true;
            // 
            // invalidSquareFeetLabel
            // 
            this.invalidSquareFeetLabel.AutoSize = true;
            this.invalidSquareFeetLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidSquareFeetLabel.Location = new System.Drawing.Point(55, 217);
            this.invalidSquareFeetLabel.Name = "invalidSquareFeetLabel";
            this.invalidSquareFeetLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invalidSquareFeetLabel.Size = new System.Drawing.Size(164, 17);
            this.invalidSquareFeetLabel.TabIndex = 9;
            this.invalidSquareFeetLabel.Text = "Please enter a valid sq ft";
            this.invalidSquareFeetLabel.Visible = false;
            // 
            // invalidAddressLabel
            // 
            this.invalidAddressLabel.AutoSize = true;
            this.invalidAddressLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidAddressLabel.Location = new System.Drawing.Point(55, 73);
            this.invalidAddressLabel.Name = "invalidAddressLabel";
            this.invalidAddressLabel.Size = new System.Drawing.Size(188, 17);
            this.invalidAddressLabel.TabIndex = 3;
            this.invalidAddressLabel.Text = "Please enter a valid address";
            this.invalidAddressLabel.Visible = false;
            // 
            // parkingLotGroupBox
            // 
            this.parkingLotGroupBox.Controls.Add(this.parkingLotYesRadioButton);
            this.parkingLotGroupBox.Controls.Add(this.parkingLotNoRadioButton);
            this.parkingLotGroupBox.Location = new System.Drawing.Point(58, 359);
            this.parkingLotGroupBox.Name = "parkingLotGroupBox";
            this.parkingLotGroupBox.Size = new System.Drawing.Size(118, 40);
            this.parkingLotGroupBox.TabIndex = 16;
            this.parkingLotGroupBox.TabStop = false;
            // 
            // parkingLotYesRadioButton
            // 
            this.parkingLotYesRadioButton.AutoSize = true;
            this.parkingLotYesRadioButton.Location = new System.Drawing.Point(6, 13);
            this.parkingLotYesRadioButton.Name = "parkingLotYesRadioButton";
            this.parkingLotYesRadioButton.Size = new System.Drawing.Size(53, 21);
            this.parkingLotYesRadioButton.TabIndex = 17;
            this.parkingLotYesRadioButton.Text = "Yes";
            this.parkingLotYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // parkingLotNoRadioButton
            // 
            this.parkingLotNoRadioButton.AutoSize = true;
            this.parkingLotNoRadioButton.Checked = true;
            this.parkingLotNoRadioButton.Location = new System.Drawing.Point(65, 13);
            this.parkingLotNoRadioButton.Name = "parkingLotNoRadioButton";
            this.parkingLotNoRadioButton.Size = new System.Drawing.Size(47, 21);
            this.parkingLotNoRadioButton.TabIndex = 18;
            this.parkingLotNoRadioButton.TabStop = true;
            this.parkingLotNoRadioButton.Text = "No";
            this.parkingLotNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // propertyTypeGroupBox
            // 
            this.propertyTypeGroupBox.Controls.Add(this.industrialRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.officeRadioButton);
            this.propertyTypeGroupBox.Controls.Add(this.retailRadioButton);
            this.propertyTypeGroupBox.Location = new System.Drawing.Point(58, 279);
            this.propertyTypeGroupBox.Name = "propertyTypeGroupBox";
            this.propertyTypeGroupBox.Size = new System.Drawing.Size(248, 40);
            this.propertyTypeGroupBox.TabIndex = 11;
            this.propertyTypeGroupBox.TabStop = false;
            // 
            // invalidYearBuiltLabel
            // 
            this.invalidYearBuiltLabel.AutoSize = true;
            this.invalidYearBuiltLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidYearBuiltLabel.Location = new System.Drawing.Point(55, 146);
            this.invalidYearBuiltLabel.Name = "invalidYearBuiltLabel";
            this.invalidYearBuiltLabel.Size = new System.Drawing.Size(165, 17);
            this.invalidYearBuiltLabel.TabIndex = 6;
            this.invalidYearBuiltLabel.Text = "Please enter a valid year";
            this.invalidYearBuiltLabel.Visible = false;
            // 
            // addShopButton
            // 
            this.addShopButton.Location = new System.Drawing.Point(154, 438);
            this.addShopButton.Name = "addShopButton";
            this.addShopButton.Size = new System.Drawing.Size(75, 23);
            this.addShopButton.TabIndex = 19;
            this.addShopButton.Text = "Add";
            this.addShopButton.UseVisualStyleBackColor = true;
            this.addShopButton.Click += new System.EventHandler(this.addShopButton_Click);
            // 
            // yearBuiltTextBox
            // 
            this.yearBuiltTextBox.Location = new System.Drawing.Point(58, 121);
            this.yearBuiltTextBox.Name = "yearBuiltTextBox";
            this.yearBuiltTextBox.Size = new System.Drawing.Size(100, 22);
            this.yearBuiltTextBox.TabIndex = 5;
            // 
            // squareFeetTextBox
            // 
            this.squareFeetTextBox.Location = new System.Drawing.Point(58, 192);
            this.squareFeetTextBox.Name = "squareFeetTextBox";
            this.squareFeetTextBox.Size = new System.Drawing.Size(100, 22);
            this.squareFeetTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(58, 48);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(248, 22);
            this.addressTextBox.TabIndex = 2;
            // 
            // squareFeetLabel
            // 
            this.squareFeetLabel.AutoSize = true;
            this.squareFeetLabel.Location = new System.Drawing.Point(55, 172);
            this.squareFeetLabel.Name = "squareFeetLabel";
            this.squareFeetLabel.Size = new System.Drawing.Size(90, 17);
            this.squareFeetLabel.TabIndex = 7;
            this.squareFeetLabel.Text = "Square Feet:";
            // 
            // yearBuiltLabel
            // 
            this.yearBuiltLabel.AutoSize = true;
            this.yearBuiltLabel.Location = new System.Drawing.Point(55, 101);
            this.yearBuiltLabel.Name = "yearBuiltLabel";
            this.yearBuiltLabel.Size = new System.Drawing.Size(73, 17);
            this.yearBuiltLabel.TabIndex = 4;
            this.yearBuiltLabel.Text = "Year Built:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(55, 28);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(64, 17);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "Address:";
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 494);
            this.Controls.Add(this.invalidSquareFeetLabel);
            this.Controls.Add(this.invalidAddressLabel);
            this.Controls.Add(this.parkingLotGroupBox);
            this.Controls.Add(this.propertyTypeGroupBox);
            this.Controls.Add(this.invalidYearBuiltLabel);
            this.Controls.Add(this.addShopButton);
            this.Controls.Add(this.yearBuiltTextBox);
            this.Controls.Add(this.squareFeetTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.squareFeetLabel);
            this.Controls.Add(this.yearBuiltLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.parkingLotLabel);
            this.Controls.Add(this.propertyTypeLabel);
            this.Name = "ShopForm";
            this.Text = "Add Shop";
            this.parkingLotGroupBox.ResumeLayout(false);
            this.parkingLotGroupBox.PerformLayout();
            this.propertyTypeGroupBox.ResumeLayout(false);
            this.propertyTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label propertyTypeLabel;
        private System.Windows.Forms.Label parkingLotLabel;
        private System.Windows.Forms.RadioButton officeRadioButton;
        private System.Windows.Forms.RadioButton industrialRadioButton;
        private System.Windows.Forms.RadioButton retailRadioButton;
        private System.Windows.Forms.Label invalidSquareFeetLabel;
        private System.Windows.Forms.Label invalidAddressLabel;
        private System.Windows.Forms.GroupBox parkingLotGroupBox;
        private System.Windows.Forms.RadioButton parkingLotYesRadioButton;
        private System.Windows.Forms.RadioButton parkingLotNoRadioButton;
        private System.Windows.Forms.GroupBox propertyTypeGroupBox;
        private System.Windows.Forms.Label invalidYearBuiltLabel;
        private System.Windows.Forms.Button addShopButton;
        private System.Windows.Forms.TextBox yearBuiltTextBox;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label squareFeetLabel;
        private System.Windows.Forms.Label yearBuiltLabel;
        private System.Windows.Forms.Label addressLabel;
    }
}