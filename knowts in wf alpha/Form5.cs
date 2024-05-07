using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace knowts_in_wf_alpha
{
    public partial class LogInPage : Form
    {        
        public static string userLoggedIn;
        MainMenu form1 = new MainMenu();
        public LogInPage()
        {
            InitializeComponent();
            this.ControlBox = false;  
            txtBoxPassword.PasswordChar = '*';
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        { 
            SignUpPage form6 = new SignUpPage();
            form6.Show();          
            this.Close();

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {  
            if (txtBoxUsername.Text == "" || txtBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter a username and password!");
                return;
            }
          
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM usersTable WHERE username = '" + txtBoxUsername.Text + "' AND userPassword = '" + txtBoxPassword.Text + "'", myConn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                userLoggedIn = txtBoxUsername.Text;
                MainMenu.user = userLoggedIn;         
                OleDbCommand cmd2 = new OleDbCommand("UPDATE userAnalytics SET logInCounter = logInCounter + 1 WHERE username = '" + userLoggedIn + "'", myConn);
                cmd2.ExecuteNonQuery();   
                OleDbCommand cmd3 = new OleDbCommand("UPDATE userAnalytics SET lastLogInDate = '" + DateTime.Now.ToString("MM/dd/yyyy") + "' WHERE username = '" + userLoggedIn + "'", myConn);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("Logged in as: " + userLoggedIn);

                //change form1.userLabel to lime green
                form1.userLabel.ForeColor = Color.LimeGreen;
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
            myConn.Close();            
            this.Close();          
            form1.Show();
            form1.refreshData();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnUserFeedbacks_Click(object sender, EventArgs e)
        {
            try
            {
                PublicAnalytics form11 = new PublicAnalytics();
                form11.Show();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
