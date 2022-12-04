/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

void StringArray(string[] strArray)
{
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"Введите с клавиатуры значение {i + 1} элемента массива, нажав после ввода клавишу ENTER:   ");
        strArray[i] = Console.ReadLine()!;
    }

    Console.WriteLine($"\nПолучен следующий одномерный массив строк:");

    Console.Write("[ ");
    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write(strArray[i]);
        if (i != strArray.Length - 1)
        {
            Console.Write(" ,  ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}

void NewStringArray(string[] strArray, int countSimbol)
{
    string[] strArray1 = new string[strArray.Length];
    int j = 0;

    for (int i = 0; i < strArray.Length; i++)
    {
        if (strArray[i].Length <= countSimbol)
        {
            strArray1[j] = strArray[i];
            //Console.Write(strArray1[j] + "   ");
            j++;
        }

    }
    //Console.WriteLine("j= " + j);

    string[] newStrArray = new string[j];
    int k = 0;
    for (int i = 0; i < newStrArray.Length; i++)
    {
        if (strArray1[k] != "")
        {
            newStrArray[i] = strArray1[k];
            k++;
        }
    }

    Console.WriteLine($"\nНовый массив, состоящий из элементов, длина которых меньше либо равна {countSimbol} символа:");

    Console.Write("[ ");
    for (int i = 0; i < newStrArray.Length; i++)
    {
        Console.Write(newStrArray[i]);
        if (i != newStrArray.Length - 1)
        {
            Console.Write(" ,  ");
        }
    }
    Console.Write(" ]");
    Console.WriteLine();
}

Console.Write("Введите количество элементов в одномерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
string[] strArray = new string[m];
StringArray(strArray);
Console.Write("\nВведите предельное количество символов, которое может содержаться  в элементе нового массива:    ");

int countSimbol = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < strArray.Length; i++)
{
    if (strArray[i].Length > countSimbol)
    {
        count++;
    }
}
if (count == strArray.Length)
{
    Console.Write($"\nЭлементы в массиве с количеством символов {countSimbol} и менее отсутствуют.");
}
else
{
    NewStringArray(strArray, countSimbol);
}
Console.WriteLine();
