// задать одномерный массив, заполненный случайными числами.
// найти сумму элементов, стоящих на нечетных позициях


Console.WriteLine("Укажите длину массива:");
int length = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    array[i] = Math.Round(random.Next(-100, 100) / 10.0, 1);
}

Console.WriteLine("Сгенерированный массив:");
foreach (double number in array)
{
    Console.WriteLine(number);
}