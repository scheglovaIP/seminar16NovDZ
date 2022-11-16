//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 5)

    Console.WriteLine($"{number} - будний день");

else if(number==6 || number==7) Console.WriteLine($"{number} - выходной день");

else

    Console.WriteLine("Такого дня не существует");
