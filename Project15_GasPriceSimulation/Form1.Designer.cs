namespace Project15_GasPriceSimulation
{
    partial class FrmGasPriceSimulation
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFuelAmount = new System.Windows.Forms.Label();
            this.txtFuelAmount = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblInstantFuelPercentage = new System.Windows.Forms.Label();
            this.progressBarInstantFuelPercentage = new System.Windows.Forms.ProgressBar();
            this.btnBeginProcess = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGasoline = new System.Windows.Forms.TextBox();
            this.lblGasoline = new System.Windows.Forms.Label();
            this.txtDieselFuel = new System.Windows.Forms.TextBox();
            this.lblDieselFuel = new System.Windows.Forms.Label();
            this.txtLPG = new System.Windows.Forms.TextBox();
            this.lblLPG = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdbGasoline = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbDieselFuel = new System.Windows.Forms.RadioButton();
            this.rdbLPG = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gas Price Simulation";
            // 
            // lblFuelAmount
            // 
            this.lblFuelAmount.AutoSize = true;
            this.lblFuelAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFuelAmount.Location = new System.Drawing.Point(106, 91);
            this.lblFuelAmount.Name = "lblFuelAmount";
            this.lblFuelAmount.Size = new System.Drawing.Size(92, 17);
            this.lblFuelAmount.TabIndex = 1;
            this.lblFuelAmount.Text = "Fuel Amount:";
            // 
            // txtFuelAmount
            // 
            this.txtFuelAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFuelAmount.Location = new System.Drawing.Point(200, 91);
            this.txtFuelAmount.Name = "txtFuelAmount";
            this.txtFuelAmount.Size = new System.Drawing.Size(100, 22);
            this.txtFuelAmount.TabIndex = 2;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalAmount.Location = new System.Drawing.Point(200, 119);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 4;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalAmount.Location = new System.Drawing.Point(101, 119);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(97, 17);
            this.lblTotalAmount.TabIndex = 3;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblInstantFuelPercentage
            // 
            this.lblInstantFuelPercentage.AutoSize = true;
            this.lblInstantFuelPercentage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInstantFuelPercentage.Location = new System.Drawing.Point(41, 147);
            this.lblInstantFuelPercentage.Name = "lblInstantFuelPercentage";
            this.lblInstantFuelPercentage.Size = new System.Drawing.Size(157, 17);
            this.lblInstantFuelPercentage.TabIndex = 5;
            this.lblInstantFuelPercentage.Text = "Instant Fuel Percentage:";
            // 
            // progressBarInstantFuelPercentage
            // 
            this.progressBarInstantFuelPercentage.Location = new System.Drawing.Point(200, 147);
            this.progressBarInstantFuelPercentage.Name = "progressBarInstantFuelPercentage";
            this.progressBarInstantFuelPercentage.Size = new System.Drawing.Size(100, 23);
            this.progressBarInstantFuelPercentage.TabIndex = 9;
            // 
            // btnBeginProcess
            // 
            this.btnBeginProcess.Location = new System.Drawing.Point(140, 191);
            this.btnBeginProcess.Name = "btnBeginProcess";
            this.btnBeginProcess.Size = new System.Drawing.Size(160, 23);
            this.btnBeginProcess.TabIndex = 10;
            this.btnBeginProcess.Text = "Begin Process";
            this.btnBeginProcess.UseVisualStyleBackColor = true;
            this.btnBeginProcess.Click += new System.EventHandler(this.btnBeginProcess_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLPG);
            this.groupBox1.Controls.Add(this.lblLPG);
            this.groupBox1.Controls.Add(this.txtDieselFuel);
            this.groupBox1.Controls.Add(this.lblDieselFuel);
            this.groupBox1.Controls.Add(this.txtGasoline);
            this.groupBox1.Controls.Add(this.lblGasoline);
            this.groupBox1.Location = new System.Drawing.Point(469, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 132);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fuel Prices";
            // 
            // txtGasoline
            // 
            this.txtGasoline.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGasoline.Location = new System.Drawing.Point(108, 37);
            this.txtGasoline.Name = "txtGasoline";
            this.txtGasoline.ReadOnly = true;
            this.txtGasoline.Size = new System.Drawing.Size(100, 22);
            this.txtGasoline.TabIndex = 16;
            // 
            // lblGasoline
            // 
            this.lblGasoline.AutoSize = true;
            this.lblGasoline.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGasoline.Location = new System.Drawing.Point(37, 42);
            this.lblGasoline.Name = "lblGasoline";
            this.lblGasoline.Size = new System.Drawing.Size(65, 17);
            this.lblGasoline.TabIndex = 15;
            this.lblGasoline.Text = "Gasoline:";
            // 
            // txtDieselFuel
            // 
            this.txtDieselFuel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDieselFuel.Location = new System.Drawing.Point(108, 65);
            this.txtDieselFuel.Name = "txtDieselFuel";
            this.txtDieselFuel.ReadOnly = true;
            this.txtDieselFuel.Size = new System.Drawing.Size(100, 22);
            this.txtDieselFuel.TabIndex = 18;
            // 
            // lblDieselFuel
            // 
            this.lblDieselFuel.AutoSize = true;
            this.lblDieselFuel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDieselFuel.Location = new System.Drawing.Point(22, 70);
            this.lblDieselFuel.Name = "lblDieselFuel";
            this.lblDieselFuel.Size = new System.Drawing.Size(80, 17);
            this.lblDieselFuel.TabIndex = 17;
            this.lblDieselFuel.Text = "Diesel Fuel:";
            // 
            // txtLPG
            // 
            this.txtLPG.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLPG.Location = new System.Drawing.Point(108, 94);
            this.txtLPG.Name = "txtLPG";
            this.txtLPG.ReadOnly = true;
            this.txtLPG.Size = new System.Drawing.Size(100, 22);
            this.txtLPG.TabIndex = 20;
            // 
            // lblLPG
            // 
            this.lblLPG.AutoSize = true;
            this.lblLPG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLPG.Location = new System.Drawing.Point(66, 99);
            this.lblLPG.Name = "lblLPG";
            this.lblLPG.Size = new System.Drawing.Size(36, 17);
            this.lblLPG.TabIndex = 19;
            this.lblLPG.Text = "LPG:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(140, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdbGasoline
            // 
            this.rdbGasoline.AutoSize = true;
            this.rdbGasoline.Location = new System.Drawing.Point(17, 42);
            this.rdbGasoline.Name = "rdbGasoline";
            this.rdbGasoline.Size = new System.Drawing.Size(66, 17);
            this.rdbGasoline.TabIndex = 17;
            this.rdbGasoline.TabStop = true;
            this.rdbGasoline.Text = "Gasoline";
            this.rdbGasoline.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbLPG);
            this.groupBox2.Controls.Add(this.rdbDieselFuel);
            this.groupBox2.Controls.Add(this.rdbGasoline);
            this.groupBox2.Location = new System.Drawing.Point(331, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 132);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fuel Types";
            // 
            // rdbDieselFuel
            // 
            this.rdbDieselFuel.AutoSize = true;
            this.rdbDieselFuel.Location = new System.Drawing.Point(17, 65);
            this.rdbDieselFuel.Name = "rdbDieselFuel";
            this.rdbDieselFuel.Size = new System.Drawing.Size(77, 17);
            this.rdbDieselFuel.TabIndex = 18;
            this.rdbDieselFuel.TabStop = true;
            this.rdbDieselFuel.Text = "Diesel Fuel";
            this.rdbDieselFuel.UseVisualStyleBackColor = true;
            // 
            // rdbLPG
            // 
            this.rdbLPG.AutoSize = true;
            this.rdbLPG.Location = new System.Drawing.Point(17, 91);
            this.rdbLPG.Name = "rdbLPG";
            this.rdbLPG.Size = new System.Drawing.Size(46, 17);
            this.rdbLPG.TabIndex = 19;
            this.rdbLPG.TabStop = true;
            this.rdbLPG.Text = "LPG";
            this.rdbLPG.UseVisualStyleBackColor = true;
            // 
            // FrmGasPriceSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBeginProcess);
            this.Controls.Add(this.progressBarInstantFuelPercentage);
            this.Controls.Add(this.lblInstantFuelPercentage);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtFuelAmount);
            this.Controls.Add(this.lblFuelAmount);
            this.Controls.Add(this.label1);
            this.Name = "FrmGasPriceSimulation";
            this.Text = "Gas Price Simulation";
            this.Load += new System.EventHandler(this.FrmGasPriceSimulation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFuelAmount;
        private System.Windows.Forms.TextBox txtFuelAmount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblInstantFuelPercentage;
        private System.Windows.Forms.ProgressBar progressBarInstantFuelPercentage;
        private System.Windows.Forms.Button btnBeginProcess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLPG;
        private System.Windows.Forms.Label lblLPG;
        private System.Windows.Forms.TextBox txtDieselFuel;
        private System.Windows.Forms.Label lblDieselFuel;
        private System.Windows.Forms.TextBox txtGasoline;
        private System.Windows.Forms.Label lblGasoline;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdbGasoline;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbLPG;
        private System.Windows.Forms.RadioButton rdbDieselFuel;
    }
}

