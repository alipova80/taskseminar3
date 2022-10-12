// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine ("Введите число: ");
string num = Console.ReadLine()!;
if (num.Length == 5){
    if (num[0] == num[4] && num[1] == num[3]){
        Console.WriteLine ("Число является палиндромом");
    }
    else{
        Console.WriteLine ("Число не является палиндромом");
    }
}
else{
    Console.WriteLine ("Такого числа нет");
}
*/

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine ("Введите координаты первой точки x: ");
double ax = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine("Введите координаты первой точки y: ");
double ay = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Введите координаты первой точки z: ");
double az = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки x: ");
double bx = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки y: ");
double by = Convert.ToDouble(Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки z: ");
double bz = Convert.ToDouble(Console.ReadLine ());

double result = Math.Sqrt(Math.Pow((bx-ax),2) )+(Math.Pow((by-ay),2))+(Math.Pow((bz-az),2));

Console.WriteLine($"Расстояние между точками");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int i = 1;
int result = 0;
while(i <= num)
{
    result = Convert.ToInt32(Math.Pow(i,3));
    Console.WriteLine($"result");
    i++;
}
*/
