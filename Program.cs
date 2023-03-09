string[] NoMoreThreeSymbols(string[] array) 
{
    int arrayLength = 0; 
    foreach (string p in array) //определение длины результирующего массива
    {
        if (p.Length < 4) arrayLength++;
    }
    string[] result = new string[arrayLength];
    int i = 0; // счетчик для результирующего массива
    foreach (string p in array) //перенос в новый массив слов из не более 3 символов
    {
        if (p.Length < 4)
        {
            result[i] = p;
            i++;
        }
    }
    return result;
}

void PrintArray(string[] inArray) //метод вывода массива строк в консоль
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Напишите слова через пробел");
string input = Console.ReadLine();
string[] array = input.Split(' ');
PrintArray(NoMoreThreeSymbols(array));