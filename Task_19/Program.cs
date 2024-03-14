/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 > нет;  12821 -> да; 23432 -> да    */

Console.WriteLine ("Введите 5-ти значное число: ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
string number = Console.ReadLine();
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
int len = number.Length;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

if (len == 5)
{
    if (number[0] == number[4] && number [1] == number[3])
    {
        Console.WriteLine(number + " да");
    }

    else
    {
        Console.WriteLine(number + " нет");
    }
}
else
{
    Console.WriteLine ("Вы ввели НЕ 5-и значное число");
}