using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}
