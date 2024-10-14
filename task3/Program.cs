// дни недели
Console.WriteLine("введите число , чтобы узнать какой это день недели");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    System.Console.WriteLine("понедельник");

}
else if (num == 2 )
{
    System.Console.WriteLine("Вторник");
}

else if(num == 3)
{
    System.Console.WriteLine("среда");
}

else if (num == 4)
{
    System.Console.WriteLine("четверг");
}

else if  (num == 5)
{
    System.Console.WriteLine("пятница");
}

else if (num == 6)
{
    System.Console.WriteLine("суббота");
}

else if (num == 7  )
{
    System.Console.WriteLine("Воскресенье");

}

else
{
    
    System.Console.WriteLine("такого дня нет ");
}





