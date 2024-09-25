using MailKit.Net.Smtp;
using MimeKit;
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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        MailActivationDBEntities mailActivationDBEntities = new MailActivationDBEntities();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int confirmCode = random.Next(100000, 999999);

            User user = new User();
            user.Name = txtName.Text;
            user.LastName = txtLastName.Text;
            user.Password = txtPassword.Text;
            user.Email = txtEmail.Text;
            user.IsConfirm = false;
            user.ConfirmCode = confirmCode.ToString();

            mailActivationDBEntities.Users.Add(user);
            mailActivationDBEntities.SaveChanges();

            #region MailCodes

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("AdminRegister", "albayrakmehmetdeu@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Confirm Code of Email Address: " + confirmCode;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = "Email Confirmation Code";

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("albayrakmehmetdeu@gmail.com", "nuocuenszitvstft");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            MessageBox.Show("Activation Code is send");

            FrmMailConfirm frmMailConfirm = new FrmMailConfirm();
            frmMailConfirm.email = txtEmail.Text;
            frmMailConfirm.Show();




            #endregion



        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
