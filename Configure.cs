using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Register.Properties;
using MySql.Data.MySqlClient;

namespace Login_Register
{
    public partial class Configure : Form
    {


        Connection con = new Connection();
        LoginForm loginForm = new LoginForm();


        public Configure()
        {
            InitializeComponent();
        }

        private void Configure_Load(object sender, EventArgs e)
        {

            KeyPreview = true;

            txtServer.Text = Settings.Default.server;
            txtUser.Text = Settings.Default.user;
            txtPassword.Text = Settings.Default.password;

            if (Tag != "Edit")
            {

                try
                {

                    con.Open();
                    if (con.con.State == ConnectionState.Open)
                    {

                        Hide();
                        loginForm.ShowDialog();
                        loginForm.Dispose();
                        Show();

                    }

                }
                catch (MySqlException)
                {

                    MessageBox.Show("Setup Error Check Please Check if input is correct", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Settings.Default.server = txtServer.Text;
            Settings.Default.user = txtUser.Text;
            Settings.Default.password = txtPassword.Text;

            Settings.Default.Save();

            Application.Restart();

        }

        private void Configure_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
                e.Handled = true;
            }
        }
    }
}
