// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782 -> 8
// 918 -> 1
int i = int.Parse(Console.ReadLine());
System.Console.WriteLine(RemoteSecondDigit(i)); 

int RemoteSecondDigit(int number)
{
int FirstNumber = number /10;
int SecondNumber = FirstNumber %10;
int result = SecondNumber;
return result;
}