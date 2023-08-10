using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.b1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            string user, pwd, email;
            user = unametb.Text;
            pwd = passwordtb.Text;
            email = emailtb.Text;

            StreamWriter sw = new StreamWriter("E://Shahanas Saju//DotNet//logindetails.txt", true);
            sw.WriteLine("UserName : " + user);
            sw.WriteLine("Email : " + email);
            sw.WriteLine("Password : " + pwd);
            sw.WriteLine("-------------------");
            sw.Close();

            messagebox.Text = "Successfully registered";
            messagebox.ForeColor = Color.Green;
           
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            this.Hide();

            loginForm.Show();
        }

        private void registerHeading_Click(object sender, EventArgs e)
        {

        }
    }
}
