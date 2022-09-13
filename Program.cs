// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
/* Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int b = int.Parse(Console.ReadLine());
while (b<1)
{
    Console.WriteLine("Введено ненатуральное число");
    b = int.Parse(Console.ReadLine());
}
Console.WriteLine(Math.Pow(a,b));

 */

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе


/* Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int resul = 0;
while (num>0)
{
    resul=resul+num%10;
    num=num/10;
}
Console.WriteLine(resul); */


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] a = new int[8];
Random b = new Random();
for (int i=0; i<8; i++)
{
    a[i] = b.Next();
    Console.WriteLine(a[i]+" ");
}