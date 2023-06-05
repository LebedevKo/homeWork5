// задайте массив вещественных чисел.
// найдите разницу между максимальным и минимальным элементов массива

Console.WriteLine("Укажите длину массива:");
int length = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 100000);
    array[i] = Math.Round( array[i] / 10, 1);
}

Console.WriteLine("Сгенерированный массив:");

Console.WriteLine(String.Join(", ", array));


double min = array[0]; 
double max = array[0]; 

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }

    if (array[i] > max)
    {
        max = array[i];
    }
}

double difference = max - min;
difference = Math.Round(difference, 1);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
    

