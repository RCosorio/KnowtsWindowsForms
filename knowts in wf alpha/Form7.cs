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
    public partial class Settings : Form
    {
        private OleDbConnection myConn;
        private OleDbDataAdapter da;
        private OleDbCommand cmd;
        private DataSet ds;

        public Settings()
        {
            InitializeComponent();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {             
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
         {
                    return;
              }
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM usersTable WHERE username = '" + LogInPage.userLoggedIn + "'", myConn);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("DROP TABLE " + LogInPage.userLoggedIn, myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Account deleted successfully!");
                                    
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            cmd = new OleDbCommand("DELETE FROM userAnalytics WHERE username = '" + LogInPage.userLoggedIn + "'", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
            
            MainMenu.selectedContent = null;
            MainMenu.selectedTitle = null;
            Search.selectedContent = null;
            Search.selectedTitle = null;

            MainMenu.user = null;
            LogInPage.userLoggedIn = null;
            this.Close();
            
            LogInPage form5 = new LogInPage();
            form5.Show();


        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //open form 8
            ChangePassword form8 = new ChangePassword();
            form8.Show();
            this.Close();
        }       

        private void button2_Click(object sender, EventArgs e)
        {            
            UserAnalytics form9 = new UserAnalytics();
            form9.Show();
            this.Close();
            
        }

        private void btnSCuts_Click(object sender, EventArgs e)
        {            
            MessageBox.Show("Shortcuts: \n\nCtrl + A: New Note \nCtrl + R: Refresh \nCtrl + S: Search");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {            
            FeedbackForm form10 = new FeedbackForm();
            form10.Show();
            this.Close();

        }
    }
}
