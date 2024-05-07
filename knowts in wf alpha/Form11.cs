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
    public partial class PublicAnalytics : Form
    {
        public PublicAnalytics()
        {
            InitializeComponent();
            
            dgvFeedbacks.ReadOnly = true;            
            dgvFeedbacks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;            
            dgvFeedbacks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;            
            dgvFeedbacks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;                                               
        }

        private void Form11_Load(object sender, EventArgs e)
        {                                             
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT TOP 10 username, dateCreated, feedback FROM userFeedback ORDER BY dateCreated DESC", myConn);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFeedbacks.DataSource = dt;
            myConn.Close();

            dgvFeedbacks.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;   
            dgvFeedbacks.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            
            dgvFeedbacks.Columns[0].DefaultCellStyle.Font = new Font("Arial Rounded MT", 10, FontStyle.Bold);

            int averageRating = 0;        
            myConn.Open();            
            cmd = new OleDbCommand("SELECT AVG(rating) FROM userFeedback", myConn);            
            OleDbDataReader reader = cmd.ExecuteReader();            
            if (reader.Read())
            {
                try
                {
                    averageRating = Convert.ToInt32(reader[0]);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }           
            myConn.Close();

            labelAverageRating.Text = averageRating.ToString();            
            if (averageRating <= 2)
            {
                labelAverageRating.ForeColor = Color.Red;
            }            
            else if (averageRating == 3)
            {
                labelAverageRating.ForeColor = Color.Orange;
            }            
            else
            {
                labelAverageRating.ForeColor = Color.Green;
            }
     
            int yesCount = 0;
            int noCount = 0;
            myConn.Open();
            cmd = new OleDbCommand("SELECT issues FROM userFeedback", myConn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader["issues"].ToString() == "Yes")
                {
                    yesCount++;
                }
                else
                {
                    noCount++;
                }
            }
            myConn.Close();
 
            int total = yesCount + noCount;
            int yesPercentage = (yesCount * 100) / total;
            int noPercentage = (noCount * 100) / total;
         
            if (yesPercentage > noPercentage)
            {
                labelPercentage.ForeColor = Color.Red;
                labelPercentage.Text = yesPercentage + "%";
                label2.Text = "of overall users are experiencing\n  issues while using the app.";
            }
           
            else
            {
                labelPercentage.ForeColor = Color.Green;
                labelPercentage.Text = noPercentage + "%";
                label2.Text = "of overall users are having\n a seemless experience while\nusing the app.";
            }
                       
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
            labelTag.Text = mostTags;
            myConn.Close();    
            
            //display second most used tag in labelTag2
            myConn.Open();
            cmd = new OleDbCommand("SELECT mostTags FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            Dictionary<string, int> tagCount2 = new Dictionary<string, int>();
            while (reader.Read())
            {
                string[] tags = reader["mostTags"].ToString().Split(',');
                foreach (string tag in tags)
                {
                    if (tagCount2.ContainsKey(tag))
                    {
                        tagCount2[tag]++;
                    }
                    else
                    {
                        tagCount2[tag] = 1;
                    }
                }
            }       
            tagCount2.Remove(mostTags);
            string mostTags2 = tagCount2.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            labelTag2.Text = mostTags2;
            myConn.Close();

            //display third most used tag in labelTag3
            myConn.Open();
            cmd = new OleDbCommand("SELECT mostTags FROM userAnalytics", myConn);
            reader = cmd.ExecuteReader();
            Dictionary<string, int> tagCount3 = new Dictionary<string, int>();
            while (reader.Read())
            {
                string[] tags = reader["mostTags"].ToString().Split(',');
                foreach (string tag in tags)
                {
                    if (tagCount3.ContainsKey(tag))
                    {
                        tagCount3[tag]++;
                    }
                    else
                    {
                        tagCount3[tag] = 1;
                    }
                }
            }
            tagCount3.Remove(mostTags);
            tagCount3.Remove(mostTags2);
            string mostTags3 = tagCount3.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            labelTag3.Text = mostTags3;
            myConn.Close();
            
            myConn.Open();
            cmd = new OleDbCommand("SELECT COUNT(*) FROM sharedNotes", myConn);
            int sharedCount = (int)cmd.ExecuteScalar();
            labelShared.Text = sharedCount.ToString();
            myConn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
            LogInPage form5 = new LogInPage();
            form5.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
