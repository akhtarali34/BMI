using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CalculateBMIbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the weight and height from the text boxes
                float weight = float.Parse(TextboxforWeight.Text);
                float heightInCm = float.Parse(textboxForHeight.Text);

                // Convert height from centimeters to meters
                float heightInMeters = heightInCm / 100;

                // Calculate BMI
                float bmi = weight / (heightInMeters * heightInMeters);

                // Display the result
                textBoxforBMI.Text = bmi.ToString("F2"); // Format to 2 decimal places

                // Determine BMI category
                string category;
                if (bmi < 18.5)
                {
                    category = "Underweight";
                }
                else if (bmi < 24.9)
                {
                    category = "Normal weight";
                }
                else if (bmi < 29.9)
                {
                    category = "Overweight";
                }
                else
                {
                    category = "Obesity";
                }

                // Show message box with BMI category
                MessageBox.Show($"Your calculated BMI is {bmi:F2}. You are {category}.", "BMI Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for weight and height.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxforBMI_TextChanged(object sender, EventArgs e)
        {

        }

        private void heightlabel_Click(object sender, EventArgs e)
        {

        }

        private void textboxForHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightlabel_Click(object sender, EventArgs e)
        {

        }

        private void TextboxforWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
