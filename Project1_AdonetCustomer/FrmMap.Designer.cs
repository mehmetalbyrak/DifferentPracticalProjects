namespace Project1_AdonetCustomer
{
    partial class FrmMap
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
            this.btnCityOperations = new System.Windows.Forms.Button();
            this.btnCustomerOperations = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCityOperations
            // 
            this.btnCityOperations.Location = new System.Drawing.Point(97, 59);
            this.btnCityOperations.Name = "btnCityOperations";
            this.btnCityOperations.Size = new System.Drawing.Size(187, 75);
            this.btnCityOperations.TabIndex = 0;
            this.btnCityOperations.Text = "City Operations";
            this.btnCityOperations.UseVisualStyleBackColor = true;
            this.btnCityOperations.Click += new System.EventHandler(this.btnCityOperations_Click);
            // 
            // btnCustomerOperations
            // 
            this.btnCustomerOperations.Location = new System.Drawing.Point(97, 189);
            this.btnCustomerOperations.Name = "btnCustomerOperations";
            this.btnCustomerOperations.Size = new System.Drawing.Size(187, 75);
            this.btnCustomerOperations.TabIndex = 1;
            this.btnCustomerOperations.Text = "Customer Operations";
            this.btnCustomerOperations.UseVisualStyleBackColor = true;
            this.btnCustomerOperations.Click += new System.EventHandler(this.btnCustomerOperations_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(97, 308);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 75);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit Button";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 421);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerOperations);
            this.Controls.Add(this.btnCityOperations);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCityOperations;
        private System.Windows.Forms.Button btnCustomerOperations;
        private System.Windows.Forms.Button btnExit;
    }
}