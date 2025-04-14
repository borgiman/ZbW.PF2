using MB13.SinglyLinkedListExample;
using MB13.StackLinkedList;

// ------------------------
//        LinkedList
// ------------------------

var singlyLinkedList = new SinglyLinkedList();

// Aufgabe 1
singlyLinkedList.Add("aaa");
singlyLinkedList.Add("bbb");
singlyLinkedList.Add("ccc");
var cnt1 = singlyLinkedList.Count;

// Aufgabe 2
var c = singlyLinkedList.Contains("bb");

// Aufgabe 3
singlyLinkedList.Remove("ccc");

// Aufgabe 4
var o = singlyLinkedList.FindByIndex(1);

// Aufgabe 5
var x = singlyLinkedList[1];
singlyLinkedList[1] = "xyz";

Console.ReadLine();

// ------------------------
//          Stack
// ------------------------

var stackLinkedList = new StackLinkedList();

stackLinkedList.Push("aaa");
stackLinkedList.Push("bbb");
var cnt2 = stackLinkedList.Count;
var pop = stackLinkedList.Pop();
var peek = stackLinkedList.Peek();
