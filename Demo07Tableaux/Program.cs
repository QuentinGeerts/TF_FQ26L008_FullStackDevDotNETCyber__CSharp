/*
 * Démonstration 07 - Tableaux
 */


// 1.  Déclaration d'un tableau

string[] myStringArray = new string[5];
int[] myIntArray = new int[5];

int[] myIntArray2 = { 1, 2, 3, 4 };
int[] myIntArray3 = [ 1, 2, 3, 4 ]; // Expression de collection

// 2.  Accès à un élément dans le tableau
// Indice (index): 0 → taille-1

myStringArray[0] = "Hello";
myStringArray[1] = "Bonjour";
myStringArray[2] = "Halo";
myStringArray[3] = "Konichiwa";
myStringArray[4] = "Bom dia";

// <!> impossible d'accéder à des valeurs en dehors de la portée du tableau
//myStringArray[-1] = "Hi";
//myStringArray[5] = "Hi";

// 3.  Récupération de la taille du tableau
// Propriété "length"

Console.WriteLine($"Taille du tableau: {myStringArray.Length}");

// 4.  Parcourt d'un tableau
// → possible avec toutes les boucles (préférence pour la boucle for)
// RAPPEL: La boucle foreach ne permet pas la modification d'élément

for (int i = 0; i < myStringArray.Length; i++)
{
    myStringArray[i] = myStringArray[i].ToUpper();
    Console.WriteLine($"{i}. {myStringArray[i]}");
}


int j = 0;
foreach (string item in myStringArray)
{
    //item = item.ToUpper(); // Impossible car Current est en lecture seule
    Console.WriteLine($"{j++}. {item}");
}

