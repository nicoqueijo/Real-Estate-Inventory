using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Class for a single family home. Defines additional attributes of a residential property
/// that is of type single family home. 
/// </summary>
namespace RealEstateInventory
{
    public class SingleFamilyHome : ResidentialProperty
    {
        public const double GARAGE_MULTIPLIER = 5;

        private bool _garage;

        /// <summary>
        /// Empty constructor intilizes object with default values.
        /// </summary>
        public SingleFamilyHome()
        {
            _garage = false;
        }

        /// <summary>
        /// Constructor intializes object with specified values.
        /// </summary>
        /// <param name="address">The property address</param>
        /// <param name="yearBuilt">The year property was built</param>
        /// <param name="squareFeet">The amount of square feet of the property</param>
        /// <param name="amenities">The amenities the property has</param>
        /// <param name="garage">Whether the property has a garage</param>
        public SingleFamilyHome(string address, int yearBuilt, int squareFeet, List<Addition> amenities,
            bool garage) : base(address, yearBuilt, squareFeet, amenities)
        {
            _garage = garage;
        }

        /// <summary>
        /// Property for garage variable.
        /// </summary>
        public bool Garage
        {
            get { return _garage; }
            set { _garage = value; }
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

            double poolBonus = 0;
            if (Amenities.OfType<Pool>().Any())
            {
                poolBonus = basePrice * (ResidentialProperty.POOL_MULTIPLIER / 100);
            }
            double tennisCourtBonus = 0;
            if (Amenities.OfType<TennisCourt>().Any())
            {
                tennisCourtBonus = basePrice * (ResidentialProperty.TENNIS_COURT_MULTIPLIER / 100);
            }
            double waterfrontBonus = 0;
            if (Amenities.OfType<Waterfront>().Any())
            {
                waterfrontBonus = basePrice * (ResidentialProperty.WATERFRONT_MULTIPLIER / 100);
            }
            double garageBonus = 0;
            if (Garage)
            {
                garageBonus = basePrice * (SingleFamilyHome.GARAGE_MULTIPLIER / 100);
            }
            
            finalPrice = basePrice - depreciation + poolBonus + tennisCourtBonus + waterfrontBonus
                + garageBonus;
            return finalPrice;
        }

        /// <summary>
        /// Constructs a string that includes the address, year built, square feet, and price.
        /// </summary>
        /// <returns>The string representation of this property</returns>
        public override string ToString()
        {
            return "Single Family Home at " + Address + " built in " + YearBuilt + " with " + String.Format("{0:n0}", SquareFeet) +
                " square feet and a cost of $" + String.Format("{0:n}", CalculateCost());
        }
    }
}
