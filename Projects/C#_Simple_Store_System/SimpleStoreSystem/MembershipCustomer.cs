using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    internal class MembershipCustomer : Customer
    {
        // fields, operations, all fields and operations are public
        protected string _membershipCustomerId;
        protected decimal _membershipFee;
        protected decimal _membershipDiscount;
        // discount variable for use
        protected decimal _discountPrice;

        // Property declaration
        public string MembershipCustomerID { get { return _membershipCustomerId; } set { _membershipCustomerId = value; } }
        public decimal MembershipFee { get { return _membershipFee; } set { _membershipFee = value; } }
        public decimal MembershipDiscount { get { return _membershipDiscount; } set { _membershipDiscount = value; } }
        public decimal DiscountPrice { get { return _discountPrice; } set { _discountPrice = value; } }

        // constructors
        public MembershipCustomer() { }

        public MembershipCustomer(string customerId, string membershipCustomerId, decimal membershipFee, string firstName, string lastName, string address, string ssn)
            : base(customerId, firstName, lastName, address, ssn)
        {
            MembershipCustomerID = membershipCustomerId;
            MembershipFee = membershipFee;
            MembershipDiscount = 0.05m;
        }

        // When customer buys an Item, check if item is sold or limits reached, else mark item sold
        public override void BuysAnItem(ShopItem item)
        {
            if (item.ItemSold)
            {
                System.Console.WriteLine("********************** Item is already sold. ************************");
            }
            else if (BoughtItemsCount >= 10)
            {
                System.Console.WriteLine("********************** You have reached your limit on total items. ************************");
            }
            else if ((TotalPriceOfItems + item.Price) >= 6000)
            {
                System.Console.WriteLine("********************** You have reached your limit on total price. ************************");
            }
            else
            {
                if (item is FurnitureItem && item.Price > 500)
                {
                    DiscountPrice = (item.Price - 100) - (item.Price * 0.05m);
                }
                else
                {
                    DiscountPrice = item.Price - (item.Price * 0.05m);
                }
                TotalPriceOfItems += DiscountPrice;
                ItemsBought[BoughtItemsCount] = item;
                BoughtItemsCount++;
                item.shopItemSold();
            }

        }

        // Print useful information for Customer
        public override void PrintInfo()
        {
            System.Console.WriteLine("********************** Membership Customer Information ************************");
            base.PrintInfo();
            System.Console.WriteLine("Membership Customer ID: " + MembershipCustomerID);
            System.Console.WriteLine("Membership Fee: " + MembershipFee);
            System.Console.WriteLine("Membership Discount: " + MembershipDiscount);
        }

    }
}
