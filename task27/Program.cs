/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("введите число");
int number= Convert.ToInt32(Console.ReadLine());
int result= numbersum(number);
Console.WriteLine(result);

int numbersum(int num){
    int sum=0;
    while(num>9){
        sum=num%10+sum;
        num=num/10;
    }
    sum=sum+num;
    return sum;
}
