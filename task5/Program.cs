//Напишите программу которая на вход получает трёхзначное число , а на выходе показывает 
// цифру этого числа 
 System.Console.WriteLine("введите число ");
 int num = Convert.ToInt32(Console.ReadLine());
if ( num >=100 && num<=999)
{
     int otvet = num%10;
 System.Console.WriteLine($"{otvet}");
}
else 
{
    System.Console.WriteLine("Введите трёхзначное число ");
}
