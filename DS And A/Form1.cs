using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_And_A
{
    public partial class Form1 : Form
    {
    //Bubble sort
    
        public Form1()
        {
            InitializeComponent();

            //int[] valsBalls = new int[6] { 10, 2, 8, 6, 7, 3 };
            int[] valsBalls = new int[6] { 10, 2, 3, 4, 5, 7 };
            List<int> Balls = new List<int>(valsBalls);

            //Sorter Sorter = new Sorter(this);
            //Sorter.InsertionSort(Balls);
            //Sorter.PrintArray(Balls);

            DoublyLinkedList List = new DoublyLinkedList();
            List.InsertAtHead(1);
            List.InsertAtHead(40);
            List.InsertAtHead(3);
            List.InsertAtHead(2);
            List.InsertAtHead(5);

           // List.InsertByValue(36);

            Console.WriteLine(List.ToString());
            List.InsertionSortDList();

            Console.WriteLine(List.ToString());



        }
        public void AppendToOutput(String text)
        {
            output.Text += text;
        }

    }
}
