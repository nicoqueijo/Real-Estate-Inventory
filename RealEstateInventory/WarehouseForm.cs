using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author: Nicolas Queijo

/// <summary>
/// Form to add a warehouse to the database.
/// </summary>
namespace RealEstateInventory
{
    public partial class WarehouseForm : Form
    {
        Warehouse warehouse;
        private string _address;
        private int _yearBuilt;
        private int _squareFeet;
        private CommercialProperty.Type _propertyType;
        private bool _airConditioning;

        public WarehouseForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Property for warehouse variable.
        /// </summary>
        public Warehouse Warehouse
        {
            get { return warehouse; }
        }

        /// <summary>
        /// Validates the address entered by the user.
        /// </summary>
        /// <param name="enteredAddress">The entered address</param>
        /// <returns>Whether the entered address is valid</returns>
        private bool ValidateAddress(string enteredAddress)
        {
            if (enteredAddress.Length > Property.MAX_ADDRESS_LENGTH || string.IsNullOrEmpty(enteredAddress))
            {
                invalidAddressLabel.Visible = true;
                return false;
            }
            else
            {
                _address = enteredAddress;
                invalidAddressLabel.Visible = false;
                return true;
            }
        }

        /// <summary>
        /// Validates the year built entered by the user.
        /// </summary>
        /// <param name="enteredYearBuilt">The entered year built</param>
        /// <returns>Whether the entered year built is valid</returns>
        private bool ValidateYearBuilt(string enteredYearBuilt)
        {
            if (int.TryParse(enteredYearBuilt, out _yearBuilt))
            {
                if (_yearBuilt < Property.MIN_YEAR_BUILT || _yearBuilt > Property.MAX_YEAR_BUILT)
                {
                    invalidYearBuiltLabel.Visible = true;
                    return false;
                }
                else
                {
                    invalidYearBuiltLabel.Visible = false;
                    return true;
                }
            }
            else
            {
                invalidYearBuiltLabel.Visible = true;
                return false;
            }
        }

        /// <summary>
        /// Validates the square feet entered by the user.
        /// </summary>
        /// <param name="enteredSquareFeet">The entered square feet</param>
        /// <returns>Whether the entered square feet is valid</returns>
        private bool ValidateSquareFeet(string enteredSquareFeet)
        {
            if (int.TryParse(enteredSquareFeet, out _squareFeet))
            {
                if (_squareFeet < Property.MIN_SQUARE_FEET || _squareFeet > Property.MAX_SQUARE_FEET)
                {
                    invalidSquareFeetLabel.Visible = true;
                    return false;
                }
                else
                {
                    invalidSquareFeetLabel.Visible = false;
                    return true;
                }
            }
            else
            {
                invalidSquareFeetLabel.Visible = true;
                return false;
            }
        }

        /// <summary>
        /// If the user entered valid data on every field, the property object is created 
        /// with the specified data and returns to the main form to be added to the database.
        /// </summary>
        /// <param name="sender">Unused but required</param>
        /// <param name="e">Unused but required</param>
        private void addWarehouseButton_Click(object sender, EventArgs e)
        {
            bool validAddress = ValidateAddress(addressTextBox.Text);
            bool validYearBuilt = ValidateYearBuilt(yearBuiltTextBox.Text);
            bool validSquareFeet = ValidateSquareFeet(squareFeetTextBox.Text);

            if (validAddress && validYearBuilt && validSquareFeet)
            {
                _propertyType = CommercialProperty.Type.Industrial;
                _airConditioning = airConditioningYesRadioButton.Checked;
                warehouse = new Warehouse(_address, _yearBuilt, _squareFeet, _propertyType, _airConditioning);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
