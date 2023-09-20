/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите в какую степень возвести");
int stepen = Convert.ToInt32(Console.ReadLine());
int res= vosvedenie(number, stepen);
Console.WriteLine(res);

int vosvedenie(int A, int B){
    int result=Convert.ToInt32(Math.Pow(A,B));
    return result;
}
