﻿using DataStructures.SortedList;

// Data Structures => SortedList


/* KEY-VALUE PAIR
  
    1 -> "One"
    1 -> "NeOne" // Throws an exception
    2 -> "Two"
    3 -> "Three"

 */



CustomSortedList<int, string> list = new(6)
{
    { 3, "three" },
    { 2, "two" },
    { 4, "four" },
    { 1, "one" }
};

list.Remove(3);
list.Add(0, "fife");
list.Add(5, "six");
list.Add(6, "seven");
list.Add(7, "eight");
//list.Add(3, "NewThree");

foreach (var item in list)
{
    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
}



Console.ReadLine();
