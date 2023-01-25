bool IsExistNum(int[] arr, int num)
{
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] == num)
return true;
}
return false;
}

Console.Write("Введите число, которое хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isExistNum = IsExistNum(array, number);
if (isExistNum)
{
Console.Write($"Число {number} есть в массиве - ");
PrintArray(array);
}
else
{
Console.Write($"Числа {number} нет в массиве - ");
PrintArray(array);
}