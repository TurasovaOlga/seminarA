//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("введите трехзначное любое число.\n выход из программы команда Exit");
while(true)
{
    string input = Console.ReadLine();
    if(!input.Equals("exit"))
       Console.WriteLine("{0}->{1}",input,input[1]);
       else
       break;
}

//Напишите программу, которая с  помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("введите чило");
int n = int.Parse(Console.ReadLine());
int k = (int)Math.Log10(n)-2;
Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString());
Console.ReadLine();

//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("введите число от 1 до 7");
int number1 =Convert.ToInt32(Console.ReadLine());
if (number1==7)
{
    Console.WriteLine("цифра 7 соответсвует воскресенью,это выходной день");
}
if (number1==6)
{
    Console.WriteLine("цифра 6 соответсвует субботе,это выходной день");
}
else 
{
    Console.WriteLine("данной цифре соответствует будний день");
}