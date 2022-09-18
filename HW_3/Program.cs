// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//m = 2, n = 3 -> A(m,n) = 9


int m = 2;
int n = 3;
A(m,n);
 int A(int m, int n)
{
 if(m == 0) return n + 1;
 if(m > 0 && n == 0) return A(m-1, 1);
 if(m > 0 && n > 0) return A(m-1,A(m, n-1));
 
 else return A(m, n);
}
for (int i = 1; i < 30; i++) {
    for (int j = 1; j < 30; j++) {}
}
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) =  {A(m, n)}");