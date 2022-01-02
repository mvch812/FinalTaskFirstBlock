// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. При решении не
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void FillArray(int[] Array) // метод, заполняющий массив случайными целыми числами от -100 до 99
{
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(-100, 100); 
    }
}

string PrintArray(int[] Array)  // метод печатающий массив в строковую переменную
{
    string print = string.Empty;
    for (int i = 0; i < Array.Length; i++)
    {
        print = print + Array[i] + ' ';
    }
    return print;
}


int[] ArrayEvenNumbers(int[] Array) // метод, создающий массив четных чисел из элементов входящего массива
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            count++;
        }
    }
    int[] EvenNumbers = new int[count];
    int indexEN = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        {
            EvenNumbers[indexEN] = Array[i];
            indexEN++;
        }
    }
    return EvenNumbers;
}

int[] Array = new int[20];
FillArray(Array);

Console.WriteLine();
Console.WriteLine($"Массив случайных целых чисел:");
Console.Write(PrintArray(Array)); 

Console.WriteLine();
Console.WriteLine($"Массив четных чисел:");
Console.WriteLine(PrintArray(ArrayEvenNumbers(Array)));

