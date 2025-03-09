namespace InventoryAddForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCompanies
            // 
            this.dgCompanies.ColumnHeadersHeight = 34;
            this.dgCompanies.Location = new System.Drawing.Point(0, 12);
            this.dgCompanies.Name = "dgCompanies";
            this.dgCompanies.RowHeadersWidth = 62;
            this.dgCompanies.Size = new System.Drawing.Size(961, 523);
            this.dgCompanies.TabIndex = 0;
            this.dgCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompanies_CellClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 535);
            this.Controls.Add(this.dgCompanies);
            this.Name = "Form2";
            this.Text = "Companies";
            ((System.ComponentModel.ISupportInitialize)(this.dgCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCompanies;
    }
}