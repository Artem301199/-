// написать программу которая на вход принимает число N , а на выходе показывает числа от -N до N
System.Console.WriteLine("напишите число ");
int num = Convert.ToInt32(Console.ReadLine());
int numbernegativ = -num;
while (numbernegativ <= num)
{
    System.Console.Write($"{numbernegativ}");
    numbernegativ++;
}