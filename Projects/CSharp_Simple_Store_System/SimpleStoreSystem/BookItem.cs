using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    // Public enum for Book Type
    public enum BookType { Fiction, NonFiction, ScienceFiction, Fantasy, Horror };

    public class BookItem : ShopItem
    {
        // fields, operations
        protected string _isnb;
        protected string _author;
        protected BookType _bookType;

        // Property declaration
        public string ISNB { get { return _isnb; } set { _isnb = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public BookType BookType { get { return _bookType; } set { _bookType = value; } }

        // constructors
        public BookItem() { }

        public BookItem(int itemID, string itemTitle, string itemDescription, decimal price, string isnb, string author, BookType bookType)
            : base(itemID, itemTitle, itemDescription, price)
        {
            ISNB = isnb;
            Author = author;
            BookType = bookType;
        }

        // Print useful information for Item
        public override void PrintInfo()
        {
            System.Console.WriteLine("********************** Printing Book Item Information ************************");
            base.PrintShopInfo();
            System.Console.WriteLine("ISNB: " + ISNB);
            System.Console.WriteLine("Author: " + Author);
            System.Console.WriteLine("Book Type, Genre: " + BookType);
        }
    }
}
