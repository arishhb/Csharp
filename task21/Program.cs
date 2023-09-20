/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("введите координаты точки A");
int x1=Convert.ToInt32(Console.ReadLine());
int y1=Convert.ToInt32(Console.ReadLine());
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координаты точки B");
int x2=Convert.ToInt32(Console.ReadLine());
int y2=Convert.ToInt32(Console.ReadLine());
int z2=Convert.ToInt32(Console.ReadLine());
int ras= (x2-x1)*(x2-x1)+(y2-y2)*(y2-y2)+(z2-z1)*(z2-z1);
int i = Convert.ToInt32(Math.Sqrt(ras));
Console.WriteLine(i);
