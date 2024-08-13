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
            showBreakDown();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void showBreakDown()
        {
            double charge = 0;

            const double unitP1 = 15.00;
            const double unitP2 = 18.00;
            const double unitP3 = 30.00;
            const double unitP4 = 42.00;
            const double unitP5 = 65.00;

            int days = int.Parse(daysDiff);
            int usedUnits = int.Parse(noUnits);

            int allocateForP1 = 2 * days;
            int allocateForP2 = 1 * days;
            int allocateForP3 = 1 * days;
            int allocateForP4 = 2 * days;

            if (usedUnits <= allocateForP1)
            {
                charge = usedUnits * unitP1;
            }
            else if (usedUnits <= (allocateForP1 + allocateForP2))
            {
                charge = (allocateForP1 * unitP1) + ((usedUnits - allocateForP1) * unitP2);
            }
            else if (usedUnits <= (allocateForP1 + allocateForP2 + allocateForP3))
            {
                charge = (allocateForP1 * unitP1) + (allocateForP2 * unitP2) + ((usedUnits - (allocateForP1 + allocateForP2)) * unitP3);
            }
            else if (usedUnits <= (allocateForP1 + allocateForP2 + allocateForP3 + allocateForP4))
            {
                charge = (allocateForP1 * unitP1) + (allocateForP2 * unitP2) + (allocateForP3 * unitP3) + ((usedUnits - (allocateForP1 + allocateForP2 + allocateForP3)) * unitP4);
            }
            else
            {
                charge = (allocateForP1 * unitP1) + (allocateForP2 * unitP2) + (allocateForP3 * unitP3) + (allocateForP4 * unitP4) + ((usedUnits - (allocateForP1 + allocateForP2 + allocateForP3 + allocateForP4)) * unitP5);
            }

            netCharge.Text = "LRK. " + charge.ToString()+".00";
        }

    }
}
