using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Base class for a property. Defines the basic attributes of a property.
/// </summary>
namespace RealEstateInventory
{
    public abstract class Property
    {
        public const int CURRENT_YEAR = 2017;
        public const int PRICE_PER_SQFT = 150;
        public const int MAX_ADDRESS_LENGTH = 100;
        public const int MIN_YEAR_BUILT = 1900;
        public const int MAX_YEAR_BUILT = 2017;
        public const int MIN_SQUARE_FEET = 20;
        public const int MAX_SQUARE_FEET = 2000000;
        public const int MIN_FLOOR = 1;
        public const int MAX_FLOOR = 150;
        public const double DEPRECIATION_MULTIPLIER = 0.1;

        private string _address;
        private int _yearBuilt;
        private int _squareFeet;

        /// <summary>
        /// Empty constructor intilizes object with default values.
        /// </summary>
        public Property()
        {
            _address = "";
            _yearBuilt = 0;
            _squareFeet = 0;
        }

        /// <summary>
        /// Constructor intializes object with specified values.
        /// </summary>
        /// <param name="address">The property address</param>
        /// <param name="yearBuilt">The year property was built</param>
        /// <param name="squareFeet">The amount of square feet of the property</param>
        public Property(string address, int yearBuilt, int squareFeet)
        {
            _address = address;
            _yearBuilt = yearBuilt;
            _squareFeet = squareFeet;
        }

        /// <summary>
        /// Property for address variable.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Property for yearBuilt variable.
        /// </summary>
        public int YearBuilt
        {
            get { return _yearBuilt; }
            set { _yearBuilt = value; }
        }

        /// <summary>
        /// Property for squareFeet variable.
        /// </summary>
        public int SquareFeet
        {
            get { return _squareFeet; }
            set { _squareFeet = value; }
        }

        /// <summary>
        /// Calculates how much time has elapsed since the property was built by subtracting the
        /// current year to the year the property was built.
        /// </summary>
        /// <param name="yearBuilt">Year property was built</param>
        /// <returns>Elapsed time in years since built</returns>
        public static int YearsSinceBuilt(int yearBuilt)
        {
            return CURRENT_YEAR - yearBuilt;
        }

        public abstract double CalculateCost();
        public abstract string ToString();
    }
}
