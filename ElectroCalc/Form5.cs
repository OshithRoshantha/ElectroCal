using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ElectroCalc
{
    public partial class Form5 : Form
    {
        string email;
        string name;

        public Form5(string formatedUserName, string email)
        {
            InitializeComponent();
            userName.Text = formatedUserName;
            name = formatedUserName;
            this.email = email;
            panel1.Visible = true;
            panel2.Visible = false;
            LoadBillHistory();
        }
        private void LoadBillHistory()
        {
            string test;
            string connectionString = "Data Source=OSHITH-PC\\SQLEXPRESS;Initial Catalog=ElectroCal;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT userName, userEmail, billDuration, noUnits, billAmount, chargeOnUnits FROM userBillHistory WHERE userEmail = @userEmail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userEmail", email);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int yOffset = 0;

                while (reader.Read())
                {
                    Panel clonedPanel = new Panel
                    {
                        Size = panel2.Size,
                        BorderStyle = panel2.BorderStyle,
                        Location = new System.Drawing.Point(panel2.Location.X, panel2.Location.Y + yOffset),
                        BackColor = panel2.BackColor,
                        BackgroundImage = panel2.BackgroundImage,
                        BackgroundImageLayout = panel2.BackgroundImageLayout
                    };
                    foreach (Control control in panel2.Controls)
                    {
                        if (control is Label label)
                        {
                            Label clonedLabel = new Label
                            {
                                Size = label.Size,
                                Location = label.Location,
                                Font = label.Font,
                                ForeColor = label.ForeColor,
                                BackColor = label.BackColor,
                                Name = label.Name 
                            };
                            switch (label.Name)
                            {
                                case "dateDuration":
                                    clonedLabel.Text = reader["billDuration"].ToString();
                                    break;
                                case "units":
                                    clonedLabel.Text = reader["noUnits"].ToString() + " kWh";
                                    break;
                                case "bill":
                                    clonedLabel.Text = reader["billAmount"].ToString();
                                    break;
                                case "chargeOnUnits":
                                    clonedLabel.Text = reader["chargeOnUnits"].ToString();
                                    break;
                                default:
                                    clonedLabel.Text = label.Text; 
                                    break;
                            }

                            clonedPanel.Controls.Add(clonedLabel);
                        }
                    }

                    yOffset += clonedPanel.Height + 15;
                    panel1.Controls.Add(clonedPanel); 
                }

                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(name, email);
            form3.Show();
            this.Close();
            //test
        }
    }
}
