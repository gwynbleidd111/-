void GetResult(string[] array, string[] arrayLength)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayLength[count] = array[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }    
    Console.WriteLine();
}

string[] array1 = new string[4] {"hello", "2", "world", ":-)"};
string[] arrayLength1 = new string[array1.Length];

string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arrayLength2 = new string[array1.Length];

string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] arrayLength3 = new string[array1.Length];

Console.Write("Первый массив: ");
GetResult(array1, arrayLength1);
PrintArray(arrayLength1);
Console.Write("Второй массив: ");
GetResult(array2, arrayLength2);
PrintArray(arrayLength2);
Console.Write("Третий массив: ");
GetResult(array3, arrayLength3);
PrintArray(arrayLength3);