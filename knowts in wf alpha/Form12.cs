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
    public partial class Form12 : Form
    {        
        public static string content;

        public Form12()
        {
            InitializeComponent();                        

        }

        private void btnConfirmImport_Click(object sender, EventArgs e)
        {            

            if (txtBoxCode.Text == "")
            {
                MessageBox.Show("Please enter a code!");
                return;
            }            
            string code = txtBoxCode.Text;     
            
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM sharedNotes WHERE code = '" + code + "'", myConn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                content = reader["content"].ToString();                                                
                myConn.Close();
                MessageBox.Show("Import Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid code!");
                myConn.Close();
            }
        }

        private void btnPasteCode_Click(object sender, EventArgs e)
        {                        
            txtBoxCode.Text = Clipboard.GetText();

        }
    }
}
