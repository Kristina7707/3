// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

	
int firstDigit;
int secondDigit;
int fourthDigit;
int fifthDigit;
int n = new Random().Next(10000, 99999);
System.Console.WriteLine($"Введи пятизначное число: ");
n = Convert.ToInt32(Console.ReadLine());

firstDigit = n / 10000;
n = n % 10000;

secondDigit = n / 1000;
n = n % 1000;

n = n % 100;

fourthDigit = n / 10;
n = n % 10;

fifthDigit = n;

if(firstDigit==fifthDigit && secondDigit==fourthDigit)
System.Console.WriteLine("Число является палиндромом");
else if(firstDigit!=fifthDigit && secondDigit!=fourthDigit) 
System.Console.WriteLine("Число не является палиндромом");



