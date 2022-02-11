using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalProjectBrodnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myButton_Click(object sender, EventArgs e)
        {
            //variables needed for user input
            decimal savings;
            decimal retirement;
            decimal carValue;
            decimal homeValue;
            decimal studLoans;
            decimal mortgage;
            decimal carLoans;

            //variables needed for calculation
            decimal assets;
            decimal liabilities;
            decimal netWorth;

            //converts text to numeric value
            //validates data
            try
            {
                savings = decimal.Parse(myTxtBoxSavings.Text);
                retirement = decimal.Parse(myTxtBoxRetirement.Text);
                carValue = decimal.Parse(myTxtBoxCar.Text);
                homeValue = decimal.Parse(myTxtBoxHome.Text);
                studLoans = decimal.Parse(myTxtBoxStudLoans.Text);
                mortgage = decimal.Parse(myTxtBoxMortgage.Text);
                carLoans = decimal.Parse(myTxtBoxCarLoans.Text);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers in the boxes.");
                return;
            }
           
            //calculations
            assets = savings + retirement + carValue + homeValue;
            liabilities = studLoans + mortgage + carLoans;
            netWorth = assets - liabilities;
            //show total assets and liabilities
            myLblAssets.Text = assets.ToString();
            myLblLiabilities.Text = liabilities.ToString();

            //show net worth
            myAnsLblNetWorth.Text = netWorth.ToString();

        }

        private void myClearButton_Click(object sender, EventArgs e)
        {
            //Clears data on the form.
            myAnsLblNetWorth.Text = "";
            myLblAssets.Text = "";
            myLblLiabilities.Text = "";
            myTxtBoxCar.Text = "";
            myTxtBoxCarLoans.Text = "";
            myTxtBoxHome.Text = "";
            myTxtBoxMortgage.Text = "";
            myTxtBoxRetirement.Text = "";
            myTxtBoxSavings.Text = "";
            myTxtBoxStudLoans.Text = "";
           

        }
    }
}
