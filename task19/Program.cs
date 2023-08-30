/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int n5= number%10;
int n1= number/10000;
int n4= (number%100)/10;
int n2= (number/1000)%10;
if (n1==n5 && n2==n4) {
    Console.WriteLine("yes");
}
else {
    Console.WriteLine("no");
}