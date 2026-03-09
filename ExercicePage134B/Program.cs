/*
 * Vérification d’un compte bancaire BBAN, si le compte est bon affichez OK 
 * sur la console sinon KO. 
 * Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. 
 * Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
 * (utilisez la méthode « Substring » de la classe « string »).
 */

//string bban = "539007547034";
string bban = "970000000097";
Console.WriteLine($"BBAN: {bban}");

if (bban.Length != 12)
{
    Console.WriteLine("Veuillez fournir 12 caractères au BBAN.");
}
else if (!long.TryParse(bban, out _))
{
    Console.WriteLine($"Le format du bban est incorrect.");
}
else
{
    long tenFirstDigits = long.Parse(bban.Substring(0, 10));
    int twoLastDigits = int.Parse(bban.Substring(10));

    if (tenFirstDigits % 97 == twoLastDigits
        || (tenFirstDigits % 97 == 0 && twoLastDigits == 97))
    {
        Console.WriteLine($"BBAN Ok");
    }
    else
    {
        Console.WriteLine($"BBAN Ko");
    }
}



