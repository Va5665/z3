﻿Console.Write("Введите число из пяти цифр: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Ваше число: {number} - палиндром.");
  }
 else Console.WriteLine($"Ваше число: {number} - Не палиндром.");
 }

 if (number!.Length == 5){
  CheckingNumber(number);
 }
 else Console.WriteLine($" введите число из пяти цифр");
