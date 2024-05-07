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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
     
            if (txtBoxNewPassword.Text == "" || txtBoxNewPasswordConfirm.Text == "")
            {
                MessageBox.Show("Please fill in the textboxes with new password.");
                return;
            }
  
            if (txtBoxNewPassword.Text != txtBoxNewPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
  
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\\Users\\Predator\\Desktop\\Coding Files\\knowtsDatabase.mdb");
            myConn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE usersTable SET userPassword = '" + txtBoxNewPassword.Text + "' WHERE username = '" + LogInPage.userLoggedIn + "'", myConn);
            cmd.ExecuteNonQuery();
            myConn.Close();
            MessageBox.Show("Password updated successfully!");
            
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
