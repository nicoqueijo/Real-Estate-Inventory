namespace RealEstateInventory
{
    partial class MainForm
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
            this.propertyListComboBox = new System.Windows.Forms.ComboBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.addPropertyGroupBox = new System.Windows.Forms.GroupBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.propertiesTotalCostGroupBox = new System.Windows.Forms.GroupBox();
            this.propertiesDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.propertiesDetailsListBox = new System.Windows.Forms.ListBox();
            this.calculatePropertiesTotalCostButton = new System.Windows.Forms.Button();
            this.propertiesTotalCostLabel = new System.Windows.Forms.Label();
            this.populatePropertiesButton = new System.Windows.Forms.Button();
            this.addPropertyGroupBox.SuspendLayout();
            this.propertiesTotalCostGroupBox.SuspendLayout();
            this.propertiesDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // propertyListComboBox
            // 
            this.propertyListComboBox.FormattingEnabled = true;
            this.propertyListComboBox.Items.AddRange(new object[] {
            "Single Family Home",
            "Apartment",
            "Shop",
            "Warehouse"});
            this.propertyListComboBox.Location = new System.Drawing.Point(37, 36);
            this.propertyListComboBox.Name = "propertyListComboBox";
            this.propertyListComboBox.Size = new System.Drawing.Size(192, 24);
            this.propertyListComboBox.TabIndex = 0;
            this.propertyListComboBox.Text = "Single Family Home";
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(249, 33);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(75, 30);
            this.addPropertyButton.TabIndex = 1;
            this.addPropertyButton.Text = "Add";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // addPropertyGroupBox
            // 
            this.addPropertyGroupBox.Controls.Add(this.addPropertyButton);
            this.addPropertyGroupBox.Controls.Add(this.propertyListComboBox);
            this.addPropertyGroupBox.Location = new System.Drawing.Point(39, 45);
            this.addPropertyGroupBox.Name = "addPropertyGroupBox";
            this.addPropertyGroupBox.Size = new System.Drawing.Size(388, 91);
            this.addPropertyGroupBox.TabIndex = 2;
            this.addPropertyGroupBox.TabStop = false;
            this.addPropertyGroupBox.Text = "Add Property";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // propertiesTotalCostGroupBox
            // 
            this.propertiesTotalCostGroupBox.Controls.Add(this.propertiesTotalCostLabel);
            this.propertiesTotalCostGroupBox.Controls.Add(this.calculatePropertiesTotalCostButton);
            this.propertiesTotalCostGroupBox.Location = new System.Drawing.Point(463, 45);
            this.propertiesTotalCostGroupBox.Name = "propertiesTotalCostGroupBox";
            this.propertiesTotalCostGroupBox.Size = new System.Drawing.Size(342, 91);
            this.propertiesTotalCostGroupBox.TabIndex = 3;
            this.propertiesTotalCostGroupBox.TabStop = false;
            this.propertiesTotalCostGroupBox.Text = "Properties Total Cost";
            // 
            // propertiesDetailsGroupBox
            // 
            this.propertiesDetailsGroupBox.Controls.Add(this.populatePropertiesButton);
            this.propertiesDetailsGroupBox.Controls.Add(this.propertiesDetailsListBox);
            this.propertiesDetailsGroupBox.Location = new System.Drawing.Point(39, 167);
            this.propertiesDetailsGroupBox.Name = "propertiesDetailsGroupBox";
            this.propertiesDetailsGroupBox.Size = new System.Drawing.Size(766, 315);
            this.propertiesDetailsGroupBox.TabIndex = 4;
            this.propertiesDetailsGroupBox.TabStop = false;
            this.propertiesDetailsGroupBox.Text = "Properties Details";
            // 
            // propertiesDetailsListBox
            // 
            this.propertiesDetailsListBox.FormattingEnabled = true;
            this.propertiesDetailsListBox.ItemHeight = 16;
            this.propertiesDetailsListBox.Location = new System.Drawing.Point(41, 36);
            this.propertiesDetailsListBox.Name = "propertiesDetailsListBox";
            this.propertiesDetailsListBox.Size = new System.Drawing.Size(682, 212);
            this.propertiesDetailsListBox.TabIndex = 0;
            // 
            // calculatePropertiesTotalCostButton
            // 
            this.calculatePropertiesTotalCostButton.Location = new System.Drawing.Point(23, 33);
            this.calculatePropertiesTotalCostButton.Name = "calculatePropertiesTotalCostButton";
            this.calculatePropertiesTotalCostButton.Size = new System.Drawing.Size(97, 30);
            this.calculatePropertiesTotalCostButton.TabIndex = 0;
            this.calculatePropertiesTotalCostButton.Text = "Calculate";
            this.calculatePropertiesTotalCostButton.UseVisualStyleBackColor = true;
            this.calculatePropertiesTotalCostButton.Click += new System.EventHandler(this.calculatePropertiesTotalCostButton_Click);
            // 
            // propertiesTotalCostLabel
            // 
            this.propertiesTotalCostLabel.Location = new System.Drawing.Point(145, 39);
            this.propertiesTotalCostLabel.Name = "propertiesTotalCostLabel";
            this.propertiesTotalCostLabel.Size = new System.Drawing.Size(154, 23);
            this.propertiesTotalCostLabel.TabIndex = 1;
            this.propertiesTotalCostLabel.Text = "$ 0.00";
            // 
            // populatePropertiesButton
            // 
            this.populatePropertiesButton.Location = new System.Drawing.Point(327, 265);
            this.populatePropertiesButton.Name = "populatePropertiesButton";
            this.populatePropertiesButton.Size = new System.Drawing.Size(109, 30);
            this.populatePropertiesButton.TabIndex = 1;
            this.populatePropertiesButton.Text = "Populate";
            this.populatePropertiesButton.UseVisualStyleBackColor = true;
            this.populatePropertiesButton.Click += new System.EventHandler(this.populatePropertiesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 517);
            this.Controls.Add(this.propertiesDetailsGroupBox);
            this.Controls.Add(this.propertiesTotalCostGroupBox);
            this.Controls.Add(this.addPropertyGroupBox);
            this.Name = "MainForm";
            this.Text = "Real Estate Inventory";
            this.addPropertyGroupBox.ResumeLayout(false);
            this.propertiesTotalCostGroupBox.ResumeLayout(false);
            this.propertiesDetailsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox propertyListComboBox;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.GroupBox addPropertyGroupBox;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.GroupBox propertiesTotalCostGroupBox;
        private System.Windows.Forms.Label propertiesTotalCostLabel;
        private System.Windows.Forms.Button calculatePropertiesTotalCostButton;
        private System.Windows.Forms.GroupBox propertiesDetailsGroupBox;
        private System.Windows.Forms.Button populatePropertiesButton;
        private System.Windows.Forms.ListBox propertiesDetailsListBox;
    }
}

