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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Register
{
    public partial class MainMenu : Form
    {

        Connection con = new Connection();
        public string? Username;
        public string? Password;
        public string? Role;
        public string? cellnumber;
        public DateTime? birthDate;
        public DateTime today = DateTime.Today;
        public int ageYears;
        public int ageMonth;
        public int ageDays;
        public DateTime? dateregistered;
        public int ageDaysAccount;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {


            lblWelcomeMessage.Text = Username; 
            lblUsername.Text = Username; 
            lblPassword.Text = Password; 
            lblCellNumber.Text = cellnumber; 
            lblRole.Text = Role;

            ageYears = today.Year - birthDate.Value.Year;
            // Adjust the age if the birthday has not occurred yet this year
            if (today.Month < birthDate.Value.Month || (today.Month == birthDate.Value.Month && today.Day < birthDate.Value.Day))
            {
                ageYears--;
            }
            ageMonth = (ageYears * 12) + (today.Month - birthDate.Value.Month);
            // Adjust the month count if the day hasn't passed this month
            if (today.Day < birthDate.Value.Day)
            {
                ageMonth--;
            }

            ageDays = (today - birthDate.Value).Days;

            ageDaysAccount = (today - dateregistered.Value).Days;



            lblBirthdate.Text = birthDate.Value.ToString("MMMM-dd-yyyy");
            lblAge.Text = $"Year: {ageYears}, Month: {ageMonth}, Days: {ageDays}";
            lblDateRegistered.Text = $"{dateregistered.Value.ToString("MMMM-dd-yyyy")} || Days: {ageDaysAccount}";


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            Hide();
            lf.ShowDialog();
            lf.Dispose();
            Show();
        }
    }
}
