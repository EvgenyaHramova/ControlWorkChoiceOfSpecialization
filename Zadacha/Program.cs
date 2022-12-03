/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.*/

void StringArray(int m)
{
    string[] strArray = new string[m];

    for (int i = 0; i < strArray.Length; i++)
    {
        Console.Write($"Введите с клавиатуры значение {i + 1} элемента массива, нажав после ввода клавишу ENTER:   ");
        strArray[i] = Console.ReadLine()!;
    }

    Console.WriteLine($"\nСгенерирован следующий одномерный массив строк:");
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

Console.Write("Введите количество элементов в одномерном массиве:  ");
int m = Convert.ToInt32(Console.ReadLine());
StringArray(m);



