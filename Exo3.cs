using System;

public class Exo3
{
    public static void Exo3Prog()
    {
        Console.Write("Entrez un nombre: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " est pair");
            }
            else
            {
                Console.WriteLine(number + " est impair");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}