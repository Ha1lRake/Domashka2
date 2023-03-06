// Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6


Console.WriteLine("Напишите семизначное число");

int number = Convert.ToInt32(Console.ReadLine());

if  ((number > 999999 ) && (number < 10000000))
{
    Console.WriteLine($"Третья цифра от числа {number} будет {(number % 100000) / 10000}");
}
else
{
    if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine("Нужно ввести СЕМИЗНАЧНОЕ число");
    }
}
