// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
//32679 -> 6

int i = int.Parse(Console.ReadLine());
System.Console.WriteLine(ThirdNumber(i)); 

  if (i < 100)
    { 
    System.Console.WriteLine ("Третьей цифры нет");
    }
  else while (i>999)
   {
    int Number = i /10;    
    int ThirdNumber = i % 10;
    int result = ThirdNumber;
    return result;
   } 
    