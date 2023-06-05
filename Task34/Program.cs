// задать массив, заполненный случайными положительными трехзначными числами.
// напичать программу, которая покажет количество чётных чисел в массиве

Console.WriteLine("Введите количество цифр для массива:");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = GenArray(len);
int[] GenArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(String.Join(", ", array));
    return array;
}
int countEl=0;
for (int i = 0; i < len; i++)
{
    if (array[i] % 2 == 0)
    {
    countEl++;
    }
}
Console.WriteLine($"Количество четных чисел: {countEl}");

