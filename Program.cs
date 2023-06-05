// // задайте массив из 12 эл-тов, наполненных случайными числами из промежутка [-9, 9]
// // найти сумму всех отрицательных и положительных эл-тов массива

// int [] GeneratArray()
// {
//     int [] array = new int[12];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     return array;
// }

// int[] array = GeneratArray();
// int sumPositive = 0;
// int sumNegative = 0;


// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     {
//         sumPositive += array[i]; 
//     }
//     else 
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine(String.Join(", ", array));
// Console.WriteLine($"Сумма положительных чисел равна: {sumPositive} ");
// Console.WriteLine($"Сумма отрицательных чисел равна: {sumNegative} ");

// написать прогу замены эл-тов массива: полож. эл-ты заменить на соответствующие отрицательные, и наоборот

// int[] GenArray(int len)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = new Random().Next(-9, 10);
//     }
//     Console.WriteLine(String.Join(", ", array));
//     return array;
// }

// Console.WriteLine("Введите количество цифр для массива:");
// int len = Convert.ToInt32(Console.ReadLine());
// int[] array = GenArray(len);
// for (int i = 0; i < len; i++)
// {
//     array[i]*= -1;
// }
// Console.WriteLine(String.Join(", ", array));




// задайте массив. написать прогу, к-я определяет присутствует ли заданное число в массиве

// int[] GenArray(int len)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = new Random().Next(0, 20);
//     }
//     Console.WriteLine(String.Join(", ", array));
//     return array;
// }

// Console.WriteLine("Введите интересующее вас число: ");
// int unknown = Convert.ToInt32(Console.ReadLine());
// int[] array = GenArray(15);
// bool t = false;
// for (int i = 0; i < 15; i++)
// {
//     if (array[i] == unknown)
//     {
//         t = true;
//     }
// }
// if(t)
// {
//     Console.WriteLine("присутствует");
// }
// else
// {
//     Console.WriteLine("Не присутствует");
// }


// задать одномерный массив из 123 случайных чисел.
// найти кол-во эл-тов массива, значения к-ых лежат в отредке[10, 99]

// int[] GenArray(int len)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = new Random().Next(0, 101);
//     }
//     Console.WriteLine(String.Join(", ", array));
//     return array;
// }

// int[] array=GenArray(5);
// int countEl=0;
// for (int i = 0; i < 5; i++)
// {
//     if (array[i] >=10 && array[i] <= 99)
//     {
//         countEl+=1;
//     }
// }

// Console.WriteLine($"кол-во эл-тов  {countEl}");

// Найти произведение пар чисел в одномерном массиве.
// парой считается первый и последний эл-т, второй и предпоследний и т.д. 
// результат записать в новом массиве

// int len1 = 5;

// int[] GenArray(int len)
// {
//     int[] array = new int[len];
//     for (int i = 0; i < len; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     Console.WriteLine(String.Join(", ", array));
//     return array;
// }

// int[] array = GenArray(len1);
// int len2;
// if (len1 % 2 == 0)
// {
//     len2 = len1 / 2;
// }
// else 
// {
//     len2 = len1 / 2 + 1;
// }

// int[] finishArray = new int[len2];
// int[] b = new int[len2];     
// int[] a = new int[len2];
// if (len1 % 2 != 0)
// {
//     for (int i = 0; i < len2; i++)
//         {
//         a[i] = array[i] * array[array.Length - 1 - i];
//         if ((array[i] == array[array.Length - 1 - i]))
//             {
//                 b[i] = array[i];
//             }
//         }
//     Array.Copy(a, finishArray, a.Length - 1);
//     finishArray[a.Length - 1] = b[b.Length - 1];

//     Console.WriteLine(String.Join($", ", finishArray));
// }
// else
// {
//     for (int i = 0; i < len2; i++)
//         {
//         a[i] = array[i] * array[array.Length - 1 - i];
//         }
//     Console.WriteLine(String.Join(", ", a));    
// }

// упрощенный вариант
int len1 = 2;

int[] GenArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    Console.WriteLine(String.Join(", ", array));
    return array;
}

int[] array = GenArray(len1);
int len2;
if (len1 % 2 == 0)
{
    len2 = len1 / 2;
}
else 
{
    len2 = len1 / 2 + 1;
}

int[] finishArray = new int[len2];
int[] b = new int[len2];     

{
    for (int i = 0; i < len2; i++)
        {
        finishArray[i] = array[i] * array[array.Length - 1 - i];
        if ((i == array.Length - 1 - i))
            {
                finishArray[i] = array[i];
                
            }
        }

    Console.WriteLine(String.Join(", ", finishArray));
}
