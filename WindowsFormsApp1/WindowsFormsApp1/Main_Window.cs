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
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Biling bil = new Biling();
            bil.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //String conSt = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            //using (SqlConnection sql = new SqlConnection(conSt))
            //{
            //    using (SqlCommand cmd = new SqlCommand("delete * from Biling where merterNo = @", sql))
            //    {
            //        cmd.CommandText = CommandType.Text;
            //        cmd.Parameters.AddWithValue("",t);
            //        sql.Open();
            //        cmd.ExecuteNonQuery();
                    
                   
                   
            //        // MessageBox.Show("Meter no is deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //String conSt = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            //using (SqlConnection sql = new SqlConnection(conSt))
            //{
            //    using (SqlCommand cmd = new SqlCommand("usp_Biling", sql))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        cmd.Parameters.AddWithValue("meterNo", meterNo.Text);
            //        cmd.Parameters.AddWithValue("previousReading", previousReading.Text);
            //        cmd.Parameters.AddWithValue("currentReading", currentReading.Text);
            //        cmd.Parameters.AddWithValue("bilingAmount", bilingAmount.Text);

            //        sql.Open();

            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Biling is Updated to DB", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}

            Form1 fm = new Form1();
            fm.ShowDialog();
        }
    }
}
