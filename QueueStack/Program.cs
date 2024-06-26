﻿
// Data Structures => Queue & Stack
//                    FIFO - LIFO

/*
 
Queue (Kuyruk) Örnekleri:
Fast Food Restoranı, Yazıcı Kuyruğu, Call Center



Stack (Yığın) Örnekleri:
Web Tarayıcı Geçmişi, Program Çağrı Yığını Kitaplar (Fiziksel)

*/


using DataStructures.QueueStack;

MyQueue<int> queue = new();

queue.Enqueue(1);
queue.Enqueue(4);
queue.Enqueue(7);
queue.Enqueue(2);
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());





MyStack<string> stack = new();

stack.Push("A");
stack.Push("B");
stack.Push("C");

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());







//MyQueue<int> queue = new(100);

//foreach (var item in Enumerable.Range(0, 99))
//{
//    queue.Enqueue(item);
//}

//for (int i = 0; i < 75; i++)
//{
//    queue.Dequeue();
//}

Console.ReadLine();