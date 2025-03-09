using SimpleStoreSystem;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace InventoryAddForm
{
    public partial class Form1 : Form
    {
        // Define objects for use in Form
        protected ShopItem _shopItem;
        protected StoreOwner _owner;
        protected SimpleStoreSystem.Inventory _inventory;
        // Propery Declaration
        public ShopItem ShopItem { get { return _shopItem; } set { _shopItem = value; } }
        public StoreOwner Owner { get { return _owner; } set { _owner = value; } }
        public SimpleStoreSystem.Inventory Inventory { get { return _inventory; } set { _inventory = value; } }

        public Form1()
        {
            InitializeComponent();

            //Add Data method to form constructor
            #region Data Binding


            // Try, catch for getting Category data
            try
            {
                // Bind Category information
                DataAccessLayer.Inventory.CategoryDataTable dtCatTable = Utility.GetCategories();
                //Defines the DataSource
                cmbItemType.DataSource = dtCatTable;
                //Updates the Column that will be displayed in the Items
                cmbItemType.DisplayMember = dtCatTable.CategoryColumn.ColumnName;
                //Assigns the primary key as the value
                cmbItemType.ValueMember = dtCatTable.IDColumn.ColumnName;

                // Bind Company information
                DataAccessLayer.Inventory.CompanyDataTable dtCompTable = Utility.GetCompanies();
                //Defines the DataSource
                cmbCompany.DataSource = dtCompTable;
                //Updates the Column that will be displayed in the Items
                cmbCompany.DisplayMember = dtCompTable.CompanyNameColumn.ColumnName;
                //Assigns the primary key as the value
                cmbCompany.ValueMember = dtCompTable.IDColumn.ColumnName;
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL specific error. Contact your administrator.\n" + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator.\n" + ex.Message);
            }


            //Populate Grid
            dgItems.DataSource = Utility.GetAllItems();

            //Hide certain columns
            dgItems.Columns["ID"].Visible = false;
            dgItems.Columns["CompanyId"].Visible = false;
            dgItems.Columns["Length"].Visible = false;
            dgItems.Columns["Width"].Visible = false;
            dgItems.Columns["Height"].Visible = false;
            dgItems.Columns["Weight"].Visible = false;
            dgItems.Columns["ISBN"].Visible = false;
            dgItems.Columns["Author"].Visible = false;
            dgItems.Columns["BookType"].Visible = false;
            dgItems.Columns["PackagingDate"].Visible = false;
            dgItems.Columns["ExpirationDate"].Visible = false;
            dgItems.Columns["GroceryCategory"].Visible = false;

            //Column changes

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgItems.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Live Edit";
            updateColumn.Text = "Update";
            updateColumn.Name = "updateButton";
            updateColumn.UseColumnTextForButtonValue = true;
            dgItems.Columns.Add(updateColumn);


            #endregion
        }

        // Assign value on submission
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if row is selected and update
            if (dgItems.SelectedRows != null && dgItems.SelectedRows.Count > 0)
            {

                DataGridViewRow rowToBeOperatedUpon = dgItems.Rows[dgItems.CurrentRow.Index];
                int currentItemId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());
                string itemTitle = txtItem.Text;
                int category = cmbItemType.SelectedIndex;
                float price = float.Parse(txtPrice.Text);
                string description = txtDescription.Text;
                int companyId = cmbCompany.SelectedIndex;
                float length = float.Parse(txtLength.Text);
                float width = float.Parse(txtWidth.Text);
                float height = float.Parse(txtHeight.Text);
                float weight = float.Parse(txtWeight.Text);
                string ISBN = txtISBN.Text;
                string Author = txtAuthor.Text;
                int booktype = cmbBookType.SelectedIndex;
                DateTime packageDate = dtPackage.Value;
                DateTime expireDate = dtExpiration.Value;
                int grocerytype = cmbGroceryType.SelectedIndex;
                // use id to update
                Utility.UpdateItemById(currentItemId, itemTitle, category, price, description, companyId, length, width, height, weight, ISBN, Author, booktype, packageDate, expireDate, grocerytype);
                RefreshGridData();
                return;
            }

            // If item type is not chosen, highlight and warn
            if (cmbItemType.SelectedIndex < 0)
            {
                cmbItemType.BackColor = Color.Yellow;
                MessageBox.Show("You must choose an Item Type.");
                return;
            }

            // Try, catch for null items
            try
            {
                // Add to ShopItem
                ShopItem = new ShopItem();
                ShopItem.ItemTitle = txtItem.Text;
                ShopItem.Price = Convert.ToDecimal(txtPrice.Text);
                ShopItem.ItemDescription = txtDescription.Text;
            }
            catch (ShopItemException ex)
            {
                errPrice.SetError(txtPrice, "Price cannot be negative.");
                System.Diagnostics.Debug.WriteLine(ex.ExceptionMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unhandled error. Contact your administrator. Phone number. Or Email Address\n" + ex.Message);
            }

            // String for results
            string results = string.Empty;

            // Assign value based on item type
            int index = cmbItemType.SelectedIndex;
            // Get quantity
            int quantity = Convert.ToInt16(txtQuantity.Text);
            Random randomNum = new Random();
            if (index == 0)
            {
                // Find out book type
                BookType bookType;
                if (cmbBookType.TabIndex == 0)
                {
                    bookType = BookType.Fiction;
                }
                else if (cmbBookType.TabIndex == 1)
                {
                    bookType = BookType.NonFiction;
                }
                else if (cmbBookType.TabIndex == 2)
                {
                    bookType = BookType.ScienceFiction;
                }
                else if (cmbBookType.TabIndex == 3)
                {
                    bookType = BookType.Fantasy;
                }
                else
                {
                    bookType = BookType.Horror;
                }
                // Create book
                BookItem NewItem = new BookItem(
                    randomNum.Next(0, 10000),
                    ShopItem.ItemTitle,
                    ShopItem.ItemDescription,
                    ShopItem.Price,
                    txtISBN.Text,
                    txtAuthor.Text,
                    bookType
                );
                // Owner adds to inventory
                //Owner.AddsAnItem(BookItem, Inventory);
                results = "Book Item\r\n" +
                    "Item: " + NewItem.ItemTitle + "\r\n" +
                    "Price: $" + NewItem.Price + "\r\n" +
                    "Description: " + NewItem.ItemDescription + "\r\n" +
                    "Author: " + NewItem.Author + "\r\n" +
                    "Genre: " + NewItem.BookType;
                // Update InventoryItems table
                for (int i = 0; i < quantity; i++)
                {
                    Utility.SaveInventoryItem(NewItem.ItemTitle, index, (float)NewItem.Price, NewItem.ItemDescription, cmbCompany.SelectedIndex, 0, 0, 0, 0, NewItem.ISNB, NewItem.Author, cmbBookType.TabIndex, DateTime.Now, DateTime.Now, 0);
                }
            }
            else if (index == 1)
            {
                // Create furniture
                FurnitureItem NewItem = new FurnitureItem(
                    randomNum.Next(0, 10000),
                    ShopItem.ItemTitle,
                    ShopItem.ItemDescription,
                    ShopItem.Price,
                    Convert.ToDecimal(txtHeight.Text),
                    Convert.ToDecimal(txtWidth.Text),
                    Convert.ToDecimal(txtLength.Text),
                    Convert.ToDecimal(txtWeight.Text)
                );
                // Owner adds to inventory
                //Owner.AddsAnItem(FurnitureItem, Inventory);
                results = "Furniture Item\r\n" +
                    "Item: " + NewItem.ItemTitle + "\r\n" +
                    "Price: $" + NewItem.Price + "\r\n" +
                    "Description: " + NewItem.ItemDescription + "\r\n" +
                    "Dimensions: " + NewItem.Length + " x " + NewItem.Width + " x " + NewItem.Height + "\r\n" +
                    "Weight: " + NewItem.Weight;
                // Update InventoryItems table
                for (int i = 0; i < quantity; i++)
                {
                    Utility.SaveInventoryItem(NewItem.ItemTitle, index, (float)NewItem.Price, NewItem.ItemDescription, cmbCompany.SelectedIndex, (float)NewItem.Length, (float)NewItem.Width, (float)NewItem.Height, (float)NewItem.Weight, null, null, 0, DateTime.Now, DateTime.Now, 0);
                }
            }
            else if (index == 2)
            {
                // Find out grocery type
                Category category;
                if (cmbGroceryType.SelectedIndex == 0)
                {
                    category = Category.Produce;
                }
                else if (cmbGroceryType.SelectedIndex == 1)
                {
                    category = Category.Fruit;
                }
                else if (cmbGroceryType.SelectedIndex == 2)
                {
                    category = Category.MeatFish;
                }
                else if (cmbGroceryType.SelectedIndex == 3)
                {
                    category = Category.Dairy;
                }
                else
                {
                    category = Category.Beverages;
                }
                // Create grocery item
                GroceryItem NewItem = new GroceryItem(
                    randomNum.Next(0, 10000),
                    ShopItem.ItemTitle,
                    ShopItem.ItemDescription,
                    ShopItem.Price,
                    category,
                    dtExpiration.Value,
                    dtPackage.Value
                );
                // Owner adds to inventory
                //Owner.AddsAnItem(GroceryItem, Inventory);
                results = "Grocery Item\r\n" +
                    "Item: " + NewItem.ItemTitle + "\r\n" +
                    "Price: $" + NewItem.Price + "\r\n" +
                    "Description: " + NewItem.ItemDescription + "\r\n" +
                    "Category: " + NewItem.Category + "\r\n" +
                    "Package Date: " + NewItem.PackageDate + "\r\n" +
                    "Expiration Date: " + NewItem.ExpireDate;
                // Update InventoryItems table
                // Update InventoryItems table
                for (int i = 0; i < quantity; i++)
                {
                    Utility.SaveInventoryItem(NewItem.ItemTitle, index, (float)NewItem.Price, NewItem.ItemDescription, cmbCompany.SelectedIndex, 0, 0, 0, 0, null, null, 0, NewItem.PackageDate, NewItem.ExpireDate, cmbGroceryType.SelectedIndex);
                }
            }

            txtResults.Text = results;
            RefreshGridData();
        }

        // Reset form
        private void btnReset_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        // Combo selection on change
        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Change background back to White
            cmbItemType.BackColor = Color.White;

            // Find index of selected item type
            // Visibility of group based on selection
            int index = cmbItemType.SelectedIndex;
            if (index == 0)
            {
                grpBook.Visible = true;
                grpFurniture.Visible = false;
                grpGrocery.Visible = false;
            }
            else if (index == 1)
            {
                grpFurniture.Visible = true;
                grpBook.Visible = false;
                grpGrocery.Visible = false;
            }
            else if (index == 2)
            {
                grpGrocery.Visible = true;
                grpFurniture.Visible = false;
                grpBook.Visible = false;
            }
        }

        private void dgItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cell
            int currentItemId = -1;

            DataGridView dg = (DataGridView)sender;
            Console.WriteLine("Selected Cell Count: " + dg.SelectedCells.Count);
            Console.WriteLine("RowIndex: " + e.RowIndex);
            Console.WriteLine("ColumnIndex: " + e.ColumnIndex);

            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];
            currentItemId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());

            if (e.ColumnIndex == -1)
            {
                // Set data to inputs
                txtItem.Text = rowToBeOperatedUpon.Cells["ItemTitle"].Value.ToString();
                txtPrice.Text = rowToBeOperatedUpon.Cells["Price"].Value.ToString();
                txtDescription.Text = rowToBeOperatedUpon.Cells["Description"].Value.ToString();
                cmbItemType.SelectedIndex = Convert.ToInt16(rowToBeOperatedUpon.Cells["Category"].Value);
                cmbCompany.SelectedIndex = Convert.ToInt16(rowToBeOperatedUpon.Cells["CompanyId"].Value);
                txtLength.Text = rowToBeOperatedUpon.Cells["Length"].Value.ToString();
                txtWidth.Text = rowToBeOperatedUpon.Cells["Width"].Value.ToString();
                txtHeight.Text = rowToBeOperatedUpon.Cells["Height"].Value.ToString();
                txtWeight.Text = rowToBeOperatedUpon.Cells["Weight"].Value.ToString();
                txtISBN.Text = rowToBeOperatedUpon.Cells["ISBN"].Value.ToString();
                txtAuthor.Text = rowToBeOperatedUpon.Cells["Author"].Value.ToString();
                cmbBookType.SelectedIndex = cmbItemType.SelectedIndex != 0 ? 0: Convert.ToInt16(rowToBeOperatedUpon.Cells["BookType"].Value);
                dtPackage.Text = rowToBeOperatedUpon.Cells["PackagingDate"].Value.ToString();
                dtExpiration.Text = rowToBeOperatedUpon.Cells["ExpirationDate"].Value.ToString();
                cmbGroceryType.SelectedIndex = cmbItemType.SelectedIndex != 2 ? 0 : Convert.ToInt16(rowToBeOperatedUpon.Cells["GroceryCategory"].Value);

                return;
            }

            //If only one cell is selected
            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {

                        Utility.DeleteById(currentItemId);

                        RefreshGridData();

                    }
                    //Cell Update

                    else if (selectedCell.Value.Equals("Update"))
                    {
                        // use id to update
                        string itemTitle = rowToBeOperatedUpon.Cells["ItemTitle"].Value.ToString();
                        int category = Convert.ToInt16(rowToBeOperatedUpon.Cells["Category"].Value);
                        float price = float.Parse(rowToBeOperatedUpon.Cells["Price"].Value.ToString());
                        string description = rowToBeOperatedUpon.Cells["Description"].Value.ToString();
                        int companyId = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["CompanyId"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["CompanyId"].Value.ToString());
                        float length = float.Parse(rowToBeOperatedUpon.Cells["Length"].Value.ToString());
                        float width = float.Parse(rowToBeOperatedUpon.Cells["Width"].Value.ToString());
                        float height = float.Parse(rowToBeOperatedUpon.Cells["Height"].Value.ToString());
                        float weight = float.Parse(rowToBeOperatedUpon.Cells["Weight"].Value.ToString());
                        string ISBN = rowToBeOperatedUpon.Cells["ISBN"].Value.ToString();
                        string author = rowToBeOperatedUpon.Cells["Author"].Value.ToString();
                        int booktype = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["BookType"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["BookType"].Value.ToString());
                        DateTime packageDate = Convert.ToDateTime(rowToBeOperatedUpon.Cells["PackagingDate"].Value);
                        DateTime expireDate = Convert.ToDateTime(rowToBeOperatedUpon.Cells["ExpirationDate"].Value);
                        int grocerytype = string.IsNullOrEmpty(rowToBeOperatedUpon.Cells["GroceryCategory"].Value.ToString()) ? 0 : int.Parse(rowToBeOperatedUpon.Cells["GroceryCategory"].Value.ToString());



                        Utility.UpdateItemById(currentItemId, itemTitle, category, price, description, companyId, length, width, height, weight, ISBN, author, booktype, packageDate, expireDate, grocerytype);
                        RefreshGridData();
                    }
                }
                return;
            }

        }

        private void RefreshGridData()
        {
            //Populate Grid
            dgItems.DataSource = Utility.GetAllItems();
        }
    }
}
