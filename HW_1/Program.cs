// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
Console.WriteLine("Vvedite M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite N");
int n = int.Parse(Console.ReadLine());

Console.Write("M -> " + m + "; N -> " + n + ". -> ");
for (int i = m; i <= n; i++) {
    Console.Write(i + ", ");
}
