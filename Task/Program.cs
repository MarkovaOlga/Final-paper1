// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());


string[] CreateArrayString(int elem)
{
    string[] array = new string[elements];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите набор символов для {i} элемента массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}
