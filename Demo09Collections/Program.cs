using System.Collections;

/*
 * Démonstration 09 - Les collections et collections génériques
 */

// 4 collections de base les plus utilisées
// - ArrayList  →   List<T>
// - Hashtable  →   Dictionary<T,U>
// - Queue      →   Queue<T>
// - Stack      →   Stack<T>

// Pour utiliser une collection de base, il faut importer le namespace:
// > System.Collections

// 1.  ArrayList
// Liste d'éléments

ArrayList myArrayList = new ArrayList();

myArrayList.Add("hello");
myArrayList.Add("bonjour");
myArrayList.Add("halo");
myArrayList.Add("Hola");

foreach (string greeting in myArrayList)
{
    Console.WriteLine($"greeting: {greeting}");
}

myArrayList.RemoveAt(1);

Console.WriteLine();

// 2. Hashtable
// Clef/valeur

Hashtable myHashtable = new Hashtable();

myHashtable.Add("quentin.geerts@bstorm.be", "Quentin Geerts");
myHashtable.Add("samuel.legrain@cognitic.be", "Samuel Legrain");
myHashtable.Add("thierry.morre@cognitic.be", "Thierry Morre");

if (!myHashtable.ContainsKey("quentin.geerts@bstorm.be"))
    myHashtable.Add("quentin.geerts@bstorm.be", "Hello");
else
{
    myHashtable["quentin.geerts@bstorm.be"] = "Hello";
}

foreach (DictionaryEntry contact in myHashtable)
{
    Console.WriteLine($"Contact: {contact.Key} {contact.Value}");
}

// 3.  Collection Queue
// > FIFO = First In First Out

//Queue fileAttente = new Queue();

//fileAttente.Enqueue("Personne 1");
//fileAttente.Enqueue("Personne 2");
//fileAttente.Enqueue("Personne 3");
//fileAttente.Enqueue("Personne 4");
//fileAttente.Enqueue("Personne 5");

//while(fileAttente.Count > 0)
//{
//    var personne = fileAttente.Peek();
//    Console.WriteLine($"Prochaine personne: {personne}");

//    Console.WriteLine($"Traitement en cours....");

//    if (Random.Shared.Next(100) >= 70)
//    {
//        Console.WriteLine("Personne traitée avec succès");
//        fileAttente.Dequeue();
//    }
//}


//// 4.  Collection Stack
//// Last In First Out (LIFO)

//Stack pileAssiettes = new Stack();

//pileAssiettes.Push("Assiette 1");
//pileAssiettes.Push("Assiette 2");
//pileAssiettes.Push("Assiette 3");
//pileAssiettes.Push("Assiette 4");
//pileAssiettes.Push("Assiette 5");

//foreach (var assiette in pileAssiettes)
//{
//    Console.WriteLine($"Assiette: {assiette}");
//}

//while (pileAssiettes.Count > 0)
//{
//    var assiette = pileAssiettes.Peek();
//    Console.WriteLine($"Assiette en cours de lavage: {assiette}");


//    Console.WriteLine($"Lavée avec succès: {pileAssiettes.Pop()}");
//}