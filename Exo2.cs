using System;

public class Exo2
{
    public static void Exo2Prog()
    {
        Console.WriteLine("Entrer le nom de l'utilisateur :");
        string text = Console.ReadLine();
        text = ConvertToUpper(text);
        Console.WriteLine(text);
    }

    public static string ConvertToUpper(string text)
    {
        text = text.ToUpper();
        return text;
    }
}