//Наипшите программу  , которая на вход принимает два числа и проверяет является ли это певрое число квадратом второго 
Console.WriteLine("введите два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2  = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1 )
{
    System.Console.Write("да ");
}

else
{
    System.Console.Write("нет");
}

