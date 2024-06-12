namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            name_Label = new Label();
            txtProductName = new TextBox();
            btnSearchCountries = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnTopProducts = new Button();
            lstTopProducts = new ListBox();
            dtpSinceDate = new DateTimePicker();
            btnUnsoldProducts = new Button();
            lstUnsoldProducts = new ListBox();
            btnCreateNewFile = new Button();
            txtName = new TextBox();
            txtManufacturer = new TextBox();
            txtImportingCountry = new TextBox();
            txtVolume = new TextBox();
            dtpDeliveryDate = new DateTimePicker();
            btnAddProduct = new Button();
            lstProducts = new ListBox();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            txtSearchProductName = new TextBox();
            btnBinarySearch = new Button();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblSinceDate = new Label();
            lblName = new Label();
            label1 = new Label();
            v = new Label();
            lblVolume = new Label();
            lblDeliveryDate = new Label();
            label2 = new Label();
            lblNumberOfSales = new Label();
            txtNumberOfSales = new TextBox();
            SuspendLayout();
            // 
            // name_Label
            // 
            name_Label.AutoSize = true;
            name_Label.Location = new Point(12, 379);
            name_Label.Name = "name_Label";
            name_Label.Size = new Size(39, 15);
            name_Label.TabIndex = 6;
            name_Label.Text = "Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 397);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);
            txtProductName.TabIndex = 15;
            // 
            // btnSearchCountries
            // 
            btnSearchCountries.Location = new Point(12, 426);
            btnSearchCountries.Name = "btnSearchCountries";
            btnSearchCountries.Size = new Size(200, 23);
            btnSearchCountries.TabIndex = 16;
            btnSearchCountries.Text = "Search Countries";
            btnSearchCountries.UseVisualStyleBackColor = true;
            btnSearchCountries.Click += btnSearchCountries_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(742, 259);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 17;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(948, 259);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 18;
            // 
            // btnTopProducts
            // 
            btnTopProducts.Location = new Point(742, 288);
            btnTopProducts.Name = "btnTopProducts";
            btnTopProducts.Size = new Size(406, 23);
            btnTopProducts.TabIndex = 19;
            btnTopProducts.Text = "Top Products";
            btnTopProducts.UseVisualStyleBackColor = true;
            btnTopProducts.Click += btnTopProducts_Click;
            // 
            // lstTopProducts
            // 
            lstTopProducts.FormattingEnabled = true;
            lstTopProducts.ItemHeight = 15;
            lstTopProducts.Location = new Point(742, 9);
            lstTopProducts.Name = "lstTopProducts";
            lstTopProducts.Size = new Size(406, 229);
            lstTopProducts.TabIndex = 20;
            // 
            // dtpSinceDate
            // 
            dtpSinceDate.Location = new Point(742, 567);
            dtpSinceDate.Name = "dtpSinceDate";
            dtpSinceDate.Size = new Size(406, 23);
            dtpSinceDate.TabIndex = 21;
            // 
            // btnUnsoldProducts
            // 
            btnUnsoldProducts.Location = new Point(742, 596);
            btnUnsoldProducts.Name = "btnUnsoldProducts";
            btnUnsoldProducts.Size = new Size(406, 23);
            btnUnsoldProducts.TabIndex = 22;
            btnUnsoldProducts.Text = "Unsold Products";
            btnUnsoldProducts.UseVisualStyleBackColor = true;
            btnUnsoldProducts.Click += btnUnsoldProducts_Click;
            // 
            // lstUnsoldProducts
            // 
            lstUnsoldProducts.FormattingEnabled = true;
            lstUnsoldProducts.ItemHeight = 15;
            lstUnsoldProducts.Location = new Point(742, 317);
            lstUnsoldProducts.Name = "lstUnsoldProducts";
            lstUnsoldProducts.Size = new Size(406, 229);
            lstUnsoldProducts.TabIndex = 23;
            // 
            // btnCreateNewFile
            // 
            btnCreateNewFile.Location = new Point(12, 590);
            btnCreateNewFile.Name = "btnCreateNewFile";
            btnCreateNewFile.Size = new Size(200, 23);
            btnCreateNewFile.TabIndex = 24;
            btnCreateNewFile.Text = "Create new file";
            btnCreateNewFile.UseVisualStyleBackColor = true;
            btnCreateNewFile.Click += btnCreateNewFile_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 25;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(12, 71);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(200, 23);
            txtManufacturer.TabIndex = 26;
            // 
            // txtImportingCountry
            // 
            txtImportingCountry.Location = new Point(12, 115);
            txtImportingCountry.Name = "txtImportingCountry";
            txtImportingCountry.Size = new Size(200, 23);
            txtImportingCountry.TabIndex = 27;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(12, 159);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(200, 23);
            txtVolume.TabIndex = 28;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new Point(12, 247);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(200, 23);
            dtpDeliveryDate.TabIndex = 29;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(12, 276);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(200, 23);
            btnAddProduct.TabIndex = 30;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(218, 9);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(518, 604);
            lstProducts.TabIndex = 32;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(12, 305);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(97, 23);
            btnEditProduct.TabIndex = 33;
            btnEditProduct.Text = "Edit Product";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(115, 305);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(97, 23);
            btnDeleteProduct.TabIndex = 34;
            btnDeleteProduct.Text = "Delete Product";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // txtSearchProductName
            // 
            txtSearchProductName.Location = new Point(12, 470);
            txtSearchProductName.Name = "txtSearchProductName";
            txtSearchProductName.Size = new Size(200, 23);
            txtSearchProductName.TabIndex = 35;
            // 
            // btnBinarySearch
            // 
            btnBinarySearch.Location = new Point(12, 499);
            btnBinarySearch.Name = "btnBinarySearch";
            btnBinarySearch.Size = new Size(200, 23);
            btnBinarySearch.TabIndex = 36;
            btnBinarySearch.Text = "Binary Search";
            btnBinarySearch.UseVisualStyleBackColor = true;
            btnBinarySearch.Click += btnBinarySearch_Click;
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(742, 241);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(58, 15);
            lblStartDate.TabIndex = 37;
            lblStartDate.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(948, 241);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(54, 15);
            lblEndDate.TabIndex = 38;
            lblEndDate.Text = "End Date";
            // 
            // lblSinceDate
            // 
            lblSinceDate.AutoSize = true;
            lblSinceDate.Location = new Point(742, 549);
            lblSinceDate.Name = "lblSinceDate";
            lblSinceDate.Size = new Size(62, 15);
            lblSinceDate.TabIndex = 39;
            lblSinceDate.Text = "Since Date";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 40;
            lblName.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 41;
            label1.Text = "Manufacturer";
            // 
            // v
            // 
            v.AutoSize = true;
            v.Location = new Point(12, 97);
            v.Name = "v";
            v.Size = new Size(106, 15);
            v.TabIndex = 42;
            v.Text = "Importing Country";
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Location = new Point(12, 141);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(47, 15);
            lblVolume.TabIndex = 43;
            lblVolume.Text = "Volume";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Location = new Point(12, 229);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(76, 15);
            lblDeliveryDate.TabIndex = 44;
            lblDeliveryDate.Text = "Delivery Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 452);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 45;
            label2.Text = "Name";
            // 
            // lblNumberOfSales
            // 
            lblNumberOfSales.AutoSize = true;
            lblNumberOfSales.Location = new Point(12, 185);
            lblNumberOfSales.Name = "lblNumberOfSales";
            lblNumberOfSales.Size = new Size(96, 15);
            lblNumberOfSales.TabIndex = 47;
            lblNumberOfSales.Text = "Number Of Sales";
            // 
            // txtNumberOfSales
            // 
            txtNumberOfSales.Location = new Point(12, 203);
            txtNumberOfSales.Name = "txtNumberOfSales";
            txtNumberOfSales.Size = new Size(200, 23);
            txtNumberOfSales.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 628);
            Controls.Add(lblNumberOfSales);
            Controls.Add(txtNumberOfSales);
            Controls.Add(label2);
            Controls.Add(lblDeliveryDate);
            Controls.Add(lblVolume);
            Controls.Add(v);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(lblSinceDate);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(btnBinarySearch);
            Controls.Add(txtSearchProductName);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(lstProducts);
            Controls.Add(btnAddProduct);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(txtVolume);
            Controls.Add(txtImportingCountry);
            Controls.Add(txtManufacturer);
            Controls.Add(txtName);
            Controls.Add(btnCreateNewFile);
            Controls.Add(lstUnsoldProducts);
            Controls.Add(btnUnsoldProducts);
            Controls.Add(dtpSinceDate);
            Controls.Add(lstTopProducts);
            Controls.Add(btnTopProducts);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnSearchCountries);
            Controls.Add(txtProductName);
            Controls.Add(name_Label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label name_Label;
        private Label showResultsForLast_Label;
        private NumericUpDown numericUpDown1;
        private Label days_Label;
        private Label lblStartDate;
        private ComboBox comboBox1;
        private TextBox txtProductName;
        private Button btnSearchCountries;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnTopProducts;
        private ListBox lstTopProducts;
        private DateTimePicker dtpSinceDate;
        private Button btnUnsoldProducts;
        private ListBox lstUnsoldProducts;
        private Button btnCreateNewFile;
        private TextBox txtName;
        private TextBox txtManufacturer;
        private TextBox txtImportingCountry;
        private TextBox txtVolume;
        private DateTimePicker dtpDeliveryDate;
        private Button btnAddProduct;
        private ListBox lstProducts;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
        private TextBox txtSearchProductName;
        private Button btnBinarySearch;
        private Label lblEndDate;
        private Label lblSinceDate;
        private Label lblName;
        private Label label1;
        private Label v;
        private Label lblVolume;
        private Label lblDeliveryDate;
        private Label label2;
        private Label lblNumberOfSales;
        private TextBox txtNumberOfSales;
    }
}
