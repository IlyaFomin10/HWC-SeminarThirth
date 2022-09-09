// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

void Palindrom5 (int arg1)
{
    if (arg1 > 9999 & arg1 < 100000)
    {
        int number1 = arg1 / 10000;
        int number2 = arg1 / 1000 % 10;
        int number3 = arg1 / 100 % 10;
        int number4 = arg1 / 10 % 10;
        int number5 = arg1 % 10;

        if (number1 == number5 & number2 == number4)
        {
             Console.WriteLine("Данное число является палиндромом");
        }     
        else Console.WriteLine("Данное число НЕ является палиндромом");
    }
    else Console.WriteLine("Введите положительное пятизначное число");
}

Palindrom5(number);
