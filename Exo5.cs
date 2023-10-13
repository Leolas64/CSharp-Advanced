using System;
using System.Collections.Generic;

public class Exo5
{
    public static int Exo5Prog()
    {
        int[] nombres = { 0, 1, 3, 3, 3, 3, 3, 1, 0 };
        int i = 0;
        int[] repetitions = new int[10];

        foreach (int chiffre in nombres)
        {
            switch (chiffre)
            {
                case 0:
                    repetitions[0]++;
                    break;
                case 1:
                    repetitions[1]++;
                    break;
                case 2:
                    repetitions[2]++;
                    break;
                case 3:
                    repetitions[3]++;
                    break;
                case 4:
                    repetitions[4]++;
                    break;
                case 5:
                    repetitions[5]++;
                    break;
                case 6:
                    repetitions[6]++;
                    break;
                case 7:
                    repetitions[7]++;
                    break;
                case 8:
                    repetitions[8]++;
                    break;
                case 9:
                    repetitions[9]++;
                    break;
            }
        }
        if (repetitions[0] > repetitions[1] && repetitions[0] > repetitions[2] && repetitions[0] > repetitions[3] && repetitions[0] > repetitions[4] && repetitions[0] > repetitions[5] && repetitions[0] > repetitions[6] && repetitions[0] > repetitions[7] && repetitions[0] > repetitions[8] && repetitions[0] > repetitions[9])
        {
            Console.WriteLine(0);
            return repetitions[0];
        }
        else if (repetitions[1] > repetitions[2] && repetitions[1] > repetitions[3] && repetitions[1] > repetitions[4] && repetitions[1] > repetitions[5] && repetitions[1] > repetitions[6] && repetitions[1] > repetitions[7] && repetitions[1] > repetitions[8] && repetitions[1] > repetitions[9])
        {
            Console.WriteLine(1);
            return repetitions[1];
        }
        else if (repetitions[2] > repetitions[3] && repetitions[2] > repetitions[4] && repetitions[2] > repetitions[5] && repetitions[2] > repetitions[6] && repetitions[2] > repetitions[7] && repetitions[2] > repetitions[8] && repetitions[2] > repetitions[9])
        {
            Console.WriteLine(2);
            return repetitions[2];
        }
        else if (repetitions[3] > repetitions[4] && repetitions[3] > repetitions[5] && repetitions[3] > repetitions[6] && repetitions[3] > repetitions[7] && repetitions[3] > repetitions[8] && repetitions[3] > repetitions[9])
        {
            Console.WriteLine(3);
            return repetitions[3];
        }
        else if (repetitions[4] > repetitions[5] && repetitions[4] > repetitions[6] && repetitions[4] > repetitions[7] && repetitions[4] > repetitions[8] && repetitions[4] > repetitions[9])
        {
            Console.WriteLine(4);
            return repetitions[4];
        }
        else if (repetitions[5] > repetitions[6] && repetitions[5] > repetitions[7] && repetitions[5] > repetitions[8] && repetitions[5] > repetitions[9])
        {
            Console.WriteLine(5);
            return repetitions[5];
        }
        else if (repetitions[6] > repetitions[7] && repetitions[6] > repetitions[8] && repetitions[6] > repetitions[9])
        {
            Console.WriteLine(6);
            return repetitions[6];
        }
        else if (repetitions[7] > repetitions[8] && repetitions[7] > repetitions[9])
        {
            Console.WriteLine(7);
            return repetitions[7];
        }
        else if (repetitions[8] > repetitions[9])
        {
            Console.WriteLine(8);
            return repetitions[8];
        }
        else 
        {
            Console.WriteLine(9);
            return repetitions[9];
        }
    }
}