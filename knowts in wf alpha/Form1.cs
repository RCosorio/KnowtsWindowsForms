using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace knowts_in_wf_alpha
{
    public partial class MainMenu : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        
        int indexRow;

        public static string selectedTitle;
        public static string selectedContent;
        
        public static string user;        

        public MainMenu()
        {
            InitializeComponent();         
            
        }        

        public void refreshData()
        {           
            if (user == null)
            {
                MessageBox.Show("No user logged in!");
                return;
            }
  
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            cmd = new OleDbCommand("SELECT Title, Content, dateTimeCreated FROM " + user, myConn);
            da = new OleDbDataAdapter(cmd);
            ds = new DataSet();
            da.Fill(ds, "notes");
            dataGridView1.DataSource = ds.Tables["notes"];
            myConn.Close();

            dataGridView1.Columns[0].HeaderText = "Title";
            dataGridView1.Columns[1].HeaderText = "Content";
            dataGridView1.Columns[2].HeaderText = "Date Created";

            //dataGridView1 column Title's width should its text length
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //half dateCreated column's current width
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            userLabel.Text = "Logged in as: " + user;      
        }

        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {    
            if (user == null)
            {
                MessageBox.Show("No user logged in!");
                return;
            }
            AddNote form2 = new AddNote();
            form2.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {     
            if (user == null)
            {
                MessageBox.Show("No user logged in!");
                return;
            }
            refreshData();
        }
      

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            selectedTitle = row.Cells[0].Value.ToString();
            selectedContent = row.Cells[1].Value.ToString();
            MessageBox.Show(selectedTitle + " " + selectedContent);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                selectedTitle = row.Cells[0].Value.ToString();
                selectedContent = row.Cells[1].Value.ToString();

                ViewUpdateNote form3 = new ViewUpdateNote();
                form3.Show();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {                  
            if (user == null)
            {
                MessageBox.Show("No user logged in!");
                return;
            }

            dataGridView1.ClearSelection();

            Search form4 = new Search();
            form4.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {         
            if (user != null)
            {
                MessageBox.Show("User already logged in!. Please Log out.");
                return;
            }
            LogInPage form5 = new LogInPage();
            form5.Show();   
            this.Hide();


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {                       
            if (user == null)
            {
                MessageBox.Show("No user logged in!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
     
            myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            cmd = new OleDbCommand("SELECT COUNT(*) FROM " + user, myConn);
            int noteCount = (int)cmd.ExecuteScalar();
            OleDbCommand cmd2 = new OleDbCommand("UPDATE userAnalytics SET noteCount = " + noteCount + " WHERE username = '" + user + "'", myConn);
            cmd2.ExecuteNonQuery();
            myConn.Close();


            //update userAnalytics table column "mostTags" with the most used tag in the user's notes
            try
            {
                myConn.Open();
                cmd = new OleDbCommand("SELECT searchTags FROM " + user, myConn);
                OleDbDataReader reader = cmd.ExecuteReader();
                Dictionary<string, int> tagCount = new Dictionary<string, int>();
                while (reader.Read())
                {
                    string[] tags = reader["searchTags"].ToString().Split(',');
                    foreach (string tag in tags)
                    {
                        if (tagCount.ContainsKey(tag))
                        {
                            tagCount[tag]++;
                        }
                        else
                        {
                            tagCount[tag] = 1;
                        }
                    }
                }
                string mostTags = tagCount.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
                OleDbCommand cmd3 = new OleDbCommand("UPDATE userAnalytics SET mostTags = '" + mostTags + "' WHERE username = '" + user + "'", myConn);
                cmd3.ExecuteNonQuery();
                myConn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            logOut();

            this.Hide();
        }

        void logOut()
        {
            selectedTitle = null;
            selectedContent = null;
            
            user = null;

            dataGridView1.DataSource = null;
            userLabel.Text = "No User, Log In!";
            userLabel.ForeColor = Color.Black;
            LogInPage form5 = new LogInPage();
            form5.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {          
            if (user == null)
            {
                MessageBox.Show("No user logged in!");
                return;
            }
            Settings form7 = new Settings();
            form7.Show();

        }
           
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.A))
            {
                AddNote form2 = new AddNote();
                form2.Show();
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                Search form4 = new Search();
                form4.Show();
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                refreshData();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}




  
