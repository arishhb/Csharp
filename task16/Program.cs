﻿/*Напишите программу, которая принимает на вход два числа и проверяет,
 является ли одно число квадратом другого.*/

 Console.WriteLine("введите два числа");
 int number1 = Convert.ToInt32(Console.ReadLine());
 int number2 = Convert.ToInt32(Console.ReadLine());

 if (number1*number1==number2 || number2*number2==number1){
    Console.WriteLine("является квадратом");
 }
 else{
    Console.WriteLine("не является квадратом");
 
 }
