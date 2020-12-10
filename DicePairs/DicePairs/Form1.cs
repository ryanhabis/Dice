using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicePairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
            Random randomnum = new Random();
            int num1 = 0, num2 = 0, matches = 0;
            for (int i = 0; i < 6; i++)
            {
                num1 = randomnum.Next(1, 7);
                num2 = randomnum.Next(1, 7);

                lstBox.Items.Add(num1 + "\t" + num2);
                   if (num1 == num2)
                    matches = matches + 1;
            }

            lstBox.Items.Add("No of matches: " + matches);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();

            Random randomnum = new Random();
            int dice = 0, x = 0, num1 = 0, num2=0, num3 = 0, num4 = 0, num5 = 0, num6 = 0;

            while (x < 1000)
            {
                dice = randomnum.Next(1, 7);
              
                if (dice == 1)
                {
                    num1 = num1 + 1;
                }
                else if (dice == 2)
                {
                    num2 = num2 + 1;
                }
                else if (dice == 3)
                {
                    num3 = num3 + 1;
                }
                else if (dice == 4)
                {
                    num4 = num4+ 1;
                }
                else if (dice == 5)
                {
                    num5 = num5+1;
                }
                else if (dice == 6)
                {
                    num6 = num6+1;
                }
                else
                { 
                    MessageBox.Show("No Dice");
                }

                x = x + 1;

            }

            lstBox.Items.Add("Number 1 " + "\t" + num1.ToString());
            lstBox.Items.Add("Number 2 " + "\t" + num2.ToString());
            lstBox.Items.Add("Number 3 " + "\t"+ num3.ToString());
            lstBox.Items.Add("Number 4 " + "\t" + num4.ToString());
            lstBox.Items.Add("Number 5 " + "\t" + num5.ToString());
            lstBox.Items.Add("Number 6 " + "\t" + num6.ToString());

        }

        private void BtnArray_Click(object sender, EventArgs e)
        {

            int[] dice = new int[7];
            int number = 0;
            Random rand = new Random();
            lstBox.Items.Clear();
            for (int i = 0; i<10; i++)
            {
                number = rand.Next(1, 7);
                dice[number] = dice[number] + 1;
            }

            for (int x = 1; x < dice.Length; x++)
            {
                lstBox.Items.Add("Dice number = " + x + " landed " + dice[x].ToString() + " times");
            }
            lstBox.Items.Add("Sum of the elements are = " + dice.Sum());
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}