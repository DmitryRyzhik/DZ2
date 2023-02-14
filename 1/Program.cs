// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99 && num<1000)
{
    int x=(num%100)/10;
    System.Console.WriteLine(x + " ");
}
else 
{
    System.Console.WriteLine("чичсло НЕ трехзначное");
}