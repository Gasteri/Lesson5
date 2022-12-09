/* Задача №31 :
Задайте массив из 12 элементов,
заполненный случайными цифрами из промежутка [-9, 9].
Найти сумму отрицательных и положительных элементов массива.
Например в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
сумма положительных чисел равна 29, сумма отрицательныхравна -20.*/

int[] array = GenerateArray(-9, 9, 12);
PrintArray(array);
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);
void PrintArray(int[] array)
{
    //Console.WriteLine(@"[{0}]", string.Join(" , ", array));
    Console.WriteLine($"[{string.Join(" , ", array)}]");
    //string message = string.Join(" , ", array); другой способ
    //Console.WriteLine($"[{message}]");
    //string message = string.Join(" , ", array); выведет просто цифры через запятую
    //Console.WriteLine(message);
}
Console.WriteLine($"Cумма положительных чисел равна {sumPositiveNumbers}, сумма отрицательныхравна {sumNegativeNumbers}.");

int GetSumPositiveNumbersInArray(int[] array)
{
    int sumPositiveNumbers = 0;
    for(var i = 0; i < array.Length; i++)
    {
        if(array[i] >= 0)
        {
            sumPositiveNumbers+= array[i];
        }
    }
    return sumPositiveNumbers;
}
int GetSumNegativeNumbersInArray(int[] array)
{
    int sumNegativeNumbers = 0;
    for(var i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
        {
            sumNegativeNumbers+= array[i];
        }
    }
    return sumNegativeNumbers;
}
int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for(var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max +1);
    }

    return array;
}

