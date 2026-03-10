/*
 * À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1,
 * en utilisant des doubles, et afficher la valeur à chaque itération.
 * Remarquez-vous quelque chose de particulier ?
 */

for (double i = 0.0; i < 20.0; i += 0.1)
{
    Console.WriteLine($"{i}");
}

for (decimal i = 0.0M; i <= 20.0M; i += 0.1M)
{
    Console.WriteLine($"{i}");
}

for (double i = 0.0; i <= 200; i += 1)
{
    Console.WriteLine($"{i/10.0:F1}");
}