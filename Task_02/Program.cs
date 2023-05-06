// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.Write("Введите первое число: ");
// int a = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int b = int.Parse(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a < (b + c) && b < (a + c) && c < (a + b)) Console.WriteLine("Треугольник может существовать");
// else Console.WriteLine("Треугольник не может существовать");

void Task02()
{
    int a = Convert.ToInt32(Input("Введите сторону а: "));
    int b = Convert.ToInt32(Input("Введите сторону b: "));
    int c = Convert.ToInt32(Input("Введите сторону c: "));

    if (SideCheck(a, b, c))
        Console.WriteLine("Треугольник может существовать");
    else
        Console.WriteLine("Треугольник не может существовать");
}
Task02();

string Input(string text)
{
    Console.Write($"{text}");
    return Console.ReadLine();
}

bool SideCheck(int a, int b, int c)
{
    return (a < (b + c) && b < (a + c) && c < (a + b));
}