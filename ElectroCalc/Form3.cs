using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroCalc
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            textBox6.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.Location = new Point(textBox2.Left, textBox2.Bottom);
            monthCalendar1.BringToFront();
        }
        private void monthCalendar1_LostFocus(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString();
            monthCalendar1.Visible = false;
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            monthCalendar2.Visible = true;
            monthCalendar2.Location = new Point(textBox3.Left, textBox3.Bottom);
            monthCalendar2.BringToFront();
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox3.Text = monthCalendar2.SelectionStart.ToShortDateString();
            monthCalendar2.Visible = false;
        }
        private void monthCalendar2_LostFocus(object sender, EventArgs e)
        {
            monthCalendar2.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox1.Text = "";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Enabled = false;
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = true;
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                textBox6.Text = "";
            }
            else
            {
                textBox5.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Text = "";
                textBox4.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox6.Enabled = true;
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        public int getDays()
        {
            DateTime date1 = DateTime.Parse(textBox2.Text);
            DateTime date2 = DateTime.Parse(textBox3.Text);
            return (date2 - date1).Days;
        }

        public int getUnits()
        {
            return int.Parse(textBox4.Text) - int.Parse(textBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int noDays=0, units=0;
            String text="";
            if (textBox1.Text==""&& textBox2.Text != "" && textBox3.Text != "")
            {
                noDays= getDays();
                text = textBox2.Text + " - " + textBox3.Text;
            }
            if(textBox2.Text==""&& textBox3.Text == ""&& textBox1.Text != "")
            {
                noDays = int.Parse(textBox1.Text);
                DateTime currentDate = DateTime.Now;
                DateTime startDate = currentDate.AddDays(-noDays);
                string startDateFormatted = startDate.ToString("dd/MM/yyyy");
                string currentDateFormatted = currentDate.ToString("dd/MM/yyyy");
                text = startDateFormatted + " - " + currentDateFormatted;
            }
            if (textBox6.Text == "" && textBox4.Text != "" && textBox5.Text != "")
            {
                units = getUnits();
            }
            if (textBox5.Text == "" && textBox4.Text == ""&& textBox6.Text != "")
            {
                units = int.Parse(textBox6.Text);
            }
            this.Close();
            totalCharge form4 = new totalCharge(text,noDays.ToString(),units.ToString());
            form4.Show();
        }
    }
}
