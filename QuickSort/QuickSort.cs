using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class QuickSort : Form
    {



        public QuickSort()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            Enter_your_Array.Items.Add(x);


        }


        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr = new int[Enter_your_Array.Items.Count];
            for (int i = 0; i < Enter_your_Array.Items.Count; i++)
            {
                arr[i] = Convert.ToInt32(Enter_your_Array.Items[i]);
            }

            quickSort(arr, 0, arr.Length-1) ;




            foreach (var x in arr)
            listBox2.Items.Add(x);
            button1.Enabled = false;
            button2.Enabled = false;


        }

        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public static int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        public static void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }

      
        private void Clear_Click(object sender, EventArgs e)
        {
            Enter_your_Array.Items.Clear();
            listBox2.Items.Clear();
            button2.Enabled = true;
            button1.Enabled = true;
        }
    }

}

  

