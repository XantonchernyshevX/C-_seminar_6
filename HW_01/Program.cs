// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();

string Input(string text)
{
    Console.Write($"{text}");
    return Console.ReadLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Input($"Введите {i + 1}-е число: "));
    }
}

void PrintArray(int[] array)
{
    Console.Write("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.Write("Количество введенных чисел больше нуля: ");
    Console.WriteLine(count);
}

void HW01()
{
    int size = Convert.ToInt32(Input("Количество чисел для ввода: "));
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    PositiveNumbers(array);
}
HW01();