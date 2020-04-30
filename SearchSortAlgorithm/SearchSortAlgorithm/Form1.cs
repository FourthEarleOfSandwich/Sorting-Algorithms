using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchSortAlgorithm
{
    public partial class Form1 : Form
    {
        int[] IntArray;
        const int MAX = 10;
        int[] SortedArray = { 1, 2, 3, 4, 5 };
            
    public Form1()
        {
            InitializeComponent();
            
            //int start2 = random.Next(0, 100);
            //Generate();

        }

        private void Generate()
        {
            Random random = new Random();
            IntArray = new int[MAX];

            for (int ii = 0; ii < MAX; ii++)
            {
                IntArray[ii] = random.Next(0, 100);
            }
        }

        //Binary Search
        public int BinarySearch(int[] sortedarray, int selectedNumber)
        {
            int low = 0;
            int high = sortedarray.Length - 1;
            while(true)
            {
                
                int middle = (low + high) / 2;
                if(sortedarray[middle] == selectedNumber)
                {
                    return middle;
                }
                else if(sortedarray[middle] < selectedNumber)
                {
                    low = middle + 1;
                }
                else if(sortedarray[middle] > selectedNumber)
                {
                    high = middle - 1;
                }
                if(high < low)
                {
                    return -1;
                }
            }
        }

        public void MergeSort(int[] unsortedarray, int startindex, int endindex)
        {
            if (startindex == endindex)
            {
                return;
            }
            int middle = (startindex + endindex) / 2;
            MergeSort(unsortedarray, startindex, middle);
            MergeSort(unsortedarray, middle + 1, endindex);
            Merge(unsortedarray, startindex, endindex, middle);
        }

        private static void Merge(int[] items, int startindex, int endindex, int middle)
        {
            int temp;

            for (int ii = middle + 1; ii <= endindex; ii++)
            {

                for (int jj = ii - 1; jj >= startindex; jj--)
                {
                    if (items[jj] > items[jj + 1])
                    {
                        temp = items[jj];
                        items[jj] = items[jj + 1];
                        items[jj + 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }

            }
        }
         private static void InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            
        }
        private static void SelectionSort(int[] data)
        {
            int temp;
            int smallest;
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }
                
                temp = data[i];
                data[i] = data[smallest];
                data[smallest] = temp;
            }

        }

        private void button_MergeSort_Click(object sender, EventArgs e)
        {
            Generate();
            label_Output.Text = "Unsorted ";
            foreach (int j in IntArray)
            {
                label_Output.Text += j.ToString() + ", ";
            }
            MergeSort(IntArray, 0, MAX-1);
            label_Output.Text += "Sorted ";
            foreach (int j in IntArray)
            {
                label_Output.Text += j.ToString() + ", ";
            }
            
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            int value = 5;
            label_Output.Text = "Number " + value.ToString() + " is at index ";
           label_Output.Text += BinarySearch(SortedArray, value).ToString();
        }

        private void button_SelectionSort_Click(object sender, EventArgs e)
        {
            Generate();
            label_Output.Text = "Unsorted ";
            foreach (int j in IntArray)
            {
                label_Output.Text += j.ToString() + ", ";
            }
            SelectionSort(IntArray);
            label_Output.Text += "Sorted ";
            foreach (int j in IntArray)
            {
                label_Output.Text += j.ToString() + ", ";
            }

        }
        private void button_InsertionSort_Click(object sender, EventArgs e)
        {
            Generate();
            label_Output.Text = "Unsorted ";
            foreach (int j in IntArray)
            {
                label_Output.Text += j.ToString() + ", ";
            }
            InsertionSort(IntArray);
            label_Output.Text += "Sorted ";
            foreach (int j in IntArray)
            {
                label_Output.Text += j.ToString() + ", ";
            }

        }
    }

        
}
    

