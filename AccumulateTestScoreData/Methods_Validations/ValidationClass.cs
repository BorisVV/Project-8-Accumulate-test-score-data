using System;
using System.Windows.Forms;

namespace AccumulateTestScoreData
{
    class ValidationClass
    {
        public static bool IsPresent_Int32_OutRange(TextBox txtBox, string name) //Out of Range Method.
        {
            int number; //var for the integer 
            //Checks for empty string.
            if (txtBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("The '" + name + "' field cannot be empty", "Empty Error.");
                txtBox.Focus();
                return false;
            }
            //Checks if it is an integer.
            else if (!Int32.TryParse(txtBox.Text, out number))
            {
                //Checks if not an integer a messaged pops.
                MessageBox.Show("The '" + name + "' field needs to be a number", "Empty Error.");
                txtBox.Text = String.Empty;
                txtBox.Focus();
                return false;
            }
            else if (number < 0 || number > 100)
            {   //Checks for out of range numbers.
                System.Windows.Forms.MessageBox.Show("The '" + name + "' field can only accept whole numbers \nBetween 1 and 100.", "Empty Error.");
                txtBox.Text = String.Empty;
                txtBox.Focus();
                return false;
            }

            return true;
        }

    }
}
