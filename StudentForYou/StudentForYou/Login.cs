﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            // Username is required to ender it into user profile
            String Username = "Jeff";
            UserProfile Profile = new UserProfile(Username);
            this.Hide();
            Profile.Show();
        }

        private void coursesbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 courses = new form1();
            courses.Show();
        }

        private void recentquestionsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecentPostsForm rpF = new RecentPostsForm();
            rpF.Show();
        }
    }
}
