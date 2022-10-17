// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumeralsNumber(int number)
{   
    if(number < 0)
    {
        number=-number;
    }
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
int answer = SumNumeralsNumber(number);
System.Console.WriteLine($"Сумма разрядов(цифр) числа {number} равна {answer}");

