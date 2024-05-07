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
    public partial class UserAnalytics : Form
    {
        public UserAnalytics()
        {
            InitializeComponent();
            //all textboxes should be read only
            txtBoxUserNoteCount.ReadOnly = true;
            txtBoxAverageNoteCount.ReadOnly = true;
            txtBoxUserLogInCounter.ReadOnly = true;
            txtBoxAverageLogInCounter.ReadOnly = true;
            txtBoxUserAddNoteCounter.ReadOnly = true;
            txtBoxAverageAddNoteCounter.ReadOnly = true;
            txtBoxUserSearchNoteCounter.ReadOnly = true;
            txtBoxAverageSearchNoteCounter.ReadOnly = true;
            txtBoxUserDeleteNoteCounter.ReadOnly = true;
            txtBoxAverageDeleteNoteCounter.ReadOnly = true;
            txtBoxUserViewNoteCounter.ReadOnly = true;
            txtBoxAverageViewNoteCounter.ReadOnly = true;

        }

        private void Form9_Load(object sender, EventArgs e)
        {            
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserNoteCount.Text = reader["noteCount"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT AVG(noteCount) FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxAverageNoteCount.Text = reader[0].ToString();
            }
            myConn.Close();
                        
            myConn.Open();
            cmd = new OleDbCommand("SELECT logInCounter FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserLogInCounter.Text = reader["logInCounter"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT AVG(logInCounter) FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxAverageLogInCounter.Text = reader[0].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT addNoteCount FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserAddNoteCounter.Text = reader["addNoteCount"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT AVG(addNoteCount) FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxAverageAddNoteCounter.Text = reader[0].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT searchCount FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserSearchNoteCounter.Text = reader["searchCount"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT AVG(searchCount) FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxAverageSearchNoteCounter.Text = reader[0].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT deleteNoteCount FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserDeleteNoteCounter.Text = reader["deleteNoteCount"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT AVG(deleteNoteCount) FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxAverageDeleteNoteCounter.Text = reader[0].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT viewNoteCount FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserViewNoteCounter.Text = reader["viewNoteCount"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT AVG(viewNoteCount) FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxAverageViewNoteCounter.Text = reader[0].ToString();
            }
            myConn.Close();

            
            myConn.Open();
            cmd = new OleDbCommand("SELECT mostTags FROM userAnalytics WHERE username = '" + MainMenu.user + "'", myConn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtBoxUserTags.Text = reader["mostTags"].ToString();
            }
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT mostTags FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            Dictionary<string, int> tagCount = new Dictionary<string, int>();
            while (reader.Read())
            {
                string[] tags = reader["mostTags"].ToString().Split(',');
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
            txtBoxAverageTags.Text = mostTags;
            myConn.Close();

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }
    }
}
