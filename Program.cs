using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //You have two arrays/lists as follows
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };
            //a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.


            var InnerList = (from l1 in list1
                         join l2 in list2 on l1 equals l2
                         select l2
                         ).ToList();

            Console.WriteLine(string.Join(" ", InnerList));
            ////b. Show the elements from list 1, but is not found in list2. E.g 1 2"
            Console.WriteLine(string.Join(" ", list1.Except(list2).ToList()));

            ////c. Complete here
            ////Show the elements from list 2, but is not found in list1. E.g 6 7"
            Console.WriteLine(string.Join(" ", list2.Except(list1).ToList()));
            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }

    }
}

