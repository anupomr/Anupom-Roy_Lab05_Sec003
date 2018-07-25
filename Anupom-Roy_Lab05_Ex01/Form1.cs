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
        int[] intArray = new int[7];
        
        Double[] doubleArray = new Double[6];
        int returnValue=0;
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
        public  int Search<T>(List<T> list, T searchItem) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (searchItem.CompareTo(list[i]) == 0)
                { return i; }
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (rbIntegerArray.Checked == true)
            {
                int searchItem = Convert.ToInt32(txtSearch.Text);

                List<int> intList = new List<int>();
                foreach (var item in intArray)
                {
                    intList.Add(item);
                }                
                int r = Search(intList, searchItem);
                if (r < 0)
                {
                    txtResult.Text = $"Number Not found ";
                }
                else
                {
                    txtResult.Text = $"Number  found !! at {r} index of the Array";
                }                   
            }
            if (rbDoubleArray.Checked == true)
            {
                Double searchItem = Convert.ToDouble(txtSearch.Text);

                List<Double> doubleList = new List<Double>();
                foreach (var item in doubleArray)
                {
                    doubleList.Add(item);
                }
                int r = Search(doubleList, searchItem);
                if (r < 0)
                {
                    txtResult.Text = $"Number Not found ";
                }
                else
                {
                    txtResult.Text = $"Number  found !! at {r} index of the Array";
                }
            }

        }
    }
}
