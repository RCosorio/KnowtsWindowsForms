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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Tesseract;

namespace knowts_in_wf_alpha
{
    public partial class AddNote : Form
    {
        OleDbConnection myConn;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        int indexRow;
        MainMenu form1 = new MainMenu();
        
        
        public AddNote()
        {
            InitializeComponent(); 
            
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {                        
            if (txtBoxNoteTitle.Text == "" || txtBoxContent.Text == "")
            {
                MessageBox.Show("Please enter a title and content!");
                return;
            }
            try
            {
                myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
                myConn.Open();
                cmd = new OleDbCommand("INSERT INTO " + MainMenu.user + " (Title, Content, dateTimeCreated, searchTags) VALUES ('" + txtBoxNoteTitle.Text + "', '" + txtBoxContent.Text + "', '" + DateTime.Now + "', '" + comboBoxTag.Text + "')", myConn);
                cmd.ExecuteNonQuery();
                myConn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
            MessageBox.Show("Note saved!");
            this.Close();

            form1.refreshData();
            try{
                myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
                myConn.Open();
                cmd = new OleDbCommand("UPDATE userAnalytics SET addNoteCount = addNoteCount + 1 WHERE username = '" + MainMenu.user + "'", myConn);
                cmd.ExecuteNonQuery();
                myConn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        
        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtBoxContent.Text);
                MessageBox.Show("Content copied to clipboard!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnImageToText_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";  
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                new Bitmap(ofd.FileName);
            }

            try
            {
                using (var engine = new TesseractEngine(@"C:\Users\Predator\Source\Repos\tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(ofd.FileName))
                    {
                        using (var page = engine.Process(img))
                        {

                            var text = page.GetText();

                            txtBoxContent.Text = text;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {            
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {            
            Form12 form12 = new Form12();
            form12.Show();
        }

        private void btnPasteImport_Click(object sender, EventArgs e)
        {            
            if (Form12.content == null)
            {
                MessageBox.Show("No content to import!");
                return;
            }
            txtBoxContent.Text = Form12.content;
            
            Form12.content = null;
        }
    }
}

