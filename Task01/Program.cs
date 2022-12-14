// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
Console.WriteLine("Введите числа через пробел");
string num = Console.ReadLine();

string[] numbers = new string[num.Length];
int j = 0;
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (num[i] == ' ')
        {
            j++;
        }
        else
            numbers[j] = numbers[j] + num[i];
    }
    j++;
}
int[] resultArray = new int[j];

void PrintArray(int[] resultArray, string[] string1)
{
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = Convert.ToInt32(string1[i]);
        Console.Write(resultArray[i] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Введенные числа:");
PrintArray(resultArray, numbers);

int FindCountPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        count += 1;
    }
    return count;
}
Console.WriteLine($"Количество полоительных чисел {FindCountPositiveNum(resultArray)}");