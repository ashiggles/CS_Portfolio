using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace InventoryAddForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            #region data bind region

            //Populate Grid
            dgCompanies.DataSource = Utility.GetCompanies();
            //Hide certain columns
            dgCompanies.Columns["ID"].Visible = false;

            //Column changes

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.HeaderText = "Use to Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.Name = "deleteButton";
            deleteColumn.UseColumnTextForButtonValue = true;
            dgCompanies.Columns.Add(deleteColumn);

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.HeaderText = "Live Edit";
            updateColumn.Text = "Update";
            updateColumn.Name = "updateButton";
            updateColumn.UseColumnTextForButtonValue = true;
            dgCompanies.Columns.Add(updateColumn);

            #endregion
        }


        private void dgCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        string companyName = rowToBeOperatedUpon.Cells["CompanyName"].Value.ToString();
                        string contactNumber = rowToBeOperatedUpon.Cells["ContactNumber"].Value.ToString();
                        string address = rowToBeOperatedUpon.Cells["Address"].Value.ToString();

                        Utility.UpdateCompanyById(currentItemId, companyName, contactNumber, address);
                        RefreshGridData();
                    }
                }
                return;
            }
        }

        private void RefreshGridData()
        {
            //Populate Grid
            dgCompanies.DataSource = Utility.GetCompanies();
        }
    }
}
