namespace Project8_RapidAPIExchangeMate
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
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPound = new System.Windows.Forms.Label();
            this.txtUnitAmount = new System.Windows.Forms.TextBox();
            this.lblUnitAmount = new System.Windows.Forms.Label();
            this.rdbDollar = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbPound = new System.Windows.Forms.RadioButton();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtAmountToBePaid = new System.Windows.Forms.TextBox();
            this.lblAmountToBePaid = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Location = new System.Drawing.Point(49, 40);
            this.lblDollar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(112, 24);
            this.lblDollar.TabIndex = 0;
            this.lblDollar.Text = "Dollar Value";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(189, 40);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(105, 24);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "Euro Value";
            // 
            // lblPound
            // 
            this.lblPound.AutoSize = true;
            this.lblPound.Location = new System.Drawing.Point(327, 40);
            this.lblPound.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPound.Name = "lblPound";
            this.lblPound.Size = new System.Drawing.Size(120, 24);
            this.lblPound.TabIndex = 4;
            this.lblPound.Text = "Pound Value";
            // 
            // txtUnitAmount
            // 
            this.txtUnitAmount.Location = new System.Drawing.Point(189, 217);
            this.txtUnitAmount.Name = "txtUnitAmount";
            this.txtUnitAmount.Size = new System.Drawing.Size(227, 29);
            this.txtUnitAmount.TabIndex = 5;
            // 
            // lblUnitAmount
            // 
            this.lblUnitAmount.AutoSize = true;
            this.lblUnitAmount.Location = new System.Drawing.Point(62, 220);
            this.lblUnitAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUnitAmount.Name = "lblUnitAmount";
            this.lblUnitAmount.Size = new System.Drawing.Size(118, 24);
            this.lblUnitAmount.TabIndex = 7;
            this.lblUnitAmount.Text = "Unit Amount:";
            // 
            // rdbDollar
            // 
            this.rdbDollar.AutoSize = true;
            this.rdbDollar.Location = new System.Drawing.Point(84, 92);
            this.rdbDollar.Name = "rdbDollar";
            this.rdbDollar.Size = new System.Drawing.Size(76, 28);
            this.rdbDollar.TabIndex = 8;
            this.rdbDollar.TabStop = true;
            this.rdbDollar.Text = "Dollar";
            this.rdbDollar.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(180, 92);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(69, 28);
            this.rdbEuro.TabIndex = 9;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbPound
            // 
            this.rdbPound.AutoSize = true;
            this.rdbPound.Location = new System.Drawing.Point(285, 92);
            this.rdbPound.Name = "rdbPound";
            this.rdbPound.Size = new System.Drawing.Size(84, 28);
            this.rdbPound.TabIndex = 10;
            this.rdbPound.TabStop = true;
            this.rdbPound.Text = "Pound";
            this.rdbPound.UseVisualStyleBackColor = true;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(180, 298);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(249, 38);
            this.btnProcess.TabIndex = 11;
            this.btnProcess.Text = "process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // txtAmountToBePaid
            // 
            this.txtAmountToBePaid.Location = new System.Drawing.Point(189, 252);
            this.txtAmountToBePaid.Name = "txtAmountToBePaid";
            this.txtAmountToBePaid.Size = new System.Drawing.Size(227, 29);
            this.txtAmountToBePaid.TabIndex = 12;
            // 
            // lblAmountToBePaid
            // 
            this.lblAmountToBePaid.AutoSize = true;
            this.lblAmountToBePaid.Location = new System.Drawing.Point(15, 257);
            this.lblAmountToBePaid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmountToBePaid.Name = "lblAmountToBePaid";
            this.lblAmountToBePaid.Size = new System.Drawing.Size(170, 24);
            this.lblAmountToBePaid.TabIndex = 13;
            this.lblAmountToBePaid.Text = "Amount to be Paid:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(470, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 38);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAmountToBePaid);
            this.Controls.Add(this.txtAmountToBePaid);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.rdbPound);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.rdbDollar);
            this.Controls.Add(this.lblUnitAmount);
            this.Controls.Add(this.txtUnitAmount);
            this.Controls.Add(this.lblPound);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDollar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPound;
        private System.Windows.Forms.TextBox txtUnitAmount;
        private System.Windows.Forms.Label lblUnitAmount;
        private System.Windows.Forms.RadioButton rdbDollar;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbPound;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtAmountToBePaid;
        private System.Windows.Forms.Label lblAmountToBePaid;
        private System.Windows.Forms.Button btnExit;
    }
}

