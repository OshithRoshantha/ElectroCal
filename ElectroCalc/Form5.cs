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
            panel1.Visible = false;
            LoadBillHistory();
        }

        private void LoadBillHistory()
        {
            string connectionString = "Data Source=OSHITH-PC\\SQLEXPRESS;Initial Catalog=ElectroCal;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT userName, userEmail, billDuration, noUnits, billAmount, chargeOnUnits FROM userBillHistory WHERE userEmail = @userEmail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userEmail", email);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    int yOffset = 0; 

                    while (reader.Read())
                    {
                        Panel clonedPanel = new Panel
                        {
                            Size = panel1.Size,
                            BorderStyle = panel1.BorderStyle,
                            Location = new System.Drawing.Point(panel1.Location.X, panel1.Location.Y + yOffset),
                            BackColor = panel1.BackColor, 
                            BackgroundImage = panel1.BackgroundImage, 
                            BackgroundImageLayout = panel1.BackgroundImageLayout 
                        };
                        foreach (Control control in panel1.Controls)
                        {
                            if (control is Label label)
                            {
                                Label clonedLabel = new Label
                                {
                                    Size = label.Size,
                                    Location = label.Location,
                                    Font = label.Font,
                                    ForeColor = label.ForeColor,
                                    BackColor = label.BackColor 
                                };
                                clonedLabel.Text = label.Text;
                                switch (label.Name)
                                {
                                    case "dateDuration":
                                        clonedLabel.Text = reader["billDuration"].ToString();
                                        break;
                                    case "units":
                                        clonedLabel.Text = reader["noUnits"].ToString();
                                        break;
                                    case "bill":
                                        clonedLabel.Text = reader["billAmount"].ToString();
                                        break;
                                    case "chargeOnUnits":
                                        clonedLabel.Text = reader["chargeOnUnits"].ToString();
                                        break;
                                }
                                clonedPanel.Controls.Add(clonedLabel);
                            }
                        }
                        yOffset += clonedPanel.Height + 15;
                        scrollablePanel.Controls.Add(clonedPanel);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(name, email);
            form3.Show();
            this.Close();
        }

        private void userName_Click(object sender, EventArgs e)
        {
        }
    }
}
