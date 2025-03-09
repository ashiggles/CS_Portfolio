using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccessLayer
{
    public class Utility
    {
        public static Inventory.CategoryDataTable GetCategories()
        {
            // Init adapter
            InventoryTableAdapters.CategoryTableAdapter catAdapter = new InventoryTableAdapters.CategoryTableAdapter();
            // Init table
            Inventory.CategoryDataTable dtCatTable = new Inventory.CategoryDataTable();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                catAdapter.Fill(dtCatTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }

            return dtCatTable;
        }

        public static Inventory.CompanyDataTable GetCompanies()
        {
            // Init adapter
            InventoryTableAdapters.CompanyTableAdapter compAdapter = new InventoryTableAdapters.CompanyTableAdapter();
            // Init table
            Inventory.CompanyDataTable dtCompTable = new Inventory.CompanyDataTable();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                compAdapter.Fill(dtCompTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }

            return dtCompTable;
        }

        public static Inventory.InventoryItemsDataTable GetAllItems()
        {
            // Init adapter
            InventoryTableAdapters.InventoryItemsTableAdapter invAdapter = new InventoryTableAdapters.InventoryItemsTableAdapter();
            // Init table
            Inventory.InventoryItemsDataTable dtInvTable = new Inventory.InventoryItemsDataTable();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                invAdapter.Fill(dtInvTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }
            

            return dtInvTable;
        }

        public static void SaveInventoryItem(string itemTitle, int category, float price, string description, int companyId, float length, float width, float height, float weight, string ISBN, string Author, int bookType, DateTime packageDate, DateTime expirationDate, int groceryCategory)
        {
            // Init adapter
            InventoryTableAdapters.InventoryItemsTableAdapter invAdapter = new InventoryTableAdapters.InventoryItemsTableAdapter();
            // Init table
            Inventory.InventoryItemsDataTable dtInvTable = new Inventory.InventoryItemsDataTable();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                invAdapter.Fill(dtInvTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }
            
            // Populate new row
            Inventory.InventoryItemsRow newRow = dtInvTable.NewInventoryItemsRow();
            newRow.ItemTitle = itemTitle;
            newRow.Category = category;
            newRow.Price = price;
            newRow.Description = description;
            newRow.CompanyId = companyId;
            newRow.Length = length;
            newRow.Width = width;
            newRow.Height = height;
            newRow.Weight = weight;
            newRow.ISBN = ISBN;
            newRow.Author = Author;
            newRow.BookType = bookType;
            newRow.PackagingDate = packageDate;
            newRow.ExpirationDate = expirationDate;
            newRow.GroceryCategory = groceryCategory;

            dtInvTable.AddInventoryItemsRow(newRow);
            // Update database table with new row
            invAdapter.Update(dtInvTable);
        }

        //Delete
        public static void DeleteById(int InvId)
        {
            Inventory.InventoryItemsDataTable dtInvTable = new Inventory.InventoryItemsDataTable();
            InventoryTableAdapters.InventoryItemsTableAdapter invAdapter = new InventoryTableAdapters.InventoryItemsTableAdapter();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                invAdapter.Fill(dtInvTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }
            

            foreach (Inventory.InventoryItemsRow ur in dtInvTable)
            {
                if (ur.ID == InvId)
                {
                    ur.Delete();
                }
            }

            invAdapter.Update(dtInvTable);

        }

        //Update Item
        public static void UpdateItemById(int InvId, string itemTitle, int category, float price, string description, int companyId, float length, float width, float height, float weight, string ISBN, string Author, int bookType, DateTime packageDate, DateTime expirationDate, int groceryCategory)
        {
            Inventory.InventoryItemsDataTable dtInvTable = new Inventory.InventoryItemsDataTable();
            InventoryTableAdapters.InventoryItemsTableAdapter invAdapter = new InventoryTableAdapters.InventoryItemsTableAdapter();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                invAdapter.Fill(dtInvTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }
            

            foreach (Inventory.InventoryItemsRow ur in dtInvTable)
            {
                if (ur.ID == InvId)
                {
                    ur.ItemTitle = itemTitle;
                    ur.Category = category;
                    ur.Price = price;
                    ur.Description = description;
                    ur.CompanyId = companyId;
                    ur.Length = length;
                    ur.Width = width;
                    ur.Height = height;
                    ur.Weight = weight;
                    ur.ISBN = ISBN;
                    ur.Author = Author;
                    ur.BookType = bookType;
                    ur.PackagingDate = packageDate;
                    ur.ExpirationDate = expirationDate;
                    ur.GroceryCategory = groceryCategory;
                }
            }

            invAdapter.Update(dtInvTable);
        }

        //Update Company
        public static void UpdateCompanyById(int compId, string companyName, string contactNumber, string address)
        {
            Inventory.CompanyDataTable dtCompTable = new Inventory.CompanyDataTable();
            InventoryTableAdapters.CompanyTableAdapter compAdapter = new InventoryTableAdapters.CompanyTableAdapter();

            // Try, catch to check SQL connection
            try
            {
                // Fill in data
                compAdapter.Fill(dtCompTable);
            }
            catch (SqlException sqlEx)
            {
                // Log as much data as possible for dev team
                // Using loggers
                System.Diagnostics.Debug.WriteLine(sqlEx);
                System.Diagnostics.Debug.WriteLine(sqlEx.Message);
                System.Diagnostics.Debug.WriteLine(sqlEx.Server);
                System.Diagnostics.Debug.WriteLine(sqlEx.Source);

                throw sqlEx;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                throw ex;
            }
            finally
            {

            }
            

            foreach (Inventory.CompanyRow ur in dtCompTable)
            {
                if (ur.ID == compId)
                {
                    ur.CompanyName = companyName;
                    ur.ContactNumber = contactNumber;
                    ur.Address = address;
                }
            }

            compAdapter.Update(dtCompTable);
        }
    }
}
