// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длинна которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
string[] newarray = CreateArrayString(elements);
PrintArray(newarray);
int maxelem = 3;
string[] newarray2 = ChooseMaxElemSymb(newarray, maxelem);
PrintArray(newarray2);


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

string[] ChooseMaxElemSymb(string[] array, int maxel)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxel) count++;
    }
    string[] array2 = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxel)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

