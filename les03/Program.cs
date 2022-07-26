// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Method1()
{
       Console.Write("Программa, которая задаёт массив из 8 элементов и выводит их на экран =>");
}
 Method1();
 int [] num = new int[8];
Console.Write("[");

for (int i = 0; i < num.Length; i++)
 {
    num [i] = new Random().Next(0, 100);
    Console.Write(" " + Method ( i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return num[a];
}