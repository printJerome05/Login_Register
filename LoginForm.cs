using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Login_Register.Properties;


namespace Login_Register
{
    public partial class LoginForm : Form
    {

        Connection con = new Connection();
        MySqlCommand cmd = new MySqlCommand();

        private TextBox[] txtLogin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            lblCreatedBy.Text = Settings.Default.createdBy;

            con.CreateDatabase();

            KeyPreview = true;
            KeyDown += new KeyEventHandler(LoginForm_KeyDown);

            txtPassword.UseSystemPasswordChar = true;
            TextBox[] txtLogin = { txtUsername, txtPassword };

        }

        private bool HasError()
        {


            TextBox[] txtLogin = { txtUsername, txtPassword };

            foreach (TextBox txt in txtLogin)
            {

                string errorMessage = errorProvider1.GetError(txt);

                if (string.IsNullOrEmpty(errorMessage))
                {

                    return false;

                }
                else
                {

                    return true;

                }

            }

            return true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {

                errorProvider1.SetError(txtUsername, "Username field is Empty");
                MessageBox.Show("Username field is Empty", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {

                errorProvider1.SetError(txtPassword, "Password field is Empty");
                MessageBox.Show("Password field is Empty", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            bool resulError = HasError();
            if (resulError == true)
            {

                return;

            }

            try
            {

                con.Open();
                string query = "USE login_register; SELECT COUNT(*) FROM users WHERE BINARY username=@1";
                cmd = new MySqlCommand(query, con.con);
                cmd.Parameters.AddWithValue("@1", txtUsername.Text.Trim());
                int resultUsername = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultUsername == 0)
                {

                    errorProvider1.SetError(txtUsername, "Username not exist");
                    MessageBox.Show("Username not exist", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (resultUsername == 1)
                {

                    errorProvider1.Clear();
                    query = "USE login_register; SELECT * FROM users WHERE BINARY username=@1 AND BINARY password=@2";
                    cmd = new MySqlCommand(query, con.con);
                    cmd.Parameters.AddWithValue("@1", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@2", txtPassword.Text.Trim());
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {

                        if (reader.Read())
                        {

                            errorProvider1.Clear();
                            MainMenu menu = new MainMenu();
                            menu.Username = reader.GetString("username");
                            menu.Password = reader.GetString("password");
                            menu.Role = reader.GetString("role");
                            menu.cellnumber = reader.GetString("cellnumber");
                            menu.birthDate = reader.GetDateTime("birthDate");
                            menu.dateregistered = reader.GetDateTime("registeredDate");
                            reader.Close();
                            Hide();
                            menu.ShowDialog();
                            menu.Dispose();
                            Show();

                        }

                    }
                    else if (!reader.HasRows)
                    {

                        reader.Close();
                        errorProvider1.SetError(txtPassword, "Wrong Password");
                        MessageBox.Show("Wrong Password", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            RegisterForm rf = new RegisterForm();
            Hide();
            rf.ShowDialog();
            rf.Dispose();
            Show();

        }

        private void pctrLock_Click(object sender, EventArgs e)
        {

            pctrLock.SendToBack();
            txtPassword.UseSystemPasswordChar = false;

        }

        private void pctrUnlock_Click(object sender, EventArgs e)
        {

            pctrUnlock.SendToBack();
            txtPassword.UseSystemPasswordChar = true;

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Environment.Exit(0);

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            Configure cf = new Configure();
            cf.Tag = "Edit";
            Hide();
            cf.ShowDialog();
            cf.Dispose();
            Show();

        }
    }

}
