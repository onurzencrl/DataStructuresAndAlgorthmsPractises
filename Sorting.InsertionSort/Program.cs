// Sıralama Algoritmaları - Insertion Sort(Baloncuk Sıralaması)
// teorik defterde;

int[] numbers = { 5, 2, 7, 9, 1, 0, 3, 4, 10 };
string[] names = { "Ali", "Ayşe", "Fatma", "Veli" };

InsertionSort(numbers);
InsertionSort(names);

Console.WriteLine(string.Join(",", numbers));
Console.WriteLine(string.Join(",", names));

void InsertionSort<T>(T[] array) where T : IComparable
{
    for (int i = 0; i < array.Length; i++)
    {
        T key = array[i];
        int j = i - 1;

        while (j >= 0 && array[j].CompareTo(key) > 0)
        {
            array[j + 1] = array[j];
            j--;
        }

        array[j + 1] = key;
    }
}