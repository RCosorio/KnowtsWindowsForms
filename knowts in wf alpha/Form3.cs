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
    public partial class ViewUpdateNote : Form
    {
        

        public ViewUpdateNote()
        {
            InitializeComponent();
            
            if (Search.selectedContent != null)
            {
                txtBoxNewContent.Text = Search.selectedContent;
                txtBoxNewTitle.Text = Search.selectedTitle;
            }
            else
            {
                txtBoxNewContent.Text = MainMenu.selectedContent;
                txtBoxNewTitle.Text = MainMenu.selectedTitle;
            }
            
            if (Search.selectedTag != null)
            {
                comboBoxTag.SelectedItem = Search.selectedTag;
            }
            
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT searchTags FROM " + MainMenu.user + " WHERE Title = '" + MainMenu.selectedTitle + "' AND Content = '" + MainMenu.selectedContent + "'", myConn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string tag = reader["searchTags"].ToString();
                comboBoxTag.SelectedItem = tag;
            }
            myConn.Close();

            OleDbConnection myConn1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn1.Open();
            OleDbCommand cmd1 = new OleDbCommand("UPDATE userAnalytics SET viewNoteCount = viewNoteCount + 1 WHERE username = '" + MainMenu.user + "'", myConn1);
            cmd1.ExecuteNonQuery();
            myConn1.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this note?", "Update Note", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }                
                   
            if (txtBoxNewContent.Text == Search.selectedContent && txtBoxNewTitle.Text == Search.selectedTitle)
            {
                MessageBox.Show("No changes made to the note!");
                return;
            }
      
            if (MainMenu.selectedContent == null && MainMenu.selectedTitle == null)
            {
                MainMenu.selectedContent = Search.selectedContent;
                MainMenu.selectedTitle = Search.selectedTitle;
            }

            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();            
            OleDbCommand cmd = new OleDbCommand("UPDATE " + MainMenu.user + " SET Title = '" + txtBoxNewTitle.Text + "', Content = '" + txtBoxNewContent.Text + "', searchTags = '" + comboBoxTag.Text + "' WHERE Title = '" + MainMenu.selectedTitle + "' AND Content = '" + MainMenu.selectedContent + "'", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
                        
            MessageBox.Show("Note updated successfully!");
            this.Close();
            
            Search.selectedContent = null;
            Search.selectedTitle = null;
            MainMenu.selectedContent = null;
            MainMenu.selectedTitle = null;            
            Search.selectedTag = null;

        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBoxNewContent.Text);
            MessageBox.Show("Content copied to clipboard!");
        }

        private void btnEnableEdit_Click(object sender, EventArgs e)
        {
                       
            if (txtBoxNewContent.ReadOnly == true)
            {
                btnEnableEdit.Image = Properties.Resources.edit_3_icon;
                txtBoxNewContent.ReadOnly = false;
                txtBoxNewTitle.ReadOnly = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                btnEnableEdit.Image = Properties.Resources.edit_2_icon;
                txtBoxNewContent.ReadOnly = true;
                txtBoxNewTitle.ReadOnly = true;
                btnUpdate.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {       
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM " + MainMenu.user + " WHERE Title = '" + txtBoxNewTitle.Text + "' AND Content = '" + txtBoxNewContent.Text + "'", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Note deleted successfully!");
            this.Close();
     
            myConn.Open();
            OleDbCommand cmd2 = new OleDbCommand("UPDATE userAnalytics SET deleteNoteCount = deleteNoteCount + 1 WHERE username = '" + MainMenu.user + "'", myConn);
            cmd2.ExecuteNonQuery();
            myConn.Close();
        }

        private void btnShare_Click(object sender, EventArgs e)
        {                        
            if (txtBoxNewContent.Text == "")
            {
                MessageBox.Show("Please enter content to share!");
                return;
            }

            string code = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                code += (char)random.Next(65, 90);
            }
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO sharedNotes (code, content) VALUES ('" + code + "', '" + txtBoxNewContent.Text + "')", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
            
            Clipboard.SetText(code);
            MessageBox.Show("Note shared successfully! Code copied to clipboard!");                                    
        }

        private void btnImport_Click(object sender, EventArgs e)
        {      
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void ViewUpdateNote_Load(object sender, EventArgs e)
        {

        }

        private void btnPasteImport_Click(object sender, EventArgs e)
        {                        
            if (Form12.content == null)
            {
                MessageBox.Show("No content to import!");
                return;
            }
            txtBoxNewContent.Text = Form12.content;            
            
            Form12.content = null;
        }
    }
}
