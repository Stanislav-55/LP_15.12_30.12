/*
Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6   */



Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count=number;
int ThirdDigit(int num)
{
    return num % 10;
}



if (number > 1000)
{
    while (count > 1000)
    {
        count = count / 10;


    }

    Console.WriteLine($"{number}-> {ThirdDigit(count)}");

}


else if (number < 99 && number > -100)
    Console.WriteLine($"{number}-> третьей цифры нет");

else if (number < -99 && number > -1000)
{
    Console.WriteLine($"{number}-> {ThirdDigit(-number)}");
}
else if (number < -1000)
{
    while (number < -1000)
    {
        number = number / 10;
    }

    Console.WriteLine($"{number}-> {ThirdDigit(-number)}");
}
else
{
    Console.WriteLine($"{number}-> {ThirdDigit(number)}");
}

