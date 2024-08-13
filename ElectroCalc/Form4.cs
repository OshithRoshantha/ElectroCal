﻿using System;
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

        public Form4(string dateChange, string daysDiff, string noUnits)
        {
            InitializeComponent();
            this.dateChange = dateChange;
            this.daysDiff = daysDiff;
            this.noUnits = noUnits;
            datePeriod.Text = dateChange;
            days.Text = daysDiff + " Days";
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

            double kWhPerMonth = (usedUnits / days) * 30;

            if (kWhPerMonth <= 60)
            {
                int allocateForP5 = days;
                if (usedUnits <= allocateForP5)
                {
                    charge = usedUnits * 6.00;
                    unit1.Text = "6.00 * " + usedUnits + " = " + charge.ToString("F2");
                    getFixedCharge(days,100);
                }
                else
                {
                    charge = (days * 6.00) + ((usedUnits - days) * 9.00);
                    unit1.Text = "6.00 * " + days + " = " + (days * 6.00).ToString("F2");
                    unit2.Text = "9.00 * " + (usedUnits - days) + " = " + ((usedUnits - days) * 9.00).ToString("F2");
                    getFixedCharge(days,250);
                }
            }
            else
            {
                if (usedUnits <= allocateForP1)
                {
                    charge = usedUnits * unitP1;
                    unit1.Text = "15.00 * " + usedUnits + " = " + charge.ToString("F2");
                }
                else if (usedUnits <= (allocateForP1 + allocateForP2))
                {
                    charge = (allocateForP1 * unitP1) + ((usedUnits - allocateForP1) * unitP2);
                    unit1.Text = "15.00 * " + allocateForP1 + " = " + (allocateForP1 * unitP1).ToString("F2");
                    unit2.Text = "18.00 * " + (usedUnits - allocateForP1) + " = " + ((usedUnits - allocateForP1) * unitP2).ToString("F2");
                    getFixedCharge(days,400);
                }
                else if (usedUnits <= (allocateForP1 + allocateForP2 + allocateForP3))
                {
                    charge = (allocateForP1 * unitP1) + (allocateForP2 * unitP2) + ((usedUnits - (allocateForP1 + allocateForP2)) * unitP3);
                    unit1.Text = "15.00 * " + allocateForP1 + " = " + (allocateForP1 * unitP1).ToString("F2");
                    unit2.Text = "18.00 * " + allocateForP2 + " = " + (allocateForP2 * unitP2).ToString("F2");
                    unit3.Text = "30.00 * " + (usedUnits - (allocateForP1 + allocateForP2)) + " = " + ((usedUnits - (allocateForP1 + allocateForP2)) * unitP3).ToString("F2");
                    getFixedCharge(days,1000);
                }
                else if (usedUnits <= (allocateForP1 + allocateForP2 + allocateForP3 + allocateForP4))
                {
                    charge = (allocateForP1 * unitP1) + (allocateForP2 * unitP2) + (allocateForP3 * unitP3) + ((usedUnits - (allocateForP1 + allocateForP2 + allocateForP3)) * unitP4);
                    unit1.Text = "15.00 * " + allocateForP1 + " = " + (allocateForP1 * unitP1).ToString("F2");
                    unit2.Text = "18.00 * " + allocateForP2 + " = " + (allocateForP2 * unitP2).ToString("F2");
                    unit3.Text = "30.00 * " + allocateForP3 + " = " + (allocateForP3 * unitP3).ToString("F2");
                    unit4.Text = "42.00 * " + (usedUnits - (allocateForP1 + allocateForP2 + allocateForP3)) + " = " + ((usedUnits - (allocateForP1 + allocateForP2 + allocateForP3)) * unitP4).ToString("F2");
                    getFixedCharge(days,1500);
                }
                else
                {
                    charge = (allocateForP1 * unitP1) + (allocateForP2 * unitP2) + (allocateForP3 * unitP3) + (allocateForP4 * unitP4) + ((usedUnits - (allocateForP1 + allocateForP2 + allocateForP3 + allocateForP4)) * unitP5);
                    unit1.Text = "15.00 * " + allocateForP1 + " = " + (allocateForP1 * unitP1).ToString("F2");
                    unit2.Text = "18.00 * " + allocateForP2 + " = " + (allocateForP2 * unitP2).ToString("F2");
                    unit3.Text = "30.00 * " + allocateForP3 + " = " + (allocateForP3 * unitP3).ToString("F2");
                    unit4.Text = "42.00 * " + allocateForP4 + " = " + (allocateForP4 * unitP4).ToString("F2");
                    unit5.Text = "65.00 * " + (usedUnits - (allocateForP1 + allocateForP2 + allocateForP3 + allocateForP4)) + " = " + ((usedUnits - (allocateForP1 + allocateForP2 + allocateForP3 + allocateForP4)) * unitP5).ToString("F2");
                    getFixedCharge(days,2000);
                }
            }
            netCharge.Text = "LRK. " + charge.ToString("F2");
        }

        public void getFixedCharge(int days,int monthlyCharge)
        {
            double fixedCharge = ((double)days / 30) * monthlyCharge;
            fixedCha.Text = "LKR. " + fixedCharge.ToString("F2");
        }

        private void fixedCha_Click(object sender, EventArgs e)
        {

        }
    }
}
