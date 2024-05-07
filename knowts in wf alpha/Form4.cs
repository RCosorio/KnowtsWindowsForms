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

namespace knowts_in_wf_alpha
{
    public partial class Search : Form
    {
        int indexRow;
        public static string selectedTitle;
        public static string selectedContent;
        public static string selectedTag;

        public Search()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {            
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
           
            string search = txtBoxSearch.Text;
            
            if (search == "")
            {
                MessageBox.Show("Please enter a search term!");
                return;
            }     
                    
            if (comboBoxSearchBy.Text == "")
            {
                MessageBox.Show("Please select a search option!");
                return;
            }

            if (comboBoxSearchBy.Text == "Title and Content")
            {
                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + MainMenu.user + " WHERE Title LIKE '%" + search + "%' OR Content LIKE '%" + search + "%'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvgSearch.DataSource = dt;
                labelSearchResult.Text = "Results for: " + search;
                if (dvgSearch.Rows.Count == 1)
                {
                    labelSearchResult.Text = "!No results found for: " + search;
                }
                myConn.Close();
            }
            
            else if (comboBoxSearchBy.Text == "Tag")
            {             

                myConn.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM " + MainMenu.user + " WHERE searchTags LIKE '%" + search + "%'", myConn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dvgSearch.DataSource = dt;
                labelSearchResult.Text = "Results for: " + search;
                if (dvgSearch.Rows.Count == 1)
                {
                    labelSearchResult.Text = "!No results found for: " + search;
                }
                myConn.Close();
            }
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE userAnalytics SET searchCount = searchCount + 1 WHERE username = '" + MainMenu.user + "'", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();            

        }

        private void dvgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dvgSearch.Rows[indexRow];
            selectedTitle = row.Cells[1].Value.ToString();
            selectedContent = row.Cells[2].Value.ToString();
            //make a variable to store comboBoxTag.Text
            selectedTag = row.Cells[4].Value.ToString();

            this.Close();
            ViewUpdateNote form3 = new ViewUpdateNote();
            form3.Show();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //if user selected "Tag" in comboBoxSearchBy, then show tooltip that says "Enter a tag to search for"
            if (comboBoxSearchBy.Text == "Tag")
            {
                ToolTip tt = new ToolTip();
                tt.SetToolTip(txtBoxSearch, "Tags:\nPersonal\nWork\nStudy\nIdeas\nShopping\nTravel\nRecipes\nHealth\nFinance\nEvents");
            }

        }
    }
}
