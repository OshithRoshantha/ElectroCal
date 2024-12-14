using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt.Net;

namespace ElectroCalc
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=OSHITH-PC\\SQLEXPRESS;Initial Catalog=ElectroCal;Integrated Security=True;TrustServerCertificate=True";

        string userName;
        string email;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailInput = textBox1.Text;
            email = emailInput;
            string passwordInput= textBox2.Text;

            if (emailInput != "" && passwordInput != "")
            {

                if (checkEmailExist(emailInput))
                {
                    label3.Visible = false;
                    if (userAuthentication(emailInput, passwordInput))
                    {
                        label9.Visible = false;
                        userName = GetUserNameByEmail(emailInput);
                        Form3 form3 = new Form3(userName, email);
                        form3.Show();
                        this.Hide();
                    }
                    else
                    {
                        label9.Visible = true;
                    }
                }
                else
                {
                    label3.Visible = true;

                }
            }
        }

        public Boolean userAuthentication(string email, string password)
        {
            string checkQuery = "SELECT userPassword FROM userInfo WHERE userEmail = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    string storedHashedPassword = (string)cmd.ExecuteScalar();

                    bool isPasswordCorrect = storedHashedPassword != null && BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                    return isPasswordCorrect;
                }
            }
        }

        public Boolean checkEmailExist(string email)
        {
            string checkQuery = "SELECT COUNT(*) FROM userInfo WHERE userEmail = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(checkQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public string GetUserNameByEmail(string email)
        {
            string query = "SELECT userName FROM userInfo WHERE userEmail = @Email";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString(); 
                }
            }
        }


    }
}
