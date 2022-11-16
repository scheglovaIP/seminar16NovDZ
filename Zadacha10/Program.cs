//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number<99 || number>1000)
{
    Console.WriteLine("Введенное число не трехзначное");
}

else
{
    Console.WriteLine(number/10%10);
}