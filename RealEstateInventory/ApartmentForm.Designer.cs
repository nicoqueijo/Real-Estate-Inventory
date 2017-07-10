namespace RealEstateInventory
{
    partial class ApartmentForm
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
            this.invalidSquareFeetLabel = new System.Windows.Forms.Label();
            this.invalidAddressLabel = new System.Windows.Forms.Label();
            this.amenitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.poolCheckBox = new System.Windows.Forms.CheckBox();
            this.tennisCourtCheckBox = new System.Windows.Forms.CheckBox();
            this.waterfrontCheckBox = new System.Windows.Forms.CheckBox();
            this.invalidYearBuiltLabel = new System.Windows.Forms.Label();
            this.amenitiesLabel = new System.Windows.Forms.Label();
            this.addApartmentButton = new System.Windows.Forms.Button();
            this.yearBuiltTextBox = new System.Windows.Forms.TextBox();
            this.squareFeetTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.squareFeetLabel = new System.Windows.Forms.Label();
            this.yearBuiltLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.invalidFloorLabel = new System.Windows.Forms.Label();
            this.amenitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            // amenitiesGroupBox
            // 
            this.amenitiesGroupBox.Controls.Add(this.poolCheckBox);
            this.amenitiesGroupBox.Controls.Add(this.tennisCourtCheckBox);
            this.amenitiesGroupBox.Controls.Add(this.waterfrontCheckBox);
            this.amenitiesGroupBox.Location = new System.Drawing.Point(58, 279);
            this.amenitiesGroupBox.Name = "amenitiesGroupBox";
            this.amenitiesGroupBox.Size = new System.Drawing.Size(292, 40);
            this.amenitiesGroupBox.TabIndex = 11;
            this.amenitiesGroupBox.TabStop = false;
            // 
            // poolCheckBox
            // 
            this.poolCheckBox.AutoSize = true;
            this.poolCheckBox.Location = new System.Drawing.Point(8, 13);
            this.poolCheckBox.Name = "poolCheckBox";
            this.poolCheckBox.Size = new System.Drawing.Size(58, 21);
            this.poolCheckBox.TabIndex = 12;
            this.poolCheckBox.Text = "Pool";
            this.poolCheckBox.UseVisualStyleBackColor = true;
            // 
            // tennisCourtCheckBox
            // 
            this.tennisCourtCheckBox.AutoSize = true;
            this.tennisCourtCheckBox.Location = new System.Drawing.Point(72, 13);
            this.tennisCourtCheckBox.Name = "tennisCourtCheckBox";
            this.tennisCourtCheckBox.Size = new System.Drawing.Size(111, 21);
            this.tennisCourtCheckBox.TabIndex = 13;
            this.tennisCourtCheckBox.Text = "Tennis Court";
            this.tennisCourtCheckBox.UseVisualStyleBackColor = true;
            // 
            // waterfrontCheckBox
            // 
            this.waterfrontCheckBox.AutoSize = true;
            this.waterfrontCheckBox.Location = new System.Drawing.Point(189, 13);
            this.waterfrontCheckBox.Name = "waterfrontCheckBox";
            this.waterfrontCheckBox.Size = new System.Drawing.Size(97, 21);
            this.waterfrontCheckBox.TabIndex = 14;
            this.waterfrontCheckBox.Text = "Waterfront";
            this.waterfrontCheckBox.UseVisualStyleBackColor = true;
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
            // amenitiesLabel
            // 
            this.amenitiesLabel.AutoSize = true;
            this.amenitiesLabel.Location = new System.Drawing.Point(55, 259);
            this.amenitiesLabel.Name = "amenitiesLabel";
            this.amenitiesLabel.Size = new System.Drawing.Size(73, 17);
            this.amenitiesLabel.TabIndex = 10;
            this.amenitiesLabel.Text = "Amenities:";
            // 
            // addApartmentButton
            // 
            this.addApartmentButton.Location = new System.Drawing.Point(154, 438);
            this.addApartmentButton.Name = "addApartmentButton";
            this.addApartmentButton.Size = new System.Drawing.Size(75, 23);
            this.addApartmentButton.TabIndex = 18;
            this.addApartmentButton.Text = "Add";
            this.addApartmentButton.UseVisualStyleBackColor = true;
            this.addApartmentButton.Click += new System.EventHandler(this.addApartmentButton_Click);
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
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(55, 339);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(44, 17);
            this.floorLabel.TabIndex = 15;
            this.floorLabel.Text = "Floor:";
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(58, 359);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(100, 22);
            this.floorTextBox.TabIndex = 16;
            // 
            // invalidFloorLabel
            // 
            this.invalidFloorLabel.AutoSize = true;
            this.invalidFloorLabel.ForeColor = System.Drawing.Color.Red;
            this.invalidFloorLabel.Location = new System.Drawing.Point(56, 384);
            this.invalidFloorLabel.Name = "invalidFloorLabel";
            this.invalidFloorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.invalidFloorLabel.Size = new System.Drawing.Size(165, 17);
            this.invalidFloorLabel.TabIndex = 17;
            this.invalidFloorLabel.Text = "Please enter a valid floor";
            this.invalidFloorLabel.Visible = false;
            // 
            // ApartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 494);
            this.Controls.Add(this.invalidFloorLabel);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(this.invalidSquareFeetLabel);
            this.Controls.Add(this.invalidAddressLabel);
            this.Controls.Add(this.amenitiesGroupBox);
            this.Controls.Add(this.invalidYearBuiltLabel);
            this.Controls.Add(this.amenitiesLabel);
            this.Controls.Add(this.addApartmentButton);
            this.Controls.Add(this.yearBuiltTextBox);
            this.Controls.Add(this.squareFeetTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.squareFeetLabel);
            this.Controls.Add(this.yearBuiltLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.floorLabel);
            this.Name = "ApartmentForm";
            this.Text = "Add Apartment";
            this.amenitiesGroupBox.ResumeLayout(false);
            this.amenitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invalidSquareFeetLabel;
        private System.Windows.Forms.Label invalidAddressLabel;
        private System.Windows.Forms.GroupBox amenitiesGroupBox;
        private System.Windows.Forms.CheckBox poolCheckBox;
        private System.Windows.Forms.CheckBox tennisCourtCheckBox;
        private System.Windows.Forms.CheckBox waterfrontCheckBox;
        private System.Windows.Forms.Label invalidYearBuiltLabel;
        private System.Windows.Forms.Label amenitiesLabel;
        private System.Windows.Forms.Button addApartmentButton;
        private System.Windows.Forms.TextBox yearBuiltTextBox;
        private System.Windows.Forms.TextBox squareFeetTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label squareFeetLabel;
        private System.Windows.Forms.Label yearBuiltLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.Label invalidFloorLabel;
    }
}