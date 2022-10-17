// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень). Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number1 = InputNumber("Введите число А = ");
int number2 = InputNumber("Введите число B = ");

if (number2 >= 0)
{
    int answer = 1;
    int i = 0;
    while ( i < number2)
    {
        answer = answer*number1;
        i++;
    }
System.Console.WriteLine($"Если число  В = {number2} - натуральное, то число А = {number1} в степени В равно: {answer}");
}
else 
{
    System.Console.WriteLine($"Число В = {number2} - не натуральное!");
}
