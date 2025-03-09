namespace InventoryAddForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblItem = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.grpFurniture = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.cmbBookType = new System.Windows.Forms.ComboBox();
            this.lblBookType = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.grpGrocery = new System.Windows.Forms.GroupBox();
            this.cmbGroceryType = new System.Windows.Forms.ComboBox();
            this.lblGroceryType = new System.Windows.Forms.Label();
            this.dtExpiration = new System.Windows.Forms.DateTimePicker();
            this.lblExpiration = new System.Windows.Forms.Label();
            this.dtPackage = new System.Windows.Forms.DateTimePicker();
            this.lblPackage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.errPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpFurniture.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.grpGrocery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(55, 48);
            this.lblItem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(139, 46);
            this.txtItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(82, 20);
            this.txtItem.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(139, 73);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(82, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(55, 75);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(139, 100);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(268, 36);
            this.txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(55, 102);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(55, 147);
            this.lblItemType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(54, 13);
            this.lblItemType.TabIndex = 6;
            this.lblItemType.Text = "Item Type";
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(139, 145);
            this.cmbItemType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(82, 21);
            this.cmbItemType.TabIndex = 7;
            this.cmbItemType.Text = "--Select One--";
            this.cmbItemType.SelectedIndexChanged += new System.EventHandler(this.cmbItemType_SelectedIndexChanged);
            // 
            // grpFurniture
            // 
            this.grpFurniture.Controls.Add(this.txtWeight);
            this.grpFurniture.Controls.Add(this.lblWeight);
            this.grpFurniture.Controls.Add(this.txtHeight);
            this.grpFurniture.Controls.Add(this.lblHeight);
            this.grpFurniture.Controls.Add(this.txtWidth);
            this.grpFurniture.Controls.Add(this.lblWidth);
            this.grpFurniture.Controls.Add(this.txtLength);
            this.grpFurniture.Controls.Add(this.lblLength);
            this.grpFurniture.Location = new System.Drawing.Point(57, 187);
            this.grpFurniture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFurniture.Name = "grpFurniture";
            this.grpFurniture.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFurniture.Size = new System.Drawing.Size(349, 75);
            this.grpFurniture.TabIndex = 8;
            this.grpFurniture.TabStop = false;
            this.grpFurniture.Text = "Dimensions";
            this.grpFurniture.Visible = false;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(245, 45);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(68, 20);
            this.txtWeight.TabIndex = 7;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(194, 47);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(41, 13);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Weight";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(245, 24);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 20);
            this.txtHeight.TabIndex = 5;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(194, 26);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(82, 45);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(68, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(31, 47);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(82, 24);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(68, 20);
            this.txtLength.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(31, 26);
            this.lblLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.cmbBookType);
            this.grpBook.Controls.Add(this.lblBookType);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.lblAuthor);
            this.grpBook.Controls.Add(this.txtISBN);
            this.grpBook.Controls.Add(this.lblISBN);
            this.grpBook.Location = new System.Drawing.Point(57, 187);
            this.grpBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBook.Name = "grpBook";
            this.grpBook.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBook.Size = new System.Drawing.Size(349, 75);
            this.grpBook.TabIndex = 9;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book Details";
            this.grpBook.Visible = false;
            // 
            // cmbBookType
            // 
            this.cmbBookType.FormattingEnabled = true;
            this.cmbBookType.Items.AddRange(new object[] {
            "Fiction",
            "NonFiction",
            "ScienceFiction",
            "Fantasy",
            "Horror"});
            this.cmbBookType.Location = new System.Drawing.Point(245, 22);
            this.cmbBookType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBookType.Name = "cmbBookType";
            this.cmbBookType.Size = new System.Drawing.Size(82, 21);
            this.cmbBookType.TabIndex = 5;
            this.cmbBookType.Text = "--Select One--";
            // 
            // lblBookType
            // 
            this.lblBookType.AutoSize = true;
            this.lblBookType.Location = new System.Drawing.Point(194, 27);
            this.lblBookType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookType.Name = "lblBookType";
            this.lblBookType.Size = new System.Drawing.Size(31, 13);
            this.lblBookType.TabIndex = 4;
            this.lblBookType.Text = "Type";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(82, 46);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(68, 20);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(31, 48);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(82, 25);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(68, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(31, 27);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN";
            // 
            // grpGrocery
            // 
            this.grpGrocery.Controls.Add(this.cmbGroceryType);
            this.grpGrocery.Controls.Add(this.lblGroceryType);
            this.grpGrocery.Controls.Add(this.dtExpiration);
            this.grpGrocery.Controls.Add(this.lblExpiration);
            this.grpGrocery.Controls.Add(this.dtPackage);
            this.grpGrocery.Controls.Add(this.lblPackage);
            this.grpGrocery.Location = new System.Drawing.Point(57, 187);
            this.grpGrocery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGrocery.Name = "grpGrocery";
            this.grpGrocery.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGrocery.Size = new System.Drawing.Size(349, 106);
            this.grpGrocery.TabIndex = 10;
            this.grpGrocery.TabStop = false;
            this.grpGrocery.Text = "Grocery Details";
            this.grpGrocery.Visible = false;
            // 
            // cmbGroceryType
            // 
            this.cmbGroceryType.FormattingEnabled = true;
            this.cmbGroceryType.Items.AddRange(new object[] {
            "Produce",
            "Fruit",
            "MeatFish",
            "Dairy",
            "Beverages"});
            this.cmbGroceryType.Location = new System.Drawing.Point(115, 68);
            this.cmbGroceryType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbGroceryType.Name = "cmbGroceryType";
            this.cmbGroceryType.Size = new System.Drawing.Size(82, 21);
            this.cmbGroceryType.TabIndex = 5;
            this.cmbGroceryType.Text = "--Select One--";
            // 
            // lblGroceryType
            // 
            this.lblGroceryType.AutoSize = true;
            this.lblGroceryType.Location = new System.Drawing.Point(26, 70);
            this.lblGroceryType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGroceryType.Name = "lblGroceryType";
            this.lblGroceryType.Size = new System.Drawing.Size(31, 13);
            this.lblGroceryType.TabIndex = 4;
            this.lblGroceryType.Text = "Type";
            // 
            // dtExpiration
            // 
            this.dtExpiration.Location = new System.Drawing.Point(115, 44);
            this.dtExpiration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtExpiration.Name = "dtExpiration";
            this.dtExpiration.Size = new System.Drawing.Size(198, 20);
            this.dtExpiration.TabIndex = 3;
            // 
            // lblExpiration
            // 
            this.lblExpiration.AutoSize = true;
            this.lblExpiration.Location = new System.Drawing.Point(26, 47);
            this.lblExpiration.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpiration.Name = "lblExpiration";
            this.lblExpiration.Size = new System.Drawing.Size(79, 13);
            this.lblExpiration.TabIndex = 2;
            this.lblExpiration.Text = "Expiration Date";
            // 
            // dtPackage
            // 
            this.dtPackage.Location = new System.Drawing.Point(115, 23);
            this.dtPackage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtPackage.Name = "dtPackage";
            this.dtPackage.Size = new System.Drawing.Size(198, 20);
            this.dtPackage.TabIndex = 1;
            // 
            // lblPackage
            // 
            this.lblPackage.AutoSize = true;
            this.lblPackage.Location = new System.Drawing.Point(26, 26);
            this.lblPackage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackage.Name = "lblPackage";
            this.lblPackage.Size = new System.Drawing.Size(76, 13);
            this.lblPackage.TabIndex = 0;
            this.lblPackage.Text = "Package Date";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 365);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(85, 22);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(254, 365);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 22);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtResults
            // 
            this.txtResults.Enabled = false;
            this.txtResults.Location = new System.Drawing.Point(57, 401);
            this.txtResults.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(350, 100);
            this.txtResults.TabIndex = 13;
            this.txtResults.Visible = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(139, 312);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(82, 20);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(55, 314);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(241, 148);
            this.lblCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 16;
            this.lblCompany.Text = "Company";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(325, 145);
            this.cmbCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(82, 21);
            this.cmbCompany.TabIndex = 17;
            this.cmbCompany.Text = "--Select One--";
            // 
            // dgItems
            // 
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Location = new System.Drawing.Point(8, 401);
            this.dgItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgItems.Name = "dgItems";
            this.dgItems.RowHeadersWidth = 62;
            this.dgItems.RowTemplate.Height = 28;
            this.dgItems.Size = new System.Drawing.Size(729, 174);
            this.dgItems.TabIndex = 18;
            this.dgItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellClick);
            // 
            // errPrice
            // 
            this.errPrice.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 595);
            this.Controls.Add(this.dgItems);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpGrocery);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpFurniture);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.lblItem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Inventory Item: Add";
            this.grpFurniture.ResumeLayout(false);
            this.grpFurniture.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpGrocery.ResumeLayout(false);
            this.grpGrocery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.GroupBox grpFurniture;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpGrocery;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.DateTimePicker dtExpiration;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.DateTimePicker dtPackage;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.ComboBox cmbBookType;
        private System.Windows.Forms.Label lblBookType;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.ComboBox cmbGroceryType;
        private System.Windows.Forms.Label lblGroceryType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.ErrorProvider errPrice;
    }
}

