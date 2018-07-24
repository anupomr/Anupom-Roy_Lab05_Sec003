using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anupom_Roy_Lab05_Ex01
{
    public partial class Form1 : Form
    {
        int[] intArray = new int[6];
        Double[] doubleArray = new Double[6];
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            Random rnd1 = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd1.Next(10, 50);
            }
            for (int i = 0; i < intArray.Length; i++)
            {
                result += intArray[i].ToString();
                result += ", ";
            }
            txtIntArray.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string arrayStr = "";
            Random rnd1 = new Random();
            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = Math.Round( rnd1.NextDouble(),2);
            }
            for (int i = 0; i < doubleArray.Length; i++)
            {
                arrayStr += doubleArray[i].ToString();
                arrayStr += ", ";
            }
            txtDoubleArray.Text = arrayStr;
        }
    }
}
