using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorthmsPractises
{
    internal class Trie
    {
        public bool IsEndOfWord { get; set; }
        public Dictionary<char, Trie> Children { get; set; } = new();
        public void Add(string word)
        {
            Trie current = this;
            foreach (var c in word) {
            if(!current.Children.TryGetValue(c, out var child))
                {
                    child = new Trie();
                    current.Children.Add(c,child);
                }
            current = child;

            }
            current.IsEndOfWord = true;
        }

        public bool Contains(string word)
        {
            Trie current = this;
            foreach (var c in word)
            {
                if(!current.Children.TryGetValue(c,out var child))
                    return false;

                current = child;
            }
            return false;
        }

        public void Print(int space =0) => Print(this , space);
        public void Print(Trie trie , int space = 0)
        {
            trie ??= this;
            static void PrintSingleNode(char word , int space = 0 , bool  isEndOfWord = false) 
            {
                string spaces = new string(' ', space);
                if (space > 0)
                    Console.WriteLine(new string(' ', space));

                Console.ForegroundColor = space == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine($"-> {spaces}{word}{(isEndOfWord ? "(*)" : "")}");

            }

            foreach (var entry in trie.Children)
            {
                PrintSingleNode(entry.Key , space,entry.Value.IsEndOfWord);
                Print(entry.Value, space + 3);
            }
        }
    }
}
