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

Type stringType = typeof(string); // String
Type resultType = result.GetType(); // String

Console.WriteLine($"Result {(stringType == resultType ? "est" : "n'est pas")} de type string");
