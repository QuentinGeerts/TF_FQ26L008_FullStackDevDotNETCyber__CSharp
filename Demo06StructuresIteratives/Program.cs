/*
 * Démonstration 06 - Structures itératives
 */

// <!> 3 éléments importants pour qu'une boucle fonctionne

// - Initialisation (où je commence)
// - Condition d'arrêt (où je m'arrête)
// - Modification (comment je m'y rends)


// 1. While (Tantque)

/*
 * while (condition)
 * {
 *  // bloc d'instructions
 * }
 */

// initialisation
int cpt = 0;
while (cpt < 10)
{
    Console.WriteLine($"Compteur: {cpt}");
    cpt++;
}

bool again = true;

while (again)
{
    Console.WriteLine($"Veux-tu continuer ?");
    while (!bool.TryParse(Console.ReadLine(), out again))
    {
        Console.WriteLine($"Attention, les valeurs possibles sont 'true' ou 'false'.");
    }
}


// 2. Do ... While (FaireTantque)

/*
 * do
 * {
 *  // bloc d'instructions
 * } while (condition);
 */

while (false) // boucle à tests antérieurs
{
    Console.WriteLine("Le code ne sera jamais exécuté.");
}

do
{
    Console.WriteLine($"Le code sera exécuté qu'une seule fois.");
} while (false); // boucle à tests postérieurs


// 3. For (Pour)

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i: {i}");
}

for (int i = 0, j = 10; i < 10; i++, j--)
{
    Console.WriteLine($"i: {i} | j: {j}");
}

again = true;

for (int i = 0; again; i++)
{
    Console.Write($"Incrémentation suivante : ");
    while (!bool.TryParse(Console.ReadLine(), out again))
    {
        Console.WriteLine($"Attention, les valeurs possibles sont 'true' ou 'false'.");
    }

    Console.WriteLine($"Valeur de i: {i}");
}

// -- Exemple de boucle infinie avec for --

//int k = 0;

//for(; ;)
//{
//    Console.WriteLine($"Valeur de i: {k++}");
//}

// -- 

// 4. Foreach (PourChaque)

string myString = "Ceci est une chaîne de caractères.";

foreach (char letter in myString)
{
    Console.WriteLine($"{letter}");
    // if (letter == 'e') letter = 'a'; // impossible
}

int[] myInts = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

foreach (int number in myInts)
{
    Console.WriteLine($"{number}");
}

List<int> myIntsCol = [1, 2, 3, 4, 5];

foreach (var number in myIntsCol)
{
    Console.WriteLine($"{number}");
}