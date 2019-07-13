using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class Test
    {
        public static void TestRemove()
        {
            Console.WriteLine("Удаление одного элемента");
            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(10));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(20));
            Console.WriteLine("Начальное состояние списка");
            s_list.PrintNode();

            s_list.Remove(10);
            Console.WriteLine("Удаляем элемент 10");
            s_list.PrintNode();
        }

        public static void TestRemoveAll()
        {
            Console.WriteLine("Удаление всех элементов по значению");
            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(7));
            s_list.AddInTail(new Node(8));
            s_list.AddInTail(new Node(9));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(11));
            s_list.AddInTail(new Node(12));
            s_list.AddInTail(new Node(13));
            s_list.AddInTail(new Node(5));
            Console.WriteLine("Начальное состояние списка");
            s_list.PrintNode();

            s_list.RemoveAll(5);
            Console.WriteLine("Удаляем все элементы со значением 5");
            s_list.PrintNode();
        }

        public static void TestClear()
        {
            Console.WriteLine("Очистка списка");
            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(10));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(20));
            Console.WriteLine("Начальное состояние списка");
            s_list.PrintNode();

            s_list.Clear();
            Console.WriteLine("Очистили список");
            s_list.PrintNode();
        }

        public static void TestFindAll()
        {
            Console.WriteLine("Поиск всех элементов по значению");
            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(10));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(20));
            Console.WriteLine("Начальное состояние списка");
            s_list.PrintNode();

            Console.WriteLine("Находим все элементы со значением 5 и выводим на экран");
            List<Node> result = s_list.FindAll(5);
            int count = result.Count() - 1;
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine(result[i].value + " ");
            }
        }

        public static void TestCount()
        {
            Console.WriteLine("Подсчет количества элементов в списке");
            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(10));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(20));
            Console.WriteLine("Начальное состояние списка");
            s_list.PrintNode();

            Console.WriteLine("Количество элементов в списке равно ");
            Console.WriteLine(s_list.Count());
        }

        public static void TestInsertAfter()
        {
            Console.WriteLine("Вставка узла после заданного узла");
            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(1));
            s_list.AddInTail(new Node(3));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(7));
            s_list.AddInTail(new Node(9));
            Console.WriteLine("Начальное состояние списка");
            s_list.PrintNode();

            Console.WriteLine("Вставляем элемент 2 после первого");
            s_list.InsertAfter(new Node(1), new Node(2));
            s_list.PrintNode();

            Console.WriteLine("Вставляем элемент 4 после третьего");
            s_list.InsertAfter(new Node(3), new Node(4));
            s_list.PrintNode();

            Console.WriteLine("Вставляем элемент 6 после пятого");
            s_list.InsertAfter(new Node(5), new Node(6));
            s_list.PrintNode();

            Console.WriteLine("Вставляем элемент 8 после седьмого");
            s_list.InsertAfter(new Node(7), new Node(8));
            s_list.PrintNode();

            LinkedList s_list_empty = new LinkedList();
            Console.WriteLine("Вставляем элемент 5 в пустой список");
            s_list_empty.InsertAfter(new Node(3), new Node(5));
            Console.WriteLine("Вставка в пустой список. Добавляем элемент как первый в списке.");
            s_list_empty.PrintNode();
        }
    }
}
