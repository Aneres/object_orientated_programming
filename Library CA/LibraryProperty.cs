using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    public abstract class LibraryProperty
    {

        //create attributes
        public string LibraryPropertyItemId { get; set; }
        public string LibraryPropertyType { get; set; }
        public string LibraryPropertyTitle { get; set; }
       
        //create constructor
        public LibraryProperty (string itemId, string propertyType, string propertyTitle)
        {
           LibraryPropertyItemId = itemId;
           LibraryPropertyType = propertyType;
           LibraryPropertyTitle = propertyTitle;
          
        }

        public LibraryProperty (string propertyType, string propertyTitle)
        {
            LibraryPropertyType = propertyType;
            LibraryPropertyTitle = propertyTitle;
        }

        public LibraryProperty (string propertyTitle)
        {
            LibraryPropertyTitle = propertyTitle;
        }



    }
}
