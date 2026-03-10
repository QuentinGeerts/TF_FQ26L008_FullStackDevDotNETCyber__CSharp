/*
 * A l’aide de boucles « for » afficher les 5 premières tables de multiplication 
 * en allant jusque « x20 ».
 */

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Table de {i} :");
    for (int multiplicateur = 1; multiplicateur <= 20; multiplicateur++)
    {
        Console.WriteLine($"{multiplicateur} x {i} = {multiplicateur * i}");
    }
    Console.WriteLine();
}
