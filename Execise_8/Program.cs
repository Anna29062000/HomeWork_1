Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int number = 2;

while (number <= n)
{
    if (number%2 == 0)
    {
        Console.WriteLine(number);
    }
    number = number + 1;
}
