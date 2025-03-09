using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public abstract class Customer : Object
    {
        // fields, operations
        protected string _firstName;
        protected string _lastName;
        // SSN is private
        private string _ssn;
        protected string _address;
        protected string _customerId;
        protected int _boughtItemsCount;
        protected decimal _totalPriceOfItems;
        protected ShopItem[] _itemsBought;

        // Property declaration
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string SSN { get { return _ssn; } set { _ssn = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string CustomerID { get { return _customerId; } set { _customerId = value; } }
        public int BoughtItemsCount { get { return _boughtItemsCount; } set { _boughtItemsCount = value; } }
        public decimal TotalPriceOfItems { get { return _totalPriceOfItems; } set { _totalPriceOfItems = value; } }
        public ShopItem[] ItemsBought { get { return _itemsBought; } set { _itemsBought = value; } }

        // constructors
        public Customer()
        {
            BoughtItemsCount = 0;
            TotalPriceOfItems = 0;
            ItemsBought = new ShopItem[0];
        }

        public Customer(string customerId, string firstName, string lastName, string address, string ssn)
        {
            CustomerID = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            SSN = ssn;
            BoughtItemsCount = 0;
            TotalPriceOfItems = 0;
            ItemsBought = new ShopItem[100];
        }

        // When customer buys an Item, check if item is sold or limits reached, else mark item sold
        public abstract void BuysAnItem(ShopItem item);

        // Print useful information for customer
        public virtual void PrintInfo()
        {
            System.Console.WriteLine("********************** Printing Customer Information ************************");
            System.Console.WriteLine("Customer ID: " + CustomerID);
            System.Console.WriteLine("Customer Full Name: " + FirstName + " " + LastName);
            System.Console.WriteLine("Customer Address: " + Address);
            System.Console.WriteLine("Customer ssn: " + SSN);
            System.Console.WriteLine("Customer number of items bought: " + BoughtItemsCount);
            System.Console.WriteLine("Customer total price of items bought: " + TotalPriceOfItems);
            System.Console.WriteLine("List of Items bought:");
            for (int i = 0; i < ItemsBought.Length; i++)
            {
                ShopItem item = ItemsBought[i];
                if (item != null)
                {
                    item.PrintInfo();
                }
            }
        }

    }
}
