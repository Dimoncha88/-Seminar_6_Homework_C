// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача 2 (задача со звёздочкой): Напишите программу, 
// которая задаёт массив из n элементов, которые необходимо заполнить случайными 
// значениями и определить существует ли пара соседних элементов с одинаковыми значениями, 
// при наличии такого элемента заменить его на уникакальное значение.

// [1,2,3,3] -> [1,2,3,4]

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
        resultArray[i] = random.Next(1, 6);
    }
    return resultArray;
}
int[] ChangeArray(int[] arr)
{
    Random rnd = new Random();
    int[] changeArr = new int[arr.Length];
    for (int i = 1; i < changeArr.Length; i++)
    {
        changeArr[0] = arr[0];
        changeArr[i] = arr[i];
        if (arr[i] == arr[i - 1])
            arr[i] = rnd.Next(6, 10);
        changeArr[i] = arr[i];
    }
    return changeArr;
}
Console.WriteLine($"Полученный массив: [{string.Join(",", ChangeArray(array))}]");