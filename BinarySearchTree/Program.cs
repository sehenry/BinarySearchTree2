using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree test = new Tree();
            test.Add(72);
            test.Add(13);
            test.Add(2);
            test.Add(89);
            test.Add(11);

            Console.ReadLine();

            Tree testSearch = new Tree();
            testSearch.Search(72);

            Console.ReadLine();
        }
    }
}
