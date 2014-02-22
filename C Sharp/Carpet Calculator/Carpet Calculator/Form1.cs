using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpet_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
           //const for the math
            const int sq_ft_per_sq_yard = 9;
            const int inches_per_foot = 12;

            //allow for calculation fo the input box.

            string strLengthFt = textBoxLengthFt.Text.Trim();
            string strLengthIn = textBoxLengthIn.Text.Trim();
            string strWidthFt = textBoxWidthFt.Text.Trim();
            string strWidthIn = textBoxWidthIn.Text.Trim();
            string strCarpetPrice = textBoxCarpetPrice.Text.Trim();

            //int var
            int roomLengthFt,
                roomLengthIn,
                roomWidthFt,
                roomWidthIn;

            //double var
            double roomLength,
                   roomWidth,
                   numOfSqFt,
                   numOfSqYd,
                   carpetPrice,
                   totalCost;

            //bool for validation
            bool isRoomLengthFt = int.TryParse(strLengthFt, out roomLengthFt);
            bool isRoomLengthIn = int.TryParse(strLengthIn, out roomLengthIn);
            bool isRoomWidthFt = int.TryParse(strWidthFt, out roomWidthFt);
            bool isRoomWidthIn = int.TryParse(strWidthIn, out roomWidthIn);
            bool isCarpetPrice = double.TryParse(strCarpetPrice, out carpetPrice);

            //numeric validation for textboxes
            if ((isRoomLengthFt) && (isRoomLengthIn) && (isRoomWidthFt) && (isRoomWidthIn) && (isCarpetPrice))
            {
                roomLength = roomLengthFt + (double)roomLengthIn / inches_per_foot;
                roomWidth = roomWidthFt + (double)roomWidthIn / inches_per_foot;
                numOfSqFt = roomLength * roomWidth;
                numOfSqYd = numOfSqFt / sq_ft_per_sq_yard;
                totalCost = numOfSqYd * carpetPrice;

                textBoxTotal.Text = totalCost.ToString("c");
            }
            else 
            {
                MessageBox.Show("Please enter a number");
            }

            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clears selection for all text boxes
            textBoxLengthFt.Clear();
            textBoxLengthIn.Clear();
            textBoxWidthFt.Clear();
            textBoxWidthIn.Clear();
            textBoxTotal.Clear();
            textBoxCarpetPrice.Clear();

        }
    }
}
