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
/// Program where users can calculate their real estate value. Program allows users to add properties
/// they own and then it will give them an approximate price based on an internal model.
/// </summary>
namespace RealEstateInventory
{
    public partial class MainForm : Form
    {
        public enum PropertyType { SingleFamilyHome, Apartment, Shop, Warehouse }
        private PropertyDatabase propertyDatabase = new PropertyDatabase();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the suitable form depending on the user's choice so the user can enter information
        /// about a property he/she wants to add. If the form that was opened returns with an OK
        /// status, the property is added to the database.
        /// </summary>
        /// <param name="sender">Unused but required</param>
        /// <param name="e">Unused but required</param>
        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            switch(propertyListComboBox.SelectedIndex)
            {
                case (int) PropertyType.SingleFamilyHome:
                    SingleFamilyHomeForm singleFamilyHome = new SingleFamilyHomeForm();
                    if (singleFamilyHome.ShowDialog() == DialogResult.OK)
                    {
                        propertyDatabase.AddProperty(singleFamilyHome.SingleFamilyForm);
                    }
                    break;
                case (int) PropertyType.Apartment:
                    ApartmentForm apartment = new ApartmentForm();
                    if (apartment.ShowDialog() == DialogResult.OK)
                    {
                        propertyDatabase.AddProperty(apartment.Apartment);
                    }
                    break;
                case (int) PropertyType.Shop:
                    ShopForm shop = new ShopForm();
                    if (shop.ShowDialog() == DialogResult.OK)
                    {
                        propertyDatabase.AddProperty(shop.Shop);
                    }
                    break;
                case (int) PropertyType.Warehouse:
                    WarehouseForm warehouse = new WarehouseForm();
                    if (warehouse.ShowDialog() == DialogResult.OK)
                    {
                        propertyDatabase.AddProperty(warehouse.Warehouse);
                    }
                    break;
            }
        }

        /// <summary>
        /// Calculates the total price of all properties in the database at this point in time
        /// and displays it on a label.
        /// </summary>
        /// <param name="sender">Unused but required</param>
        /// <param name="e">Unused but required</param>
        private void calculatePropertiesTotalCostButton_Click(object sender, EventArgs e)
        {
            double totalPropertiesCost = 0;
            foreach (Property property in propertyDatabase.Properties)
            {
                totalPropertiesCost += property.CalculateCost();
            }
            propertiesTotalCostLabel.Text = "$ " + String.Format("{0:n}", totalPropertiesCost);
        }

        /// <summary>
        /// Fetches each ToString() of every property in the database at this point in time
        /// and displays them in a list box.
        /// </summary>
        /// <param name="sender">Unused but required</param>
        /// <param name="e">Unused but required</param>
        private void populatePropertiesButton_Click(object sender, EventArgs e)
        {
            propertiesDetailsListBox.Items.Clear();
            foreach (Property property in propertyDatabase.Properties)
            {
                propertiesDetailsListBox.Items.Add(property.ToString());
            }
        }
    }
}
