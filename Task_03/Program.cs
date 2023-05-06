// Напишите программу, которая будет преобразовывать десятичное число в двоичное

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int value = a;  // зачем переменная value?
int resultInt = 0;
int shift = 1;  // сдвиг по разрядам
string resultStr = ""; // либо string.Empty
while (value > 0)
{
    resultStr = (value % 2) + resultStr; // через string
    resultInt += (value % 2) * shift;  // через int
    shift *= 10;  // через int сдвиг по разрядам
    value /= 2;  // через string
}
Console.WriteLine($"Число {a} в двоичном представлении: {resultStr}");  // через string
Console.WriteLine($"Число {a} в двоичном представлении: {resultInt}");  // через int