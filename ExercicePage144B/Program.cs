/*
 * Calculer le factoriel d’un nombre entré au clavier.
 */

int resultat = 1;
int nombre;

Console.WriteLine($"Entrez un nombre:");
while (!int.TryParse(Console.ReadLine(), out nombre))
    Console.WriteLine($"Erreur, réessayez :");


for (int i = nombre; i >= 2; i--)
{
    //resultat = resultat * i;
    resultat *= i;
}

Console.WriteLine($"{nombre}! = {resultat}");
