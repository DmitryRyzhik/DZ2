// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>99)
{
    System.Console.WriteLine((num/100)%10);
}
else
{
    System.Console.WriteLine("число не имеет третьей цифры");
}