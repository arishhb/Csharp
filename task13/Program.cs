/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int copnumber= number;
int k=0;
while (copnumber>0){
    copnumber=copnumber/10;
    k=k+1;
}
if (k<3){
    Console.WriteLine("третьей цифры нет");
}
else{
    int i= number/Convert.ToInt32(Math.Pow(10,(k-2)));
    int j= number/Convert.ToInt32(Math.Pow(10,(k-3)));
    number=j-i*10;
    Console.WriteLine(number);

}