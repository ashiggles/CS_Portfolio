using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class StoreOwner
    {
        // fields, operations
        protected string _firstName;
        protected string _lastName;
        protected string _address;
        private string _ssn;

        // Property declaration
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string SSN { get { return _ssn; } set { _ssn = value; } }
        public string Address { get { return _address; } set { _address = value; } }

        // constructors
        public StoreOwner()
        {

        }

        public StoreOwner(string firstName, string lastName, string address, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            SSN = ssn;
        }

        // When owner Adds an Item, add it to overall Inventory
        public void AddsAnItem(ShopItem item, Inventory inventory)
        {
            inventory.InventoryList.Add(item);
            inventory.InventoryCount++;
        }

        // Print useful information for owner
        public void PrintInfo()
        {
            System.Console.WriteLine("********************** Printing Owner Information ************************");
            System.Console.WriteLine("Owner Full Name: " + FirstName + " " + LastName);
            System.Console.WriteLine("Owner Address: " + Address);
            System.Console.WriteLine("Owner ssn: " + SSN);
        }

    }
}
