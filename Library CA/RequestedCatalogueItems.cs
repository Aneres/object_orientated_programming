using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    public class RequestedCatalogueItems : LibraryProperty
    {
        //attributes
        public string IssuedDepartment { get; set; }



        //constructor
        public RequestedCatalogueItems(string dept, string itemId, string propertyType, string propertyTitle) : base(itemId, propertyType, propertyTitle)
        {
            IssuedDepartment = dept;
        }


        public RequestedCatalogueItems(string dept, string propertyType, string propertyTitle) : base(propertyType, propertyTitle)
        {
            IssuedDepartment = dept;

        }

        //overidding
        public override string ToString()
        {
            return "\nIssued Department: " + IssuedDepartment + base.ToString();
        }




    }
}
