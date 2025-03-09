using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStoreSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Start Inventory
            Inventory inventory = new Inventory();
            // Start Owner
            StoreOwner owner = new StoreOwner("John", "Doe", "123 Main St", "111-111-1111");
            // Add items
            FurnitureItem furnitureItem1 = new FurnitureItem(1, "Sofa", "Reclining one", 800m, 6m, 3m, 2m, 40);
            FurnitureItem furnitureItem2 = new FurnitureItem(2, "Chair", "Non Reclining beige color", 50m, 1m, 1m, 1m, 10);
            FurnitureItem furnitureItem3 = new FurnitureItem(3, "Dinning Table", "Nice and Strong", 3000m, 8m, 2m, 1m, 200);
            FurnitureItem furnitureItem4 = new FurnitureItem(4, "Bed", "Cool and Comfy", 1100m, 8m, 2m, 1m, 100);
            FurnitureItem furnitureItem5 = new FurnitureItem(34, "Very Costly Item", "Just for Demo", 9900, 1, 1, 1, 1);
            FurnitureItem furnitureItem500Plus = new FurnitureItem(345, "500+", "500 Plus", 501, 1, 1, 1, 1);
            owner.AddsAnItem(furnitureItem1, inventory);
            owner.AddsAnItem(furnitureItem2, inventory);
            owner.AddsAnItem(furnitureItem3, inventory);
            owner.AddsAnItem(furnitureItem4, inventory);
            owner.AddsAnItem(furnitureItem5, inventory);
            owner.AddsAnItem(furnitureItem500Plus, inventory);
            GroceryItem groceryItem1 = new GroceryItem(5, "Bulk apples", "Too many apples", 20m, Category.Fruit, DateTime.Today, DateTime.Today.AddDays(-14));
            GroceryItem groceryItem2 = new GroceryItem(6, "30 lb Meat", "Too much meat", 9m, Category.Fruit, DateTime.Today, DateTime.Today.AddDays(-10));
            owner.AddsAnItem(groceryItem1, inventory);
            owner.AddsAnItem(groceryItem2, inventory);
            BookItem book1 = new BookItem(7, "A Good Programming Book", "A very good book", 49m, "1-1-11-1111", "Karen S", BookType.NonFiction);
            BookItem book2 = new BookItem(8, "An Excellent English Grammer Book", "A very good but costly grammar book", 1000m, "2-2-22-2222", "Dave D", BookType.NonFiction);
            BookItem book3 = new BookItem(8, "An Excellent English Grammer Book 2", "A very good but costly grammar book 2", 100m, "2-2-22-2222", "John Doe", BookType.NonFiction);
            owner.AddsAnItem(book1, inventory);
            owner.AddsAnItem(book2, inventory);
            owner.AddsAnItem(book3, inventory);

            // Print entire inventory
            System.Console.WriteLine("*************** Printing entire inventory\n");
            inventory.PrintInventoryInfo();

            // Start of LINQ
            System.Console.WriteLine("\n************* Using LINQ.\n");

            // Query 1: Find all the furniture items in the inventory.
            System.Console.WriteLine("************* Query 1: Find all the furniture items in the inventory.");
            List<ShopItem> allFurnitureList = inventory.InventoryList.Where(x => x is FurnitureItem).ToList();
            
            foreach (ShopItem s in allFurnitureList)
            {
                s.PrintInfo();
            }

            // Query 2: Find all the items in the inventory that are priced at less than 50$. 
            System.Console.WriteLine("************* Query 2: Find all the items in the inventory that are priced at less than 50$.");
            List <ShopItem> allItemsLessThan50 = inventory.InventoryList.Where(x => x.Price < 50).ToList();
            
            foreach (ShopItem s in allItemsLessThan50)
            {
                s.PrintInfo();
            }

            // Query 3: Find all the grocery items that are priced at less than 10$. 
            System.Console.WriteLine("************* Query 3: Find all the grocery items that are priced at less than 10$.");
            List<ShopItem> allGroceryItemsLessThan10 = inventory.InventoryList.Where(x => x.Price < 10 && x is GroceryItem).ToList();

            foreach (ShopItem s in allGroceryItemsLessThan10)
            {
                s.PrintInfo();
            }

            // Query 4: Find all the books in the inventory whose author is "John Doe". 
            System.Console.WriteLine("************* Query 4: Find all the books in the inventory whose author is \"John Doe\".");
            List<BookItem> allBooksWithAuthorJohnDoe = inventory.InventoryList.Where(z => z is BookItem).Select(x => (BookItem)x).Where(y => y.Author == "John Doe").ToList();

            foreach (BookItem b in allBooksWithAuthorJohnDoe)
            {
                b.PrintInfo();
            }

            // Query 5: Sort the shop items in descending order by price. 
            System.Console.WriteLine("************* Query 5: Sort the shop items in descending order by price.");
            List<ShopItem> sortByPriceDesc = inventory.InventoryList.OrderByDescending(x => x.Price).ToList();

            foreach (ShopItem s in sortByPriceDesc)
            {
                s.PrintInfo();
            }

            // Query 6: Find and sort all the books in ascending order by title.
            System.Console.WriteLine("************* Query 6: Find and sort all the books in ascending order by title.");
            List<BookItem> sortBooksByTitleAsc = inventory.InventoryList.Where(z => z is BookItem).Select(x => (BookItem)x).OrderBy(y => y.ItemTitle).ToList();

            foreach (BookItem b in sortBooksByTitleAsc)
            {
                b.PrintInfo();
            }

            // Query 7: Find the costliest item in the inventory. 
            System.Console.WriteLine("************* Query 7: Find the costliest item in the inventory.");
            decimal costliestItem = inventory.InventoryList.Max(x => x.Price);
            System.Console.WriteLine("Costliest Item: " + costliestItem);

            // Query 8: Find the average price of grocery items.
            System.Console.WriteLine("************* Query 8: Find the average price of grocery items.");
            decimal averagePriceOfGroceries = inventory.InventoryList.Where(x => x is GroceryItem).Average(y => y.Price);
            System.Console.WriteLine("Average Price of Groceries: " + averagePriceOfGroceries);


            System.Console.ReadLine();

        }
    }
}
