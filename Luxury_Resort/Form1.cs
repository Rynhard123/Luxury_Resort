//35244119, van der Merwe, P.R
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luxury_Resort
{
    public partial class frmMain : Form
    {
        const double CHARGEPERDAY = 550;
        public frmMain()
        {
            InitializeComponent();
        }

        private  double CalcStayCharges (int days)
        {
            double result = 0;
            result = days * CHARGEPERDAY;
            return result;
        }

        private double CalcMiscCharges (double food, double spa, double car, double medical)
        {
            double result;
            result = food + spa + car + medical;
            return result;
        }

        private double CalcTotalCharges (double stay, double misc)
        {
            double result;
            result = stay + misc;
            return result;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int days;
            double charges,misc, food, spa, car,medical, total;

            days = int.Parse(txtbxDays.Text);
            food = double.Parse(txtbxRestaurant.Text);
            spa = double.Parse(txtbxSpa.Text);
            car = double.Parse(txtbxCar.Text);
            medical = double.Parse(txtbxMedical.Text);

            charges = CalcStayCharges(days);
            misc = CalcMiscCharges(food, spa, car, medical);
            total = CalcTotalCharges(charges, misc);

            lstbxOutput.Items.Add("Stay Charges: " + charges.ToString("C"));
            lstbxOutput.Items.Add("Total Miscellaneous charges: " + misc.ToString("C"));
            lstbxOutput.Items.Add("Total charges: " + total.ToString("C"));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
