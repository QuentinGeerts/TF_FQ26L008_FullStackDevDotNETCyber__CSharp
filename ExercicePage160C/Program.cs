/*
 * Demandez à l’utilisateur d’introduire deux nombres au clavier et 
 * faite l’addition de ces deux nombres en ne convertissant que caractère 
 * par caractère. (Méthode « ToCharArray() » de la classe « string »).
 */

int number1, number2, report = 0;

Console.WriteLine($"Encodez le premier nombre :");
while (!int.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Erreur. Veuillez encoder un nombre:");
}

Console.WriteLine($"Encodez le deuxième nombre :");
while (!int.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Erreur. Veuillez encoder un nombre:");
}

Stack<char> digits1 = new Stack<char>(number1.ToString().ToCharArray());
Stack<char> digits2 = new Stack<char>(number2.ToString().ToCharArray());
Stack<int> resultStack = new Stack<int>();

int nbIterations = digits1.Count > digits2.Count ? digits1.Count : digits2.Count;

for (int i = 0; i < nbIterations; i++)
{
    int d1 = digits1.Count > 0 ? int.Parse(digits1.Pop().ToString()) : 0;
    int d2 = digits2.Count > 0 ? int.Parse(digits2.Pop().ToString()) : 0;

    int total = d1 + d2 + report;
    report = 0;

    if (total >= 10)
    {
        total -= 10;
        report = 1;
    }

    resultStack.Push(total);
}

if (report == 1) resultStack.Push(report);

string resultStr = "";

foreach (var digit in resultStack)
{
    resultStr += digit;
}

Console.WriteLine($"{number1} + {number2} = {int.Parse(resultStr)}");