// ************************************************************************************
// SAIT Class: Fall 2024 RAD for OOSD (CRPG-200-A)
// Author: Carlos Hernandez-Zelaya
// Project Title: CPRG 200 Lab Assignment 2
// ************************************************************************************
namespace EnmaxApp
{
    static public class ValidatorUtils
    {
        /// <summary>
        /// Test if there is any input from the user.(empty string)
        /// </summary>
        /// <param name="textBox">textbox to be checked</param>
        /// <returns>True if input is not empty, false if empty</returns>
        public static bool IsPresent(TextBox textBox)
        {
            bool isValid = true;
            if (textBox.Text == "") // Check if the textbox is empty
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field is empty");
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsAlphabetic(TextBox textBox)
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(textBox.Text) || !textBox.Text.All(char.IsLetter))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} field needs to be alphabetic characters only");
            }
            return isValid;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsDouble(TextBox textBox)
        {
            bool isValid = true;
            double output;
            // Tries to parse or convert text box input to decimal

            if (!double.TryParse(textBox.Text, out output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} Field contains non-numeric characters");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;
        }

        public static bool IsInInches(TextBox textBox)
        {
            bool isValid = true;
            int value;

            if (int.TryParse(textBox.Text, out value))
            {
                if (value < 0 || value > 12) //Check to see if the value is equal to 0 or greater than 12
                {
                    isValid = false;
                    MessageBox.Show($"{textBox.Tag} Field must be between 0 and 12 inches");
                    textBox.SelectAll();
                    textBox.Focus();
                }
            }
            return isValid;
        }


        public static bool IsNonNegative(TextBox textBox)
        {
            bool isValid = true;
            //double output
            //tries to parse or convert text box input to decimal
            if (!double.TryParse(textBox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} Field contains non-numeric characters");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (output < 0)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} Field must be a non-negative number");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;





        }

        public static bool isDoubleInRange(TextBox textBox, double min, double max)
        {
            bool isValid = true;
            //double output
            //tries to parse or convert text box input to decimal
            if (!double.TryParse(textBox.Text, out double output))
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} Field contains non-numeric characters");
                textBox.SelectAll();
                textBox.Focus();
            }
            else if (output < 0)
            {
                isValid = false;
                MessageBox.Show($"{textBox.Tag} Field must be within the range of {min} and {max}");
                textBox.SelectAll();
                textBox.Focus();
            }
            return isValid;





        }

    }

}