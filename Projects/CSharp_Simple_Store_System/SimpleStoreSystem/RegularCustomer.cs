using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    internal class RegularCustomer : Customer
    {
        // fields, operations, all fields and operations are public
        protected string _regularCustomerId;

        // Property declaration
        public string RegularCustomerID { get { return _regularCustomerId; } set { _regularCustomerId = value; } }

        // constructors
        public RegularCustomer() { }

        public RegularCustomer(string customerId, string regularCustomerId, string firstName, string lastName, string address, string ssn)
            : base(customerId, firstName, lastName, address, ssn)
        {
            RegularCustomerID = regularCustomerId;
        }

        // When customer buys an Item, check if item is sold or limits reached, else mark item sold
        public override void BuysAnItem(ShopItem item)
        {
            if (item.ItemSold)
            {
                System.Console.WriteLine("********************** Item is already sold. ************************");
            }
            else if (BoughtItemsCount >= 6)
            {
                System.Console.WriteLine("********************** You have reached your limit on total items. ************************");
            }
            else if ((TotalPriceOfItems + item.Price) >= 3000)
            {
                System.Console.WriteLine("********************** You have reached your limit on total price. ************************");
            }
            else
            {
                if (item is FurnitureItem && item.Price > 500)
                {
                    TotalPriceOfItems += (item.Price - 100);
                }
                else
                {
                    TotalPriceOfItems += item.Price;
                }
                ItemsBought[BoughtItemsCount] = item;
                BoughtItemsCount++;
                item.shopItemSold();
            }

        }

        // Print useful information for Customer
        public override void PrintInfo()
        {
            System.Console.WriteLine("********************** Regular Customer Information ************************");
            base.PrintInfo();
            System.Console.WriteLine("Regular Customer ID: " + RegularCustomerID);
        }

    }
}
