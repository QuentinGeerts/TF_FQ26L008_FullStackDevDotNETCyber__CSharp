/*
 * Démonstration 05 - Les opérateurs
 */


// 1.  Opérateurs arithmétiques

Console.WriteLine($"5 + 2 = {5 + 2}");
Console.WriteLine($"5 - 2 = {5 - 2}");
Console.WriteLine($"5 * 2 = {5 * 2}");
Console.WriteLine($"5 / 2 = {5 / 2}"); // int / int = int
Console.WriteLine($"5 / 2 = {5 / (double)2}"); // int / double = double

// 2.  Raccourci des opérateurs

int a = 0, b = 0;

Console.WriteLine($"a = a + 2 => {a = a + 2} => {a += 2}");


// 3.  Post/pré-incrémentation / décrémentation
// a = a + 1 => a++ / ++a

// 3.1. Post-incrémentation: a++
// a. Récupération de la valeur de a
// b. Incrémentation de la valeur de a

// 3.2. Pré-incrémentation: ++a
// a. Incrémentation de la valeur de a
// b. Récupération de la valeur de a

a = 0;
b = a++; // b: 0 | a: 1
b = ++a; // a: 2 | b: 2

// 4. Opérateur ternaire
// expression_booléenne ? valeurSiVrai : valeurSiFaux

string sexe = "femme";

Console.WriteLine($"Bonjour, {(sexe == "femme" ? "Madame" : "Monsieur")}");

int age = 19;

Console.WriteLine($"Bonjour, {(
    age < 18 ? "Jeunôt" :
    age < 65 ? "l'adulte" : "vieille branche"
)}");


// 5. Opérateur coalesce
// ??

string? value = null;

string result = value ?? "Valeur par défaut";

result = result ?? "Valeur par défaut";
result ??= "Valeur par défaut"; // Permet d'initialiser une valeur par défaut

// 6. Opérateur typeof
// typeof(type)

// typeof       : Permet de récupérer le type d'un type spécifié
// GetType()    : Permet de récupérer le type d'une instance

Type stringType = typeof(string); // String
Type resultType = result.GetType(); // String

Console.WriteLine($"Result {(stringType == resultType ? "est" : "n'est pas")} de type string");

// 7. Opérateur is
// instance is Type

// Permet de vérifier si une instance est d'un certains type

object o = "BonJour";

Console.WriteLine($"o.GetType(): {o.GetType()}");

if (o is int)
{
    Console.WriteLine($"La variable 'o' est un entier.");
}
else if (o is short)
{
    Console.WriteLine($"La variable 'o' est un short.");
}
else if (o is long)
{
    Console.WriteLine($"La variable 'o' est un long.");
}
else if (o is string str) // Pattern matching
{
    Console.WriteLine($"La variable 'o' est une string.");
    Console.WriteLine(((string)o).ToUpper());
    Console.WriteLine(((string)o).ToLower());

    Console.WriteLine(str.ToLower());
    Console.WriteLine(str.ToUpper());
}

// Autre version du pattern matching (avec switch ♥)
switch (o)
{
    case int:
        Console.WriteLine($"o est un entier.");
        break;

    case string str:
        Console.WriteLine(str.ToLower());
        break;

    default:
        Console.WriteLine($"Type non pris en charge");
        break;
}


// 8. Opérateur as
// expression as type (type nullable)

object myObject = "hello";

string? myString = myObject as string; // myObject is string ? (string)myObject : null;

object myObject2 = 42;

int? myInt = myObject2 as int?; // myObject2 is int ? (int)myObject2 : null


// 9. Opérateur checked / unchecked

// Pour appliquer de manière automatique le checked sur le projet :
// a. Clic droit sur le projet
// b. Propriétés
// c. Build
// d. Advanced
// e. Cocher la case "Check for arithmetic operations overflows"

try
{
    checked
    {
        int x = int.MaxValue;
        int y = x + 1;
        Console.WriteLine($"x: {x}");
        Console.WriteLine($"y: {y}");
    }
}
catch (Exception)
{

    Console.WriteLine($"Exception levée");
}