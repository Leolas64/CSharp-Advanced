using System;
using System.Collections.Generic;

public class Exo4
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Exo4Prog()
    {
        AlgoTest(MyNameIs);
        Console.ReadLine();
    }

    public static string MyNameIs(string name)
    {
        string retValue = "";

        for (int i = 0; i < name.Length; i++)
        {
            int j = 0;
            foreach (char cara in alphabet)
            {
                if (name[i] == cara)
                {
                    retValue = retValue + j;
                }
                else if(name[i] == cara-32)
                {
                    retValue = retValue + j;
                }
                j++;
            }
        }
        // myNameIs("Ahmed") should return  '071243'
        // myNameIs("Dorlean") return 31417114013
        // myNameIs("a") return  0
        // myNameIs("Sandrine") return 180133178134

        return retValue;
    }

    public static void AlgoTest(Func<string, string> func)
    {
        if (func("Dorlean") == "31417114013")
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}