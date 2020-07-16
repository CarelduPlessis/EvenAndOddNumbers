using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenAndOddNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}; // list of numbers

            int result = 0;
            for (int i = 0; i < numbers.Length; i++) {

                result = numbers[i] % 2; // working out if its odd or even
               
                if (result == 0) // check the result to find out if its odd or even
                { 
                    DisplayList.Items.Add("Even" + " " + numbers[i]);
                }
                else {
                    DisplayList.Items.Add("Odd" + " " + numbers[i]);
                }
            }
        }
    }
}
