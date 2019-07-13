using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;
using System.Collections.Generic;

namespace AlgorithmsTest
{
    [TestClass]
    public class AlgorithmTest
    {
        [TestMethod]
        public void TestRemoveAll()
        {
            LinkedList expected = new LinkedList();
            expected.AddInTail(new Node(6));
            expected.AddInTail(new Node(7));
            expected.AddInTail(new Node(8));
            expected.AddInTail(new Node(9));
            expected.AddInTail(new Node(11));
            expected.AddInTail(new Node(12));
            expected.AddInTail(new Node(13));

            LinkedList s_list = new LinkedList();
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(6));
            s_list.AddInTail(new Node(7));
            s_list.AddInTail(new Node(8));
            s_list.AddInTail(new Node(9));
            s_list.AddInTail(new Node(5));
            s_list.AddInTail(new Node(11));
            s_list.AddInTail(new Node(12));
            s_list.AddInTail(new Node(13));
            s_list.AddInTail(new Node(5));

            s_list.RemoveAll(5);

            Assert.AreEqual(expected.head.value, s_list.head.value);
            Assert.AreEqual(expected.head.next.value, s_list.head.next.value);
            Assert.AreEqual(expected.head.next.next.value, s_list.head.next.next.value);
            Assert.AreEqual(expected.head.next.next.next.value, s_list.head.next.next.next.value);
            Assert.AreEqual(expected.head.next.next.next.next.value, s_list.head.next.next.next.next.value);
            Assert.AreEqual(expected.head.next.next.next.next.next.value, s_list.head.next.next.next.next.next.value);
            Assert.AreEqual(expected.tail.value, s_list.tail.value);
            //Assert.AreEqual(expected.head.next.value, s_list.head.next.value);
            //Assert.AreEqual(expected.tail.value, s_list.tail.value);
        }
    }
}
