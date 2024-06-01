// Sıralama Algoritmaları - Bubble Sort(Baloncuk Sıralaması)
// teorik defterde;

int[] numbers = { 5, 2, 7, 9, 1, 0, 3, 4, 10 };
string[] names = { "Ali", "Ayşe", "Fatma", "Veli" };

BubbleSort(numbers);
BubbleSort(names);

Console.WriteLine(string.Join(",", numbers));
Console.WriteLine(string.Join(",", names));

void BubbleSort<T>(T[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (Comparer<T>.Default.Compare(array[j], array[j+1]) > 0)
            {
                var temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }
}