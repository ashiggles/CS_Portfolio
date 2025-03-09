using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class ShopItem : Object, ICloneable
    {
        // fields, operations, all fields and operations protected with properties
        protected int _itemID;
        protected string _itemTitle;
        protected string _itemDescription;
        protected bool _itemSold;
        // one private price variable
        private decimal _price;
        // Declare random for use in clone
        Random random = new Random();

        // Property declaration
        public int ItemID { get { return _itemID; } set { _itemID = value; } }
        public string ItemTitle { get { return _itemTitle; } set { _itemTitle = value; } }
        public string ItemDescription { get { return _itemDescription; } set { _itemDescription = value; } }
        public bool ItemSold { get { return _itemSold; } set { _itemSold = value; } }
        // Price property
        public decimal Price
        {
            get { return _price; }
            set
            {
                NegativeEntry(value, "Price");
                if (value > 1000000m)
                {
                    throw new ArgumentException("Price cannot be over $1,000,000", "Price");
                }
                _price = value;
            }
        }

        // constructors
        public ShopItem()
        {
            Price = 0;
            ItemSold = false;
        }

        public ShopItem(int itemId, string itemTitle, string itemDescription, decimal price)
        {
            ItemID = itemId;
            ItemTitle = itemTitle;
            ItemDescription = itemDescription;
            Price = price;
            ItemSold = false;
        }

        // If customer buys this particular Item, mark it sold
        public void shopItemSold()
        {
            ItemSold = true;
        }

        public virtual void PrintInfo()
        {
            System.Console.WriteLine("********************** Printing Item Information ************************");
            PrintShopInfo();
        }

        // Print useful information for Item
        public void PrintShopInfo()
        {
            System.Console.WriteLine("Item Id: " + ItemID);
            System.Console.WriteLine("Item Title: " + ItemTitle);
            System.Console.WriteLine("Item Description: " + ItemDescription);
            System.Console.WriteLine("Item Price: " + Price);
            System.Console.WriteLine("Item Sold: " + ItemSold);
        }

        // Added this common negative evaluation for items
        public void NegativeEntry(decimal value, string item)
        {
            if (value < 0)
            {
                //throw new ArgumentException(item + "should be positive", item);
                throw new ShopItemException(ItemID, ItemTitle, Price);
            }
        }

        public object Clone()
        {
            ShopItem item = (ShopItem)this.MemberwiseClone();
            item.ItemID = random.Next(10000);
            return item;
        }

    }
}
