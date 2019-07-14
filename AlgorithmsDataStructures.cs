using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    public class Node
    {
        public int value;
        public Node next;
        public Node(int _value) { value = _value; }
    }

    public class LinkedList
    {
        public Node head;
        public Node tail;

        public LinkedList()
        {
            head = null;
            tail = null;
        }

        public void AddInTail(Node _item)
        {
            if (head == null) head = _item;
            else tail.next = _item;
            tail = _item;
        }

        public Node Find(int _value)
        {
            Node node = head;
            while (node != null)
            {
                if (node.value == _value) return node;
                node = node.next;
            }
            return null;
        }

        public List<Node> FindAll(int _value)
        {
            List<Node> nodes = new List<Node>();
            // здесь будет ваш код поиска всех узлов по заданному значению
            Node node = head;
            while (node != null)
            {
                if (node.value == _value)
                {
                    nodes.Add(node); // если узел найден по значению, добавляем значение узла к списку
                }
                node = node.next;
            }
            return nodes; // возвращаем список
        }

        public bool Remove(int _value)
        {
            // здесь будет ваш код удаления одного узла по заданному значению
            Node previous = null;
            Node current = head;

            while (current != null)
            {
                if (current.value == _value)
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                        if (current.next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.next;
                        if (head == null)
                        {
                            tail = null;
                        }
                    }
                    return true; // если узел был удален
                }
                previous = current;
                current = current.next;
            }
            
            return false; // если узел не был удален
        }

        public void RemoveAll(int _value)
        {
            // здесь будет ваш код удаления всех узлов по заданному значению
            Node previous = null;
            Node current = head;

            while (current != null)
            {
                if(current.value == _value)
                {
                    if (previous != null)
                    {
                        previous.next = current.next;
                    }
                    else
                    {
                        head = head.next;
                    }
                    if (current.next == null)
                    {
                        tail = previous;
                    }
                }
                else
                {
                    previous = current;
                    
                }
                current = current.next;
            }
        }

        public void Clear()
        {
            // здесь будет ваш код очистки всего списка
            head = null;
            tail = null;
        }

        public int Count()
        {
            Node node = head;
            int count = 0;
            while (node != null)
            {
                count += 1;
                node = node.next;
            }
            return count; // здесь будет ваш код подсчёта количества элементов в списке
        }

        public void InsertAfter(Node _nodeAfter, Node _nodeToInsert)
        {
            // здесь будет ваш код вставки узла после заданного

            // если _nodeAfter = null и список пустой, 
            // добавьте новый элемент первым в списке
            Node node = head;
            while (node != null)
            {
                if (head.value == _nodeAfter.value && tail.value == _nodeAfter.value)
                {
                    head.next = _nodeToInsert;
                    tail = _nodeToInsert;
                    break;
                }
                else if (head.value == _nodeAfter.value)
                {
                    _nodeToInsert.next = head.next;
                    head.next = _nodeToInsert;
                    break;
                }
                else if (tail.value == _nodeAfter.value)
                {
                    tail.next = _nodeToInsert;
                    break;
                }
                else if (node.value == _nodeAfter.value)
                {
                    _nodeToInsert.next = node.next;
                    node.next = _nodeToInsert;
                    break;
                }
                node = node.next;
            }
            if (head == null && _nodeAfter == null)
            {
                head = _nodeToInsert;
                tail = _nodeToInsert;
            }
        }

        public void PrintNode()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
            if (head == null) Console.WriteLine("Список пуст");
        }
        public List<int> ListToInt()
        {
            Node node = head;
            List<int> listToInt = new List<int>();
            while (node != null)
            {
                listToInt.Add(node.value);
                node = node.next;
            }
            return listToInt;
        }
    }
}