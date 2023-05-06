// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый -на последнем и т.д.)

int size = 12;
int[] array = new int[size];
FillArray(array);
Console.Write ("Задан массив: ");
PrintArray(array);
ReverseArray(array);
PrintArray(array);

void FillArray(int[] array, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    int HalfArray = array.Length / 2; // проще ввести переменную нежели в каждом цикле делить размер на 2
    int lastnumber = array.Length - 1;
    for (int i = 0; i < HalfArray; i++)
    {
        int temp = array[i];
        array[i] = array[lastnumber - i];
        array[lastnumber - i] = temp;
    }
    Console.Write
    ("Перевернутый массив: ");
}