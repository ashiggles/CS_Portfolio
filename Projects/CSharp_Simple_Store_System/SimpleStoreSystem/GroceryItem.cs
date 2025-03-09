using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    // Public enum for Grocery Category
    public enum Category { Produce, Fruit, MeatFish, Dairy, Beverages };

    public class GroceryItem : ShopItem
    {

        // fields, operations
        protected DateTime _packageDate;
        protected DateTime _expireDate;
        protected Category _category;

        // Property declaration
        public DateTime PackageDate { get { return _packageDate; } set { _packageDate = value; } }
        public DateTime ExpireDate
        {
            get { return _expireDate; }
            set
            {
                if (value < PackageDate)
                {
                    System.Console.WriteLine("True");
                    throw new ArgumentException("Expiration Date should be greater than Package Date", "Expire Date");
                }
                _expireDate = value;
            }
        }
        public Category Category { 
            get { return _category; } 
            set { _category = value; }
        }

        // constructors
        public GroceryItem() { }

        public GroceryItem(int itemID, string itemTitle, string itemDescription, decimal price, Category category, DateTime expireDate, DateTime packageDate)
            : base(itemID, itemTitle, itemDescription, price)
        {
            PackageDate = packageDate;
            ExpireDate = expireDate;
            Category = category;
        }

        // Print useful information for Item
        public override void PrintInfo()
        {
            System.Console.WriteLine("********************** Printing Grocery Item Information ************************");
            base.PrintShopInfo();
            System.Console.WriteLine("Package Date: " + PackageDate);
            System.Console.WriteLine("Expire Date: " + ExpireDate);
            System.Console.WriteLine("Category: " + Category);
        }
    }
}
