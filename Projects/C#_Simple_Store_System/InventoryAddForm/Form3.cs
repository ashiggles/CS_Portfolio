using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace InventoryAddForm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            //Add Data method to form constructor
            #region Data Binding

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Check if category is choosen
            if (cmbItemType.SelectedIndex >= 0)
            {
                // Filter grid and query for title and category
                (dgItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemTitle LIKE '%{0}%' AND Category = {1}", txtSearch.Text, cmbItemType.SelectedIndex);
            }
            else if (txtSearch.Text != "") // check that title is not empty
            {
                // Filter grid and query title
                (dgItems.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemTitle LIKE '%{0}%'", txtSearch.Text);
            }
            else // else show all items
            {
                dgItems.DataSource = Utility.GetAllItems();
            }
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cell
            int currentItemId = -1;

            DataGridView dg = (DataGridView)sender;
            
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow rowToBeOperatedUpon = dg.Rows[e.RowIndex];
            currentItemId = int.Parse(rowToBeOperatedUpon.Cells["ID"].Value.ToString());

            //If only one cell is selected
            if (dg.SelectedCells.Count == 1)
            {
                if (dg.SelectedCells[0] is DataGridViewButtonCell)
                {
                    DataGridViewButtonCell selectedCell = (DataGridViewButtonCell)dg.SelectedCells[0];
                    if (selectedCell.Value.Equals("Delete"))
                    {

                        Utility.DeleteById(currentItemId);
                        // Refresh grid
                        RefreshGridData();
                        // Use search criteria
                        btnSearch_Click(sender, e);
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
