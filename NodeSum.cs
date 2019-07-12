using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class LinkedListSum
    {
        public static LinkedList ListSum(LinkedList _list1, LinkedList _list2)
        {
            LinkedList result = new LinkedList(); ;
            int list1Count = _list1.Count();
            int list2Count = _list2.Count();


            if (list1Count == list2Count)
            {
                List<int> listInt1 = _list1.ListToInt();
                List<int> listInt2 = _list2.ListToInt();
                List<int> listInt3 = new List<int>();

                for (int i = 0; i < list1Count; i++)
                {
                    listInt3.Add(listInt1[i] + listInt2[i]);
                    int n = listInt3[i];
                    result.AddInTail(new Node(n));
                }
            }
            else
            {
                Console.WriteLine("У списков разная длина");
            }
            return result;
        }

    }
}
