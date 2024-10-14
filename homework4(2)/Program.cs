System.Console.WriteLine("напишите число ");
int num = Convert.ToInt32(Console.ReadLine());
int numbernegativ = 1;
while (numbernegativ <= num)
{
    System.Console.Write($"{numbernegativ}");
    numbernegativ++;
}