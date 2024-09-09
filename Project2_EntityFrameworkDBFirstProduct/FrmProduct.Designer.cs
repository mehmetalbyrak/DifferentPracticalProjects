namespace Project2_EntityFrameworkDBFirstProduct
{
    partial class FrmProduct
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductStock = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.btnListWithCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Lime;
            this.btnList.Location = new System.Drawing.Point(113, 170);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(70, 23);
            this.btnList.TabIndex = 19;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Location = new System.Drawing.Point(113, 353);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Lime;
            this.btnUpdate.Location = new System.Drawing.Point(113, 299);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lime;
            this.btnDelete.Location = new System.Drawing.Point(113, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(113, 38);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(144, 20);
            this.txtProductName.TabIndex = 15;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoryName.Location = new System.Drawing.Point(29, 97);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(78, 13);
            this.lblCategoryName.TabIndex = 14;
            this.lblCategoryName.Text = "Product Stock:";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(113, 12);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(144, 20);
            this.txtProductId.TabIndex = 13;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(311, 12);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(546, 364);
            this.dataGridViewProduct.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(113, 211);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoryId.Location = new System.Drawing.Point(33, 67);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(74, 13);
            this.lblCategoryId.TabIndex = 10;
            this.lblCategoryId.Text = "Product Price:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(113, 64);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(144, 20);
            this.txtProductPrice.TabIndex = 20;
            // 
            // txtProductStock
            // 
            this.txtProductStock.Location = new System.Drawing.Point(113, 94);
            this.txtProductStock.Name = "txtProductStock";
            this.txtProductStock.Size = new System.Drawing.Size(144, 20);
            this.txtProductStock.TabIndex = 21;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProductId.Location = new System.Drawing.Point(48, 15);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(59, 13);
            this.lblProductId.TabIndex = 23;
            this.lblProductId.Text = "Product Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Product Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(46, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "CategoryId:";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(113, 126);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(144, 21);
            this.cmbProductCategory.TabIndex = 26;
            // 
            // btnListWithCategory
            // 
            this.btnListWithCategory.BackColor = System.Drawing.Color.Lime;
            this.btnListWithCategory.Location = new System.Drawing.Point(189, 170);
            this.btnListWithCategory.Name = "btnListWithCategory";
            this.btnListWithCategory.Size = new System.Drawing.Size(70, 23);
            this.btnListWithCategory.TabIndex = 27;
            this.btnListWithCategory.Text = "List";
            this.btnListWithCategory.UseVisualStyleBackColor = false;
            this.btnListWithCategory.Click += new System.EventHandler(this.btnListWithCategory_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.btnListWithCategory);
            this.Controls.Add(this.cmbProductCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.txtProductStock);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCategoryId);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductStock;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Button btnListWithCategory;
    }
}