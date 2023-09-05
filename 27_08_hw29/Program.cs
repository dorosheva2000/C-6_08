/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Write("Please input array size: ");
int S = int.Parse(Console.ReadLine()!);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array)
{
    Console.WriteLine("Please input arrae elements!");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);    
    }
}

void Printarray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i ++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length-1] + "]");
}

int[] my_arr = CreateArray(S);
FillArray(my_arr);
Printarray(my_arr);
