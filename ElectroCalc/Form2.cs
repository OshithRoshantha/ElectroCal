using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ElectroCalc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean isFormValid=false;

            if (textBox3.Text != "" && textBox3.Text != textBox5.Text)
            {
                showPasswordNotMatching();
            }
            else if (textBox3.Text != "" && textBox3.Text == textBox5.Text)
            {
                label8.Visible = false;
                isFormValid = true;
            }
            if(textBox4.Text =="" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text=="" || textBox5.Text=="")
            {
                isFormValid=false;
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }

            if (isFormValid)
            {
                string email = textBox4.Text;
                string userName = textBox1.Text;
                string userPassword = textBox3.Text;
                string userNIC = textBox2.Text;

                string connectionString = "Data Source=OSHITH-PC\\SQLEXPRESS;Initial Catalog=ElectroCal;Integrated Security=True;TrustServerCertificate=True";

                string query = "INSERT INTO userInfo (userEmail, userName, userPassword, userNIC) VALUES (@Email, @UserName, @UserPassword, @UserNIC)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        cmd.Parameters.AddWithValue("@UserPassword", userPassword);
                        cmd.Parameters.AddWithValue("@UserNIC", userNIC);

                        cmd.ExecuteNonQuery();
                    }
                }

                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
        }

        private void sqlDataAdapter1_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {

        }

        public void showPasswordNotMatching()
        {
            label8.Visible = true;
        }
    }
}
