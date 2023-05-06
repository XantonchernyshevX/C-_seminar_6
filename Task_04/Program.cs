// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

void Task04()
{
    int f = 0;
    int s = 1;
    int count = Convert.ToInt32(Input("Количество элементов последовательности: "));
    for (int i = 0; i < count; i++)
    {
System.Console.WriteLine($"(f)" );
    }
}
Task04();

string Input(string text)
{
    Console.Write($"{text}");
    return Console.ReadLine();
}