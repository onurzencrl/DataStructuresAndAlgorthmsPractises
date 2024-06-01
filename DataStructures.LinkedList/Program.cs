using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using DataStructures.LinkedList;

// Data Structures => LinkedList
 var config = new ManualConfig()
        .WithOptions(ConfigOptions.DisableOptimizationsValidator)
        .AddValidator(JitOptimizationsValidator.DontFailOnError)
        .AddLogger(ConsoleLogger.Default)
        .AddColumnProvider(DefaultColumnProviders.Instance);

BenchmarkRunner.Run<CustomLinkedListBenchmarks_ADD>(config);

return;

CustomLinkedList<int> list = new();

list.AddFirst(1);
list.AddLast(2);
list.AddLast(new[] { 3, 4, 5 });
list.AddMiddle(0);

Print();

list.RemoveFirst();
Print();

Console.ReadLine();






void Print()
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
}


//there are three types of linked list 
// the first one is Single linked list now lets talk about single linked list.
// the navigation of single linked list is forward only.
// there is no turning back.
// a single linked list is a list made up of nodes that consists of two parst
// Data - Link
// how to acceess the first linked list 
// we need to a head.


// The second one is Doubly Linked List 
// Forward and backward navigation is possible.

// and the third one is Circular linked list.
// Last element is linked to the first element.
