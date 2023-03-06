// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if((dayNumber > 0) && (dayNumber < 8))
{
    if((dayNumber == 7) ||  (dayNumber == 6))
    {
        Console.WriteLine($"День номер {dayNumber} выходной");        
    }
    else
    {
        Console.WriteLine($"День номер {dayNumber} не выходной");
    }
}
else
{
    Console.WriteLine("Нужно ввести день недели цифрой. Например 5 - это пятница");
}