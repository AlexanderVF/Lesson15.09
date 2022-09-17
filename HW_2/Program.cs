// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine("Vvedite M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite N");
int n = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write("M = " + m + "; N = " + n + ". -> ");
for (int i = m; i <= n; i++) {
    sum += i;
    }

Console.WriteLine(sum);