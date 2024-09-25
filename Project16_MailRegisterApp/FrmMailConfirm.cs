using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegisterApp
{
    public partial class FrmMailConfirm : Form
    {
        public FrmMailConfirm()
        {
            InitializeComponent();
        }

        MailActivationDBEntities mailActivationDBEntities = new MailActivationDBEntities();
        public string email;
        private void btnActivation_Click(object sender, EventArgs e)
        {
            txtEmail.Text = email;
            var value = mailActivationDBEntities.Users.Where(x=>x.Email == txtEmail.Text)
                .Select(y=>y.ConfirmCode).FirstOrDefault();

            if(txtSixDigitCode.Text == value.ToString())
            {
                var value2 = mailActivationDBEntities.Users.Where(x=>x.Email == txtEmail.Text)
                    .FirstOrDefault();
                value2.IsConfirm = true;
                mailActivationDBEntities.SaveChanges();
                MessageBox.Show("Account is activated");

                

            }
            else
            {
                MessageBox.Show("Invalid code :d");
            }
        }
    }
}
