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
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Please fill in all details.");
                return;
            }
 
            DateTime date = DateTime.Now;

            string submitter = "";
            if (radioButtonHideUsername.Checked)
            {
                submitter = "Anonymous";
            }
            else
            {
                submitter = MainMenu.user;
            }
                        
            string issues = comboBox1.SelectedItem.ToString();
            string feedback = txtBoxFeedback.Text;
            int rating = 0;               
                        
            if (radioButton1.Checked)
            {
                rating = 1;
            }
            else if (radioButton2.Checked)
            {
                rating = 2;
            }
            else if (radioButton3.Checked)
            {
                rating = 3;
            }
            else if (radioButton4.Checked)
            {
                rating = 4;
            }
            else if (radioButton5.Checked)
            {
                rating = 5;
            }

            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO userFeedback (username, rating, feedback, dateCreated, issues) VALUES ('" + submitter + "', " + rating + ", '" + feedback + "', '" + date + "', '" + issues + "')", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Feedback submitted successfully! Thank you!");
            this.Close();            

        }
       
        private void radioButtonHideUsername_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
