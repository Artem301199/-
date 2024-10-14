// напишите программу , которая на вход принимает два числа , а на выходе выдаёт какое большее ,а какое меньшее
System.Console.WriteLine("Введите два числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if ( a>b)
{
    System.Console.WriteLine($"{a},большее число");
}
else
{
     System.Console.WriteLine($"{b}");
}