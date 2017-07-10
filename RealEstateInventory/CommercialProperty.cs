using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Base class for a commercial property. Defines additional
/// attributes of a property that is of type commercial.
/// </summary>
namespace RealEstateInventory
{
    public abstract class CommercialProperty : Property
    {
        public const double INDUSTRIAL_MULTIPLIER = 30;
        public const double RETAIL_MULTIPLIER = 35;
        public const double OFFICE_MULTIPLIER = 40;

        public enum Type { Industrial, Office, Retail }
        private Type _propertyType;

        /// <summary>
        /// Empty constructor intilizes object with default values.
        /// </summary>
        public CommercialProperty()
        {
            _propertyType = 0;
        }

        /// <summary>
        /// Constructor intializes object with specified values.
        /// </summary>
        /// <param name="address">The property address</param>
        /// <param name="yearBuilt">The year property was built</param>
        /// <param name="squareFeet">The amount of square feet of the property</param>
        /// <param name="propertyType">The type of property</param>
        public CommercialProperty(string address, int yearBuilt, int squareFeet, Type propertyType)
            : base(address, yearBuilt, squareFeet)
        {
            _propertyType = propertyType;
        }

        /// <summary>
        /// Property for propertyType variable.
        /// </summary>
        public Type PropertyType
        {
            get { return _propertyType; }
            set { _propertyType = value; }
        }
    }
}
