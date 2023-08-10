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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.b1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            string filePath = "E://Shahanas Saju//DotNet//logindetails.txt"; // Path to the text file

            string providedUsername = usernametb.Text;
            string providedPassword = passwordtb.Text;

            string username = "";
            string password = "";
            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Process each line of the file

                        if (line.StartsWith("UserName : "))
                        {
                             username = line.Substring("UserName : ".Length).Trim();
                            
                       }
                        else if (line.StartsWith("Password :"))
                        {
                             password = line.Substring("Password : ".Length).Trim();

                            if (username == providedUsername && password == providedPassword)
                            {

                                Welcome welcome = new Welcome();
                                this.Hide();
                                welcome.Show();

                               
                            }
                            else
                            {
                                messagebox.Text = "login not found . please register";
                                messagebox.Show();
                              
                                messagebox.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }






           
        
        }

        private void registerlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
           
            this.Hide();

            register.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void alert_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
