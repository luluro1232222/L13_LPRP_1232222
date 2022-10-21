using System;

class Program
{
    static void Main()
    {
        string[] personas = new string[5];
        int[] años = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un nombre ");
            personas[i] = Console.ReadLine();
            Console.WriteLine("Ingrese la edad ");
            años[i] = Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < 5; i++)
        {
            if (años[i] > 18)
            {
                Console.WriteLine(personas[i]);
            }
        }
    }
}
