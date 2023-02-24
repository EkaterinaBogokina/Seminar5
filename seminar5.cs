//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int [] array = GetArray(5,100,999);
Console.WriteLine(string.Join(", ",array));

int counter = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i]%2== 0)
{
    counter++;
}
    
}

Console.WriteLine($"counter= {counter}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}
// Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int [] array = GetArray(5,1,20);
Console.WriteLine(string.Join(", ",array));

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
if (i%2!=0)
{
    sum+=array[i];
}
    
}

Console.WriteLine($"sum= {sum}");

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for (int i=0; i<size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] array = GetArray(7,1,9);
Console.WriteLine(string.Join(", ",array));

double sum = 0;
double min = array[0];
double max = array[0];

for (int i = 0; i < array.Length; i++)
{
   if (array[i]<min)
    {
    min = array[i];
    }
   if (array[i]>max)
    {
    max = array[i];
    }
}
sum = min+max;

Console.WriteLine($"sum = {sum}");

double [] GetArray(int size, int minValue, int maxValue)
{
    double [] res = new double [size];
    for (int i=0; i<size; i++)
    {
        res [i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}
