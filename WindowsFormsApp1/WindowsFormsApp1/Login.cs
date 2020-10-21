using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conSt = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            using (SqlConnection sql = new SqlConnection(conSt))
            {
                using (SqlCommand cmd = new SqlCommand("usp_userEntery", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("userName ", userNameTextBox.Text);
                    cmd.Parameters.AddWithValue("email", emailTextBox.Text);
                    cmd.Parameters.AddWithValue("password", passwordTextBox.Text);
                    
                    sql.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User is added to DB", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}