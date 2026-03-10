/*
 * Grâce à une boucle « while » et à l’aide d’une collection, 
 * calculez les nombres premiers inférieur à un nombre entier entré au clavier.
 */

using System.Collections;

int limit;
ArrayList primes = new ArrayList();

Console.WriteLine($"Entrez le nombre maximum pour déterminer les nombres premiers :");
while (!int.TryParse(Console.ReadLine(), out limit) || limit < 0)
{
    Console.WriteLine("Valeur incorrecte, réessayez :");
}

for (int i = 2; i <= limit; i++)
{
    bool isPrime = true;

    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        primes.Add(i); 
    }
}


foreach (var number in primes)
{
    Console.Write($"\t{number}");
}