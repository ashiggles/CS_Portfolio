using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class Inventory
    {
        // fields, operations
        protected List<ShopItem> _inventoryList;
        protected int _inventoryCount;

        // Property declaration
        public List<ShopItem> InventoryList { get { return _inventoryList; } set { _inventoryList = value; } }
        public int InventoryCount { get { return _inventoryCount; } set { _inventoryCount = value; } }

        // constructors
        public Inventory()
        {
            InventoryList = new List<ShopItem>();
            InventoryCount = 0;
        }

        // Print useful list of information on Inventory
        public void PrintInventoryInfo()
        {
            System.Console.WriteLine("********************** Printing Inventory Information ************************");
            for (int i = 0; i < InventoryList.Count; i++)
            {
                ShopItem item = InventoryList[i];
                if (item != null)
                {
                    item.PrintInfo();
                }
            }
        }

    }
}
