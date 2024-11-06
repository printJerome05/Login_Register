using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class RegisterForm : Form
    {


        public TextBox[] txtRegsiter = { };
        Connection con = new Connection();
        MySqlCommand cmd = new MySqlCommand();

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

            KeyPreview = true;
            DateFormat(dtBirthdate);

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {


            bool hasError = false;

            errorProvider1.Clear();


            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {

                hasError = true;
                errorProvider1.SetError(txtUsername, "Username field is Empty");
                MessageBox.Show("Username field is Empty", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {

                hasError = true;
                errorProvider1.SetError(txtPassword, "Password field is Empty");
                MessageBox.Show("Password field is Empty", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (string.IsNullOrWhiteSpace(txtRetype.Text))
            {
                hasError = true;
                errorProvider1.SetError(txtRetype, "Re-Password field is Empty");
                MessageBox.Show("Password field is Empty", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtPassword.Text.Trim() != txtRetype.Text.Trim())
            {

                hasError = true;
                errorProvider1.SetError(txtRetype, "Password Doesnt Match");
                MessageBox.Show("Password doesnt match", "PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (string.IsNullOrWhiteSpace(txtCellphone.Text))
            {

                hasError = true;
                errorProvider1.SetError(txtCellphone, "Cellphone field is Empty");
                MessageBox.Show("Cellphone field is Empty", "CELLPHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtCellphone.Text.Any(char.IsLetter))
            {

                hasError = true;
                errorProvider1.SetError(txtCellphone, "Cellphone number invalid");
                MessageBox.Show("Cellphone number invalid", "CELLPHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtCellphone.Text.Length > 11)
            {

                hasError = true;
                errorProvider1.SetError(txtCellphone, "Cellphone number length invalid 11 digits only");
                MessageBox.Show("Cellphone number length invalid 11 digits only", "CELLPHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (txtCellphone.Text.Length < 11)
            {

                hasError = true;
                errorProvider1.SetError(txtCellphone, "Cellphone number length need to be 11 digits");
                MessageBox.Show("Cellphone number length need to be 11 digits", "CELLPHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if ((!string.IsNullOrEmpty(txtCellphone.Text) && txtCellphone.Text.Length >= 2))
            {

                if (txtCellphone.Text[0] != '0' && txtCellphone.Text[1] != '9')
                {

                    hasError = true;
                    errorProvider1.SetError(txtCellphone, "Cellphone first 2 digits must be 09");
                    MessageBox.Show("Cellphone first 2 digits must be 09", "CELLPHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            if (string.IsNullOrEmpty(dtBirthdate.Text))
            {

                hasError = true;
                errorProvider1.SetError(dtBirthdate, "Birth date is empty");
                MessageBox.Show("Birth date is empty", "BIRTH DATE", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            if (hasError == true)
            {

                return;

            }

            try
            {
                con.Open();
                string query = "USE login_register; SELECT COUNT(*) FROM users WHERE BINARY username=@1";
                cmd = new MySqlCommand(query, con.con);
                cmd.Parameters.AddWithValue("@1", txtUsername.Text.Trim());
                int resultUser = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Parameters.Clear();
                if (resultUser == 1)
                {

                    errorProvider1.SetError(txtUsername, "User Already Exist Try Different Username");
                    MessageBox.Show("User Already Exist Try Different Username", "USERNAME", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (resultUser == 0)
                {

                    query = "USE login_register; SELECT COUNT(*) FROM users WHERE BINARY cellnumber=@1";
                    cmd = new MySqlCommand(query, con.con);
                    cmd.Parameters.AddWithValue("@1", txtCellphone.Text);
                    int resultCellphone = Convert.ToInt32(cmd.ExecuteScalar());
                    cmd.Parameters.Clear();

                    if (resultCellphone == 1)
                    {

                        errorProvider1.SetError(txtCellphone, "Cellphone Number already used");
                        MessageBox.Show("Cellphone Number already used", "CELLPHONE", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (resultCellphone == 0)
                    {

                        query = "USE login_register; INSERT INTO users(username,password,cellnumber,birthDate,registeredDate) VALUES(@1,@2,@3,@4,@5)";
                        cmd = new MySqlCommand(query, con.con);
                        cmd.Parameters.AddWithValue("@1", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@2", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@3", txtCellphone.Text.Trim());

                        string inputDateString = dtBirthdate.Text;
                        string formattedDate = DateTime.ParseExact(inputDateString, "MMMM-dd-yyyy", null).ToString("yyyy-MM-dd");

                        cmd.Parameters.AddWithValue("@4", formattedDate);
                        cmd.Parameters.AddWithValue("@5", DateTime.Today);


                        int resultInsert = cmd.ExecuteNonQuery();
                        if (resultInsert == 1)
                        {

                            MessageBox.Show("Register Succesful", "REGISTER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            txtUsername.Clear();
                            txtPassword.Clear();
                            txtRetype.Clear();
                            txtCellphone.Clear();
                            errorProvider1.Clear();
                            dtBirthdate.Text = DateTime.Today.ToString();

                        }
                        else if (resultInsert == 0)
                        {

                            MessageBox.Show("Something went wrong", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }

                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        private void RegisterForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                btnRegister.PerformClick();
                e.Handled = true;

            }

        }

        private void DateFormat(DateTimePicker dtPickerFormat)
        {

            dtPickerFormat.Format = DateTimePickerFormat.Custom;
            dtPickerFormat.CustomFormat = "MMMM-dd-yyyy";

        }
    }
}
