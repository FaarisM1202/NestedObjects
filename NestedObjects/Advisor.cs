using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Advisor's work email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The Advisor's room number and location in the building
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}
