/*
 * Grâce à une boucle « for », calculez les x premiers nombre premier.
 */

int nbPrimes, nbPrimesFound = 0, count = 2;

Console.WriteLine($"Combien de nombres premiers voulez-vous ?");
while (!int.TryParse(Console.ReadLine(), out nbPrimes) || nbPrimes < 0)
{
    if (nbPrimes < 0) Console.WriteLine("La valeur doit être positive.");
    else Console.WriteLine($"Vous devez entrer un nombre.");
}

while (nbPrimesFound < nbPrimes)
{
    bool isPrime = true;

    for (int i = 2; i <= Math.Sqrt(count); i++)
    {
        if (count % i == 0) isPrime = false;
    }

    if (isPrime)
    {
        nbPrimesFound++;
        Console.WriteLine($"{nbPrimesFound}. {count}");
    }

    count++;
}
