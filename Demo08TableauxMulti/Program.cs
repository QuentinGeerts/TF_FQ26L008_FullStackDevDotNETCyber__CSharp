/*
 * Démonstration 08 - Tableaux multi-dimensionnel
 */

// 1.  Tableau orthogonal
// > qui contient des sous-tableaux de tailles variables

// 1.1.  Déclaration d'un tableau
int[][] tableauOrthogonal = new int[4][];
tableauOrthogonal[0] = new int[3];
tableauOrthogonal[1] = [1, 2, 3];
tableauOrthogonal[2] = new int[6];
tableauOrthogonal[3] = new int[1];

int[][] tableauOrthogonal2 = [
    new int[5],
    [1, 2, 3, 4, 5, 7, 8, 9, 10],
    [0, 0, 0, 0, 0]
];

// 1.2.  Accéder à un indice
tableauOrthogonal[2][2] = 42;

// 1.3.  Récupération de la taille d'un tableau

Console.WriteLine($"Taille du tableau: {tableauOrthogonal.Length}");
Console.WriteLine($"Taille du sous-tableau: {tableauOrthogonal[0].Length}");
Console.WriteLine($"Taille du sous-tableau: {tableauOrthogonal[1].Length}");
Console.WriteLine($"Taille du sous-tableau: {tableauOrthogonal[2].Length}");
Console.WriteLine($"Taille du sous-tableau: {tableauOrthogonal[3].Length}");

// 1.4.  Parcourt d'un tableau orthogonal

for (int i = 0; i < tableauOrthogonal.Length; i++)
{
    for (int j = 0; j < tableauOrthogonal[i].Length; j++)
    {
        Console.Write($"[{i},{j}]:{tableauOrthogonal[i][j]} \t");
    }
    Console.WriteLine();
}

// 2.  Tableau matriciel
// > qui contient des sous-tableaux de tailles identiques

// 2.1.  Déclaration d'un tableau matriciel

int[,] tableauMatriciel = new int[3, 5];
int[,] tableauMatriciel2 = {
    { 0, 0, 0, 0 },
    { 0, 0, 0, 0 }
};

// 2.2.  Accéder à un indice

tableauMatriciel[0, 0] = 42;

// 2.3.  Récupération de la taille d'un tableau matriciel

Console.WriteLine($"Taille du tableau: {tableauMatriciel.GetLength(0)}");
Console.WriteLine($"Taille des sous-tableau: {tableauMatriciel.GetLength(1)}");

// 2.4.  Parcourt d'un tableau orthogonal

for (int i = 0; i < tableauMatriciel.GetLength(0); i++)
{
    for (int j = 0; j < tableauMatriciel.GetLength(1); j++)
    {
        Console.Write($"[{i},{j}]:{tableauMatriciel[i,j]} \t");
    }
    Console.WriteLine();
}