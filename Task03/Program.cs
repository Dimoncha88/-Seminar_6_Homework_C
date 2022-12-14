// Напишите программу, которая задаёт массив из n элементов, которые необходимо 
// заполнить случайными значениями и сдвинуть элементы массива влево, 
// или вправо на 1 позицию.

// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево

// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо

Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(size);

Console.WriteLine($"Введенный массив: [{string.Join(",", array)}]");
int[] FillArray(int sizeArray)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(1, 10);
    }
    return resultArray;
}

int[] MoveNumbersLeft(int[] leftArr)
{
    int[] resultArr = new int[leftArr.Length];
    for (int i = 0; i < leftArr.Length - 1; i++)
    {
        resultArr[resultArr.Length - 1] = leftArr[0];
        resultArr[i] = leftArr[i + 1];
    }
    return resultArr;
}
Console.WriteLine($"Сдвиг влево: [{string.Join(",", MoveNumbersLeft(array))}]");

int[] MoveNumbersRight(int[] leftArr)
{
    int[] resultArr = new int[leftArr.Length];
    for (int i = 1; i < leftArr.Length; i++)
    {
        resultArr[0] = leftArr[leftArr.Length - 1];
        resultArr[i] = leftArr[i - 1];
    }
    return resultArr;
}
Console.WriteLine($"Сдвиг вправо: [{string.Join(",", MoveNumbersRight(array))}]");