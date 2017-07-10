using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Class for a warehouse. Defines additional attributes of a commercial property
/// that is of type warehouse. 
/// </summary>
namespace RealEstateInventory
{
    public class Warehouse : CommercialProperty
    {
        public const double AIR_CONDITIONING_MULTIPLIER = 7.5;

        bool _airConditioning;

        /// <summary>
        /// Empty constructor intilizes object with default values.
        /// </summary>
        public Warehouse()
        {
            _airConditioning = false;
        }

        /// <summary>
        /// Constructor intializes object with specified values.
        /// </summary>
        /// <param name="address">The property address</param>
        /// <param name="yearBuilt">The year property was built</param>
        /// <param name="squareFeet">The amount of square feet of the property</param>
        /// <param name="propertyType">The commercial type of this property</param>
        /// <param name="airConditioning">Whether the property has air conditioning</param>
        public Warehouse(string address, int yearBuilt, int squareFeet, Type propertyType, bool airConditioning)
            : base(address, yearBuilt, squareFeet, propertyType)
        {
            _airConditioning = airConditioning;
        }

        /// <summary>
        /// Property for airConditioning variable.
        /// </summary>
        public bool AirConditioning
        {
            get { return _airConditioning; }
            set { _airConditioning = value; }
        }

        /// <summary>
        /// Calculates the price of the property with the following formula:
        /// All properties have a base cost of their number of square feet * PRICE_PER_SQFT.
        /// All properties subtract 0.1% of the base price per year since they were built.
        /// CommercialProperties add 30% of their base price if they are of industrial type, 
        /// 35% if they are retail and 40% if they are offices.
        /// ResidentialProperties add 10% per each Pool, 15% per each TennisCourt and 20% if 
        /// they are Waterfront.
        /// SingleFamilyHomes add 5% if they have a garage.
        /// Apartments add 0.5% for each floor of height.
        /// Shops add 12.5% if they have a parking lot.
        /// Warehouses add 7.5% if they have air conditioning.
        /// </summary>
        /// <returns>The price of the property</returns>
        public override double CalculateCost()
        {
            double finalPrice = 0;
            double basePrice = Property.PRICE_PER_SQFT * SquareFeet;
            int yearsSinceBuilt = Property.YearsSinceBuilt(YearBuilt);
            double depreciation = basePrice * ((yearsSinceBuilt * Property.DEPRECIATION_MULTIPLIER) / 100);
            double industrialBonus = basePrice * (CommercialProperty.INDUSTRIAL_MULTIPLIER / 100);

            double airConditioningBonus = 0;
            if (AirConditioning)
            {
                airConditioningBonus = basePrice * (Warehouse.AIR_CONDITIONING_MULTIPLIER / 100);
            }

            finalPrice = basePrice - depreciation + industrialBonus + airConditioningBonus;
            return finalPrice;
        }

        /// <summary>
        /// Constructs a string that includes the address, year built, square feet, and price.
        /// </summary>
        /// <returns>The string representation of this property</returns>
        public override string ToString()
        {
            return "Warehouse at " + Address + " built in " + YearBuilt + " with " + String.Format("{0:n0}", SquareFeet) +
                " square feet and a cost of $" + String.Format("{0:n}", CalculateCost());
        }
    }
}
