// Задача 29 Напишите программу, которая задает массив из 8 элементов и вывыодит их на экран

int[] array = new int[8];

void consoleMassiv (int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}


void Random (int [] ran)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

Random(array);
consoleMassiv(array);
