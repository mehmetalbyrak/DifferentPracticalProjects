namespace Project1_AdonetCustomer
{
    partial class FrmCustomer
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerBalance = new System.Windows.Forms.TextBox();
            this.lblCustomerBalance = new System.Windows.Forms.Label();
            this.lblCustomerState = new System.Windows.Forms.Label();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.cmbCustomerCity = new System.Windows.Forms.ComboBox();
            this.rdbActive = new System.Windows.Forms.RadioButton();
            this.rdbPassive = new System.Windows.Forms.RadioButton();
            this.btnProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(48, 357);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(201, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(48, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 23);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(48, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(201, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(125, 88);
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(136, 20);
            this.txtCustomerLastName.TabIndex = 20;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(14, 91);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(105, 13);
            this.lblCustomerLastName.TabIndex = 19;
            this.lblCustomerLastName.Text = "Customer LastName:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(125, 52);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(136, 20);
            this.txtCustomerName.TabIndex = 18;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(34, 55);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(48, 218);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(98, 23);
            this.btnList.TabIndex = 16;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(290, 20);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(489, 360);
            this.dataGridViewCustomer.TabIndex = 15;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(125, 20);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(136, 20);
            this.txtCustomerId.TabIndex = 33;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(53, 23);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(66, 13);
            this.lblCustomerId.TabIndex = 13;
            this.lblCustomerId.Text = "Customer Id:";
            // 
            // txtCustomerBalance
            // 
            this.txtCustomerBalance.Location = new System.Drawing.Point(125, 118);
            this.txtCustomerBalance.Name = "txtCustomerBalance";
            this.txtCustomerBalance.Size = new System.Drawing.Size(136, 20);
            this.txtCustomerBalance.TabIndex = 26;
            // 
            // lblCustomerBalance
            // 
            this.lblCustomerBalance.AutoSize = true;
            this.lblCustomerBalance.Location = new System.Drawing.Point(23, 121);
            this.lblCustomerBalance.Name = "lblCustomerBalance";
            this.lblCustomerBalance.Size = new System.Drawing.Size(96, 13);
            this.lblCustomerBalance.TabIndex = 25;
            this.lblCustomerBalance.Text = "Customer Balance:";
            // 
            // lblCustomerState
            // 
            this.lblCustomerState.AutoSize = true;
            this.lblCustomerState.Location = new System.Drawing.Point(37, 152);
            this.lblCustomerState.Name = "lblCustomerState";
            this.lblCustomerState.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerState.TabIndex = 27;
            this.lblCustomerState.Text = "Customer State:";
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Location = new System.Drawing.Point(45, 181);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(74, 13);
            this.lblCustomerCity.TabIndex = 29;
            this.lblCustomerCity.Text = "Customer City:";
            // 
            // cmbCustomerCity
            // 
            this.cmbCustomerCity.FormattingEnabled = true;
            this.cmbCustomerCity.Location = new System.Drawing.Point(126, 181);
            this.cmbCustomerCity.Name = "cmbCustomerCity";
            this.cmbCustomerCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerCity.TabIndex = 30;
            // 
            // rdbActive
            // 
            this.rdbActive.AutoSize = true;
            this.rdbActive.Location = new System.Drawing.Point(126, 152);
            this.rdbActive.Name = "rdbActive";
            this.rdbActive.Size = new System.Drawing.Size(54, 17);
            this.rdbActive.TabIndex = 31;
            this.rdbActive.TabStop = true;
            this.rdbActive.Text = "active";
            this.rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            this.rdbPassive.AutoSize = true;
            this.rdbPassive.Location = new System.Drawing.Point(186, 152);
            this.rdbPassive.Name = "rdbPassive";
            this.rdbPassive.Size = new System.Drawing.Size(61, 17);
            this.rdbPassive.TabIndex = 32;
            this.rdbPassive.TabStop = true;
            this.rdbPassive.Text = "passive";
            this.rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(152, 218);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(98, 23);
            this.btnProcedure.TabIndex = 34;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.rdbPassive);
            this.Controls.Add(this.rdbActive);
            this.Controls.Add(this.cmbCustomerCity);
            this.Controls.Add(this.lblCustomerCity);
            this.Controls.Add(this.lblCustomerState);
            this.Controls.Add(this.txtCustomerBalance);
            this.Controls.Add(this.lblCustomerBalance);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Form";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerBalance;
        private System.Windows.Forms.Label lblCustomerBalance;
        private System.Windows.Forms.Label lblCustomerState;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.ComboBox cmbCustomerCity;
        private System.Windows.Forms.RadioButton rdbActive;
        private System.Windows.Forms.RadioButton rdbPassive;
        private System.Windows.Forms.Button btnProcedure;
    }
}