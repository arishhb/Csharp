/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.*/
 Console.WriteLine("введите число");
 int number1= Convert.ToInt32(Console.ReadLine());
 if (number1%23==0 && number1%7==0){
    Console.WriteLine("кратно 23 и 7");
 }
 else {
    Console.WriteLine("некратно 23 и 7");
 }