﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("введите трехзначное число");
int number= Convert.ToInt32(Console.ReadLine());
if (number<1000 && number>99){
    int ost1= number%100;
    int ost2= number%10;
    Console.WriteLine($"вторая цифра числа= {(ost1-ost2)/10}");
}
else {
    Console.WriteLine("не трехзначное число");
}