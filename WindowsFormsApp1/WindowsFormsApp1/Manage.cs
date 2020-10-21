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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            //log.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            String conSt = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            using (SqlConnection sql = new SqlConnection(conSt))
            {
                using (SqlCommand cmd = new SqlCommand("usp_delete", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Connection.Open();
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();

                    sql.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Db is deleted");
                }
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Biling bil = new Biling();
            bil.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Window man = new Main_Window();
            man.ShowDialog();
        }
    }
}
