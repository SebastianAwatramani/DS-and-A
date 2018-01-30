using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_And_A
{
    class Sorter
    {
        private Form1 Form;
        
        public Sorter(Form1 Form)
        {
            this.Form = Form;
        }
        public void BubbleSort(List<int> Balls)
        {
            int counter = 0;
            int Store;
            for (int j = 0; j < Balls.Count - 1; j++)
            {
                for (int i = 0; i < Balls.Count - 1 - j; i++)
                {
                    if (Balls[i + 1] < Balls[i])
                    {
                        counter++;
                        Store = Balls[i + 1];
                        Balls[i + 1] = Balls[i];
                        Balls[i] = Store;
                    }
                }

            }
            Console.WriteLine(counter);
        }

        public void SelectionSort(List<int> Balls)

        {
            for (int i = 0; i < Balls.Count; i++)
            {
                int minIndex = i; //This keeps track of the element to be exchanged
                for (int j = i + 1; j < Balls.Count; j++) //We do j = i + 1 because on each iteration, we want to start one place later since the previous iterations will already have sorted those indexes
                {
                    if (Balls[j] < Balls[minIndex]) //Here we want to check if data at the j index (which will encompass everything i + 1) is smaller than the current iteration of i. 
                    {
                        minIndex = j; //Here we change the minIndex to j, which will point to the lowest value in the set at the end of the iteration. All that's left to do now is swap
                    }

                }
                int tmp = Balls[minIndex]; //Here we store, temporarily, smallest value in the set
                Balls[minIndex] = Balls[i]; //Here we move the higher value that we started with to the place where the smallest value was
                Balls[i] = tmp; //And here we move the smallest value to the current index
            }
        }


        public void InsertionSort(List<int> Balls)
        {
            //In the insertion sort, 
            int counter = 0;
            //for (int i = 1; i < Balls.Count; i++)
            //{
            //    int current = Balls[i];
            //    int j = i - 1;

            //    while(j >=0 && current < Balls[j])
            //    {
            //        counter++;
            //        Console.WriteLine("i: " + i + "\nj: " + j + "\n");
            //        SwapIndices(Balls, current, j);
            //        j = j - 1;
            //    }
            //}
            //Console.WriteLine(counter);

            for (int i = 1; i < Balls.Count; i++)
            {
                int current = Balls[i];
                int j = i - 1;

                while (j >= 0 && Balls[j] > current)
                {
                    Balls[j + 1] = Balls[j];
                    j = j - 1;
                    counter++;

                }
                Balls[j + 1] = current;
            }
            Console.WriteLine(counter);
        }

        private static void SwapIndices(List<int> Balls, int current, int j)
        {
            Balls[j + 1] = Balls[j];
            Balls[j] = current;
        }

        public void PrintArray(List<int> Balls)
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                this.Form.AppendToOutput(Balls[i].ToString() + ",");
                
            }
        }
        public void getSorted()
        {
            
        }


    }
}
