using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    public class Book : LibraryProperty

    {
        //attribute
        public string IsbnNumber { get; set; }
        public string TextAuthor { get; set; }


        //create book constructor
        public Book(string isbn, string author, string propertyTitle) : base(propertyTitle)
        {
            IsbnNumber = isbn;
            TextAuthor = author;


        }
        //overridden toString
        public override string ToString()
        {
            return "\nISBN: " + IsbnNumber + "\nAuthor: " + TextAuthor;
        }
    }

}