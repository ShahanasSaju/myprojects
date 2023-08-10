namespace login_form
{
    partial class Register
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
            this.registerHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.messagebox = new System.Windows.Forms.Label();
            this.SignUpbutton = new System.Windows.Forms.Button();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.unametb = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.unamelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerHeading
            // 
            this.registerHeading.AutoSize = true;
            this.registerHeading.BackColor = System.Drawing.Color.Transparent;
            this.registerHeading.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHeading.Location = new System.Drawing.Point(379, 51);
            this.registerHeading.Name = "registerHeading";
            this.registerHeading.Size = new System.Drawing.Size(115, 35);
            this.registerHeading.TabIndex = 0;
            this.registerHeading.Text = "Register";
            this.registerHeading.Click += new System.EventHandler(this.registerHeading_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.link);
            this.panel1.Controls.Add(this.messagebox);
            this.panel1.Controls.Add(this.SignUpbutton);
            this.panel1.Controls.Add(this.passwordtb);
            this.panel1.Controls.Add(this.emailtb);
            this.panel1.Controls.Add(this.unametb);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.unamelabel);
            this.panel1.Location = new System.Drawing.Point(275, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 344);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Already have an Account?";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link.Location = new System.Drawing.Point(141, 268);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(37, 15);
            this.link.TabIndex = 7;
            this.link.TabStop = true;
            this.link.Text = "Login";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // messagebox
            // 
            this.messagebox.AutoSize = true;
            this.messagebox.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagebox.Location = new System.Drawing.Point(60, 218);
            this.messagebox.MinimumSize = new System.Drawing.Size(200, 0);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(200, 15);
            this.messagebox.TabIndex = 6;
            // 
            // SignUpbutton
            // 
            this.SignUpbutton.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbutton.Location = new System.Drawing.Point(122, 175);
            this.SignUpbutton.Name = "SignUpbutton";
            this.SignUpbutton.Size = new System.Drawing.Size(83, 27);
            this.SignUpbutton.TabIndex = 2;
            this.SignUpbutton.Text = "Sign Up";
            this.SignUpbutton.UseVisualStyleBackColor = true;
            this.SignUpbutton.Click += new System.EventHandler(this.SignUpbutton_Click);
            // 
            // passwordtb
            // 
            this.passwordtb.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtb.Location = new System.Drawing.Point(146, 113);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(114, 23);
            this.passwordtb.TabIndex = 5;
            // 
            // emailtb
            // 
            this.emailtb.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtb.Location = new System.Drawing.Point(146, 73);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(114, 23);
            this.emailtb.TabIndex = 4;
            // 
            // unametb
            // 
            this.unametb.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unametb.Location = new System.Drawing.Point(146, 31);
            this.unametb.Name = "unametb";
            this.unametb.Size = new System.Drawing.Size(114, 23);
            this.unametb.TabIndex = 3;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(44, 113);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(59, 15);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(70, 73);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(37, 15);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // unamelabel
            // 
            this.unamelabel.AutoSize = true;
            this.unamelabel.Font = new System.Drawing.Font("Candara", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unamelabel.Location = new System.Drawing.Point(44, 35);
            this.unamelabel.Name = "unamelabel";
            this.unamelabel.Size = new System.Drawing.Size(69, 15);
            this.unamelabel.TabIndex = 0;
            this.unamelabel.Text = "User Name";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerHeading);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox unametb;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label unamelabel;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label messagebox;
        private System.Windows.Forms.Button SignUpbutton;
        private System.Windows.Forms.Label label1;
    }
}