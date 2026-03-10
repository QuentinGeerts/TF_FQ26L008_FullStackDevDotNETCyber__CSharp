/*
 * Démonstration 10 - Collections génériques
 */

// 4 collections de base les plus utilisées
// - ArrayList  →   List<T>
// - Hashtable  →   Dictionary<T,U>
// - Queue      →   Queue<T>
// - Stack      →   Stack<T>

// 1.  Collection List<T>

List<int> myIntList = new List<int>();

List<int> myIntList3 = new List<int> { 1, 2, 3 };

List<int> myIntList2 = [12, 13];



myIntList.Add(42);
//myIntList.Add("Hello"); // Ne fonctionne pas

// 2. Dictionary<T,U>

Dictionary<string, string> contacts = new Dictionary<string, string>();

contacts.Add("quentin.geerts@bstorm.be", "Quentin Geerts");

foreach (KeyValuePair<string, string> kvp in contacts)
{
    Console.WriteLine($"Contact: {kvp.Key} {kvp.Value}");
}

foreach (string email in contacts.Keys)
{
    Console.WriteLine($"Contact: Email: {email} | info: {contacts[email]}");
}

// 3. Queue<T> & Stack<T>

Queue<string> myQueue = new Queue<string>();
myQueue.Enqueue("Personne1");
//myQueue.Enqueue(1);

Stack<string> myStack = new Stack<string>();
myStack.Push("");
//myStack.Push(1);
