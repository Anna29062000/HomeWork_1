Console.WriteLine("Введите число №1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) 
{
    Console.WriteLine($"Число №1, равное {number1}, больше");
}
else
{
    Console.WriteLine($"Число №2, равное {number2}, больше");
}