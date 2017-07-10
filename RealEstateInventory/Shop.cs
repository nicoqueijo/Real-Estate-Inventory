using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Class for a shop. Defines additional attributes of a commercial property
/// that is of type shop. 
/// </summary>
namespace RealEstateInventory
{
    public class Shop : CommercialProperty
    {
        public const double PARKLING_LOT_MULTIPLIER = 12.5;

        bool _parkingLot;

        /// <summary>
        /// Empty constructor intilizes object with default values.
        /// </summary>
        public Shop()
        {
            _parkingLot = false;
        }

        /// <summary>
        /// Constructor intializes object with specified values.
        /// </summary>
        /// <param name="address">The property address</param>
        /// <param name="yearBuilt">The year property was built</param>
        /// <param name="squareFeet">The amount of square feet of the property</param>
        /// <param name="propertyType">The commercial type of this property</param>
        /// <param name="parkingLot">Whether the property has a parking lot</param>
        public Shop(string address, int yearBuilt, int squareFeet, Type propertyType, bool parkingLot)
            : base(address, yearBuilt, squareFeet, propertyType)
        {
            _parkingLot = parkingLot;
        }

        /// <summary>
        /// Property for parkingLot variable.
        /// </summary>
        public bool ParkingLot
        {
            get { return _parkingLot; }
            set { _parkingLot = value; }
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
            double retailBonus = basePrice * (CommercialProperty.RETAIL_MULTIPLIER / 100);

            double parkingLotBonus = 0;
            if (ParkingLot)
            {
                parkingLotBonus = basePrice * (Shop.PARKLING_LOT_MULTIPLIER / 100);
            }

            finalPrice = basePrice - depreciation + retailBonus + parkingLotBonus;
            return finalPrice;
        }

        /// <summary>
        /// Constructs a string that includes the address, year built, square feet, and price.
        /// </summary>
        /// <returns>The string representation of this property</returns>
        public override string ToString()
        {
            return "Shop at " + Address + " built in " + YearBuilt + " with " + String.Format("{0:n0}", SquareFeet) +
                " square feet and a cost of $" + String.Format("{0:n}", CalculateCost());
        }
    }
}
