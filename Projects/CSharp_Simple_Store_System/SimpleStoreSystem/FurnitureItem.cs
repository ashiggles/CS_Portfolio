using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class FurnitureItem : ShopItem
    {
        // fields, operations
        protected decimal _height;
        protected decimal _width;
        protected decimal _length;
        protected decimal _weight;

        // Property declaration
        public decimal Height
        {
            get { return _height; }
            set
            {
                base.NegativeEntry(_height, "Furniture Height");
                _height = value;
            }
        }

        public decimal Width
        {
            get { return _width; }
            set
            {
                base.NegativeEntry(_width, "Furniture Width");
                _width = value;
            }
        }

        public decimal Length
        {
            get { return _length; }
            set
            {
                base.NegativeEntry(_length, "Furniture Length");
                _length = value;
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                base.NegativeEntry(_weight, "Furniture Weight");
                _weight = value;
            }
        }

        // constructors
        public FurnitureItem() { }

        public FurnitureItem(int itemID, string itemTitle, string itemDescription, decimal price, decimal height, decimal width, decimal length, decimal weight)
            :base(itemID, itemTitle, itemDescription, price)
        {
            Height = height;
            Width = width;
            Length = length;
            Weight = weight;
        }

        // Print useful information for Item
        public override void PrintInfo()
        {
            System.Console.WriteLine("********************** Printing Furniture Item Information ************************");
            base.PrintShopInfo();
            System.Console.WriteLine("Length: " + Length);
            System.Console.WriteLine("Width: " + Width);
            System.Console.WriteLine("Height: " + Height);
            System.Console.WriteLine("Weight: " + Weight);
        }

    }
}
