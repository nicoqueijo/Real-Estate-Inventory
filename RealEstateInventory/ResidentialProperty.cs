using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Base class for a residential property. Defines additional
/// attributes of a property that is of type residential.
/// </summary>
namespace RealEstateInventory
{
    public abstract class ResidentialProperty : Property
    {
        public const double POOL_MULTIPLIER = 10;
        public const double TENNIS_COURT_MULTIPLIER = 15;
        public const double WATERFRONT_MULTIPLIER = 20;

        private List<Addition> _amenities;

        /// <summary>
        /// Empty constructor intilizes object with default values.
        /// </summary>
        public ResidentialProperty()
        {
            _amenities = new List<Addition>();
        }

        /// <summary>
        /// Constructor intializes object with specified values.
        /// </summary>
        /// <param name="address">The property address</param>
        /// <param name="yearBuilt">The year property was built</param>
        /// <param name="squareFeet">The amount of square feet of the property</param>
        /// <param name="amenities">The amenities the property has</param>
        public ResidentialProperty(string address, int yearBuilt, int squareFeet, List<Addition> amenities)
            : base(address, yearBuilt, squareFeet)
        {
            _amenities = amenities;
        }

        /// <summary>
        /// Property for amenities variable.
        /// </summary>
        public List<Addition> Amenities
        {
            get { return _amenities; }
            set { _amenities = value; }
        }
    }
}
