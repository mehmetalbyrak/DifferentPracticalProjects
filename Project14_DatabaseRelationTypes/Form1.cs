using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project14_DatabaseRelationTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'relationsDBDataSet4.TeamSponsors' table. You can move, or remove it, as needed.
            this.teamSponsorsTableAdapter.Fill(this.relationsDBDataSet4.TeamSponsors);
            // TODO: This line of code loads data into the 'relationsDBDataSet3.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter1.Fill(this.relationsDBDataSet3.Players);
            // TODO: This line of code loads data into the 'relationsDBDataSet2.TeamDetails' table. You can move, or remove it, as needed.
            this.teamDetailsTableAdapter.Fill(this.relationsDBDataSet2.TeamDetails);
            // TODO: This line of code loads data into the 'relationsDBDataSet1.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.relationsDBDataSet1.Players);
            // TODO: This line of code loads data into the 'relationsDBDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.relationsDBDataSet.Teams);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
