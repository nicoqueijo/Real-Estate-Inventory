using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Nicolas Queijo

/// <summary>
/// Database class that maintains a list of properties.
/// </summary>
namespace RealEstateInventory
{
    public class PropertyDatabase
    {
        List<Property> properties = new List<Property>();

        /// <summary>
        /// Property for properties variable.
        /// </summary>
        public List<Property> Properties
        {
            get { return properties; }
        }

        /// <summary>
        /// Appends a new property to the list of properties.
        /// </summary>
        /// <param name="property">The property to be added</param>
        public void AddProperty(Property property)
        {
            properties.Add(property);
        }
    }
}
