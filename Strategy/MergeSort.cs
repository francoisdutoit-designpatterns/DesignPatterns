using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}
