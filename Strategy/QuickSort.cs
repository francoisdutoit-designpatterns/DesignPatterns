using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }
}
