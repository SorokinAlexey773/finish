string[] arr1 = { "Hello", "2", "world", ":-)" };
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = { "Russia", "Denmark", "Kazan" };
int MaxLatterInWord = 3;
PrintRezult(arr1);
PrintRezult(arr2);
PrintRezult(arr3);

string[] GetLatter(string[] array)
{
    int size = array.Length;
    string[] result = new string[size];
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= MaxLatterInWord)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);

    return result;
}

void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Таких слов нет");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

void PrintRezult(string[] array)
{
    PrintArray(array);
    string[] array1 = GetLatter(array);
    Console.Write($"В данном массиве больше 3 символов ->  ");
    PrintArray(array1);
    Console.WriteLine();
}


