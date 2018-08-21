using DataStructure.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            #region array
            //char[] a = new char[6] { 'a', 'b', 'a', 'd', 'a','a'};
            //Console.WriteLine("Array Before Insertion");
            //Operations.printArray<char>(a);
            //Console.WriteLine("Array After Insertion");
            //var b = Operations.removeAtIndex<char>(a, 2);
            //Operations.printArray<char>(b);
            #endregion

            #region LinkedList

            LinkedList.LinkedList lnklist = new LinkedList.LinkedList();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.addAtLast(12);
            lnklist.addAtLast("John");
            lnklist.addAtLast("Peter");
            lnklist.addAtLast(34);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.addAtStart(55);
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.removeFromStart();
            lnklist.PrintAllNodes();

            #endregion

            Console.ReadKey();
        }
    }
}
