/*
 * Calculer les 25 premiers nombres de la suite de Fibonacci
 */

int a = 0, b = 1, c;

Console.WriteLine($"1. {a}");
Console.WriteLine($"2. {b}");

for (int i = 3; i <= 25; i++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine($"{i}. {c}");
}
