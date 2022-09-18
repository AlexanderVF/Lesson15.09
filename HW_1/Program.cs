// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/* Console.Clear();
Console.WriteLine("Vvedite M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite N");
int n = int.Parse(Console.ReadLine());

Console.Write("M -> " + m + "; N -> " + n + ". -> ");
for (int i = m; i <= n; i++) {
    Console.Write(i + ", ");
} */


// С рекурсией
Console.Clear();
Console.WriteLine("Vvedite M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite N");
int n = int.Parse(Console.ReadLine());

void VseNatural(int m, int n) {
    if (m == n) {
    Console.WriteLine($"{m}");
    return;
    }
    if (m < n) {
        Console.Write($"{m},");
        VseNatural(m + 1, n);
    }
    if (m > n) {
        Console.Write($"{n},");
        VseNatural(m, n + 1);
    }
}

Console.Write("M -> " + m + "; N -> " + n + ". -> ");
VseNatural(m, n);

