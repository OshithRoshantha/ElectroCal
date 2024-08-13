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
    public partial class Form4 : Form
    {
        String dateChange;
        String daysDiff;
        String noUnits;

        public Form4(string dateChange,string daysDiff, string noUnits)
        {
            InitializeComponent();
            this.dateChange = dateChange;
            this.daysDiff = daysDiff;
            this.noUnits = noUnits;
            datePeriod.Text = dateChange;
            days.Text = daysDiff+" Days";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
