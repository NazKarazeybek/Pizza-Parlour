using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class Form1 : Form
    { 
        double slicePrice = 3.25;
        int numOfSlices = 0;
        double taxRate = 0.13;
        double subTotal = 0;
        double taxAmount = 0;
        double totalPrice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)   
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numOfSlices = Convert.ToInt32(slicesInput.Text);

                subTotal = slicePrice * numOfSlices;
                taxAmount = subTotal * taxRate;
                totalPrice = subTotal + taxAmount;


                subTotalOutput.Text = $" {subTotal.ToString(".00")}";
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                totalOutput.Text = $"{totalPrice.ToString("C")}";


            }
            catch
            {
                subTotalOutput.Text = "ERROR";
                taxOutput.Text = "";
                totalOutput.Text = "";

            }
        }
    }
}