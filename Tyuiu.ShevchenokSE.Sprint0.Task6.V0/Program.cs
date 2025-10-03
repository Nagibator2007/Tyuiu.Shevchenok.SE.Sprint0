using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShevchenokSE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ShevchenokSE.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Summ of elements equals " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Summ of elements equals " + DataService.SubstractionArray(numsArray));
            Console.WriteLine("Summ of elements equals " + DataService.MultiplicationArray(numsArray));
            Console.ReadKey();
        }
    }
}
