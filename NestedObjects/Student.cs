using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents individual college students
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal first name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Legal last name
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Assigned school email address
        /// </summary>
        public string SchoolEmail { get; set; }
        /// <summary>
        /// Assigned phone number
        /// </summary>
        public string PhoneNumber { get; set; }

    }
}
