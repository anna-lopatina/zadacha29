// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] ElementsArray(string input)
{
    string[] x = input.Split(", ");
    int len = 8;
    if(x.Length < len) 
    {
        len = x.Length;
    }
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(x[i]);
    }
    return array;
}

void PrintArray(int[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
    if (i != mass.Length - 1)
        {
            Console.Write(", ");
        }
    }  
    Console.Write("]"); 
}
Console.Clear();

Console.WriteLine("Введите ряд чисел, разделенных запятой: ");
string input = Console.ReadLine();
int[] ArrayResult = ElementsArray(input);
PrintArray(ArrayResult);
