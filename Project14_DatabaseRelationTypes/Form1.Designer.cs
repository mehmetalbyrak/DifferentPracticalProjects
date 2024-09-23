namespace Project14_DatabaseRelationTypes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.relationsDBDataSet = new Project14_DatabaseRelationTypes.RelationsDBDataSet();
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter = new Project14_DatabaseRelationTypes.RelationsDBDataSetTableAdapters.TeamsTableAdapter();
            this.teamIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.relationsDBDataSet1 = new Project14_DatabaseRelationTypes.RelationsDBDataSet1();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new Project14_DatabaseRelationTypes.RelationsDBDataSet1TableAdapters.PlayersTableAdapter();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.relationsDBDataSet2 = new Project14_DatabaseRelationTypes.RelationsDBDataSet2();
            this.teamDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamDetailsTableAdapter = new Project14_DatabaseRelationTypes.RelationsDBDataSet2TableAdapters.TeamDetailsTableAdapter();
            this.teamDetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationsDBDataSet3 = new Project14_DatabaseRelationTypes.RelationsDBDataSet3();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter1 = new Project14_DatabaseRelationTypes.RelationsDBDataSet3TableAdapters.PlayersTableAdapter();
            this.playerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIdDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationsDBDataSet4 = new Project14_DatabaseRelationTypes.RelationsDBDataSet4();
            this.teamSponsorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamSponsorsTableAdapter = new Project14_DatabaseRelationTypes.RelationsDBDataSet4TableAdapters.TeamSponsorsTableAdapter();
            this.teamIdDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sponsorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn,
            this.teamNameDataGridViewTextBoxColumn,
            this.teamCountryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teamsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(271, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // relationsDBDataSet
            // 
            this.relationsDBDataSet.DataSetName = "RelationsDBDataSet";
            this.relationsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.relationsDBDataSet;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // teamIdDataGridViewTextBoxColumn
            // 
            this.teamIdDataGridViewTextBoxColumn.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn.Name = "teamIdDataGridViewTextBoxColumn";
            this.teamIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamNameDataGridViewTextBoxColumn
            // 
            this.teamNameDataGridViewTextBoxColumn.DataPropertyName = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.HeaderText = "TeamName";
            this.teamNameDataGridViewTextBoxColumn.Name = "teamNameDataGridViewTextBoxColumn";
            // 
            // teamCountryDataGridViewTextBoxColumn
            // 
            this.teamCountryDataGridViewTextBoxColumn.DataPropertyName = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.HeaderText = "TeamCountry";
            this.teamCountryDataGridViewTextBoxColumn.Name = "teamCountryDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.playersBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(0, 206);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(271, 210);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamDetailIdDataGridViewTextBoxColumn,
            this.teamIdDataGridViewTextBoxColumn2,
            this.teamColorDataGridViewTextBoxColumn,
            this.teamCityDataGridViewTextBoxColumn,
            this.teamValueDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.teamDetailsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(277, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(511, 147);
            this.dataGridView3.TabIndex = 2;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerIdDataGridViewTextBoxColumn1,
            this.playerNameDataGridViewTextBoxColumn1,
            this.teamIdDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.playersBindingSource1;
            this.dataGridView4.Location = new System.Drawing.Point(277, 165);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(511, 116);
            this.dataGridView4.TabIndex = 3;
            // 
            // relationsDBDataSet1
            // 
            this.relationsDBDataSet1.DataSetName = "RelationsDBDataSet1";
            this.relationsDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.relationsDBDataSet1;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            this.playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // teamIdDataGridViewTextBoxColumn1
            // 
            this.teamIdDataGridViewTextBoxColumn1.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn1.Name = "teamIdDataGridViewTextBoxColumn1";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.teamIdDataGridViewTextBoxColumn4,
            this.sponsorIdDataGridViewTextBoxColumn});
            this.dataGridView5.DataSource = this.teamSponsorsBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(277, 288);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(511, 128);
            this.dataGridView5.TabIndex = 4;
            // 
            // relationsDBDataSet2
            // 
            this.relationsDBDataSet2.DataSetName = "RelationsDBDataSet2";
            this.relationsDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamDetailsBindingSource
            // 
            this.teamDetailsBindingSource.DataMember = "TeamDetails";
            this.teamDetailsBindingSource.DataSource = this.relationsDBDataSet2;
            // 
            // teamDetailsTableAdapter
            // 
            this.teamDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // teamDetailIdDataGridViewTextBoxColumn
            // 
            this.teamDetailIdDataGridViewTextBoxColumn.DataPropertyName = "TeamDetailId";
            this.teamDetailIdDataGridViewTextBoxColumn.HeaderText = "TeamDetailId";
            this.teamDetailIdDataGridViewTextBoxColumn.Name = "teamDetailIdDataGridViewTextBoxColumn";
            this.teamDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teamIdDataGridViewTextBoxColumn2
            // 
            this.teamIdDataGridViewTextBoxColumn2.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn2.Name = "teamIdDataGridViewTextBoxColumn2";
            // 
            // teamColorDataGridViewTextBoxColumn
            // 
            this.teamColorDataGridViewTextBoxColumn.DataPropertyName = "TeamColor";
            this.teamColorDataGridViewTextBoxColumn.HeaderText = "TeamColor";
            this.teamColorDataGridViewTextBoxColumn.Name = "teamColorDataGridViewTextBoxColumn";
            // 
            // teamCityDataGridViewTextBoxColumn
            // 
            this.teamCityDataGridViewTextBoxColumn.DataPropertyName = "TeamCity";
            this.teamCityDataGridViewTextBoxColumn.HeaderText = "TeamCity";
            this.teamCityDataGridViewTextBoxColumn.Name = "teamCityDataGridViewTextBoxColumn";
            // 
            // teamValueDataGridViewTextBoxColumn
            // 
            this.teamValueDataGridViewTextBoxColumn.DataPropertyName = "TeamValue";
            this.teamValueDataGridViewTextBoxColumn.HeaderText = "TeamValue";
            this.teamValueDataGridViewTextBoxColumn.Name = "teamValueDataGridViewTextBoxColumn";
            // 
            // relationsDBDataSet3
            // 
            this.relationsDBDataSet3.DataSetName = "RelationsDBDataSet3";
            this.relationsDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "Players";
            this.playersBindingSource1.DataSource = this.relationsDBDataSet3;
            // 
            // playersTableAdapter1
            // 
            this.playersTableAdapter1.ClearBeforeFill = true;
            // 
            // playerIdDataGridViewTextBoxColumn1
            // 
            this.playerIdDataGridViewTextBoxColumn1.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn1.HeaderText = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn1.Name = "playerIdDataGridViewTextBoxColumn1";
            this.playerIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // playerNameDataGridViewTextBoxColumn1
            // 
            this.playerNameDataGridViewTextBoxColumn1.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn1.HeaderText = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn1.Name = "playerNameDataGridViewTextBoxColumn1";
            // 
            // teamIdDataGridViewTextBoxColumn3
            // 
            this.teamIdDataGridViewTextBoxColumn3.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn3.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn3.Name = "teamIdDataGridViewTextBoxColumn3";
            // 
            // relationsDBDataSet4
            // 
            this.relationsDBDataSet4.DataSetName = "RelationsDBDataSet4";
            this.relationsDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamSponsorsBindingSource
            // 
            this.teamSponsorsBindingSource.DataMember = "TeamSponsors";
            this.teamSponsorsBindingSource.DataSource = this.relationsDBDataSet4;
            // 
            // teamSponsorsTableAdapter
            // 
            this.teamSponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // teamIdDataGridViewTextBoxColumn4
            // 
            this.teamIdDataGridViewTextBoxColumn4.DataPropertyName = "TeamId";
            this.teamIdDataGridViewTextBoxColumn4.HeaderText = "TeamId";
            this.teamIdDataGridViewTextBoxColumn4.Name = "teamIdDataGridViewTextBoxColumn4";
            // 
            // sponsorIdDataGridViewTextBoxColumn
            // 
            this.sponsorIdDataGridViewTextBoxColumn.DataPropertyName = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.HeaderText = "SponsorId";
            this.sponsorIdDataGridViewTextBoxColumn.Name = "sponsorIdDataGridViewTextBoxColumn";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 422);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Tables With Datas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSponsorsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RelationsDBDataSet relationsDBDataSet;
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private RelationsDBDataSetTableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private RelationsDBDataSet1 relationsDBDataSet1;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private RelationsDBDataSet1TableAdapters.PlayersTableAdapter playersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private RelationsDBDataSet2 relationsDBDataSet2;
        private System.Windows.Forms.BindingSource teamDetailsBindingSource;
        private RelationsDBDataSet2TableAdapters.TeamDetailsTableAdapter teamDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamDetailIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamValueDataGridViewTextBoxColumn;
        private RelationsDBDataSet3 relationsDBDataSet3;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private RelationsDBDataSet3TableAdapters.PlayersTableAdapter playersTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn3;
        private RelationsDBDataSet4 relationsDBDataSet4;
        private System.Windows.Forms.BindingSource teamSponsorsBindingSource;
        private RelationsDBDataSet4TableAdapters.TeamSponsorsTableAdapter teamSponsorsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamIdDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sponsorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExit;
    }
}

