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
    public partial class SignUpPage : Form
    {
        private OleDbConnection myConn;
        private OleDbCommand cmd;
        private OleDbDataAdapter da;
        private DataSet ds;


        public SignUpPage()
        {
            InitializeComponent();            

        }

        private void button1_Click(object sender, EventArgs e)
        {               
            if (txtBoxUsername.Text == "" || txtBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter a username and password!");
                return;
            } 
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            cmd = new OleDbCommand("SELECT * FROM usersTable WHERE username = '" + txtBoxUsername.Text + "'", myConn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Username already exists!");
                myConn.Close();
                return;
            }
            myConn.Close();

            AddUser();           
        }

        private void AddUser()
        {
            string username = txtBoxUsername.Text;
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();            
            cmd = new OleDbCommand("INSERT INTO usersTable (username, userPassword) VALUES ('" + txtBoxUsername.Text + "', '" + txtBoxPassword.Text + "')", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("User added successfully!");   
            
            myConn.Open();            
            cmd = new OleDbCommand("CREATE TABLE " + username + " (ID COUNTER PRIMARY KEY, Title TEXT, Content TEXT, dateTimeCreated TEXT, searchTags TEXT)", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();     
            myConn.Open();
            cmd = new OleDbCommand("INSERT INTO userAnalytics (username) VALUES ('" + txtBoxUsername.Text + "')", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();

            LogInPage form5 = new LogInPage();                
            form5.Show();
            this.Close();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {     
            LogInPage form5 = new LogInPage();
            form5.Show();
            this.Close();

        }
    }
}
