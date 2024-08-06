using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Casting_operator_overloading
{
    // Model:  Employee that class represting a table in the database
    internal class Employee
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PassWord { get; set; }

        public Guid SequertyStamp { get; set; } // Globaly uniqe identifier every time i generate employee it will generate unique guid

        // we always use one of two ways in entity frame work code first or database first
        // must the same names and numbers of the columns be the same with the code and the database
        // but not every time i want to display the data i don't want to diplay all of this data
        // but can't remove anything from here because it must get a the same as the database

    }
}
