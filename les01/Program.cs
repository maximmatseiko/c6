
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число А : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B : ");
int b = Convert.ToInt32(Console.ReadLine());
int num=a;
for(int i=1;i<b;i++)
{
num=num*a;
}
Console.WriteLine("A в степени В   : " +num);