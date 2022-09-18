// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* Console.Clear();
Console.WriteLine("Vvedite M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite N");
int n = int.Parse(Console.ReadLine());
int sum = 0;

Console.Write("M = " + m + "; N = " + n + ". -> ");
for (int i = m; i <= n; i++) {
    sum += i;
    }

Console.WriteLine(sum); */

// через рекурсию
Console.Clear();
Console.WriteLine("Vvedite M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite N");
int n = int.Parse(Console.ReadLine());

int SumNew(int m, int n) {
    if (m == 0) return (n * (n + 1)) / 2;
    if (n == 0) return (m * (m + 1)) / 2;
    if (m == n) return m;
    if (m < n) return n + SumNew(m,n-1);
    else return n + SumNew(m,n+1);
}
Console.WriteLine("M = " + m + "; N = " + n + ". -> " + SumNew(m,n));
