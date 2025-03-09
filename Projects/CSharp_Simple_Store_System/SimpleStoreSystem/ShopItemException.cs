using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class ShopItemException : Exception
    {
        // Properties for use
        public int ItemID;
        public string ItemTitle;
        public decimal Price;
        public string ExceptionMessage { get; }

        // Default Constructor
        public ShopItemException() { }

        // Parameterized Constructor
        public ShopItemException(int itemID, string itemTitle, decimal price)
        {
            ItemID = itemID;
            ItemTitle = itemTitle;
            Price = price;
            ExceptionMessage = "Exception occured for item:\n";
            ExceptionMessage += "ID: " + ItemID + "\n";
            ExceptionMessage += "Title: " + ItemTitle + "\n";
            ExceptionMessage += "The price " + Price + " is Negative\n";
            ExceptionMessage += "Exception occurred at: " + DateTime.Now + "\n";
        }
    }
}
