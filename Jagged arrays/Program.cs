using System;


namespace DSA_ACT_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code: 1 - Car, 2 - Bus, 3 - Subway, 4 - Bike, 5 - On foot");
            int[][] intJagged = new int[6][];
            string[] months = { "January", "February", "March", "April", "May", "June" };

            for (int i = 0; i < intJagged.Length; i++)
            {
                Console.Write($"Enter number of entries for {months[i]}: ");
                int count = Convert.ToInt32(Console.ReadLine());

                intJagged[i] = new int[count];


                Console.WriteLine($"Month of {months[i]}:");

                for (int j = 0; j < intJagged[i].Length; j++)
                {

                    Console.Write("  Enter Transportation Code:  ");
                    intJagged[i][j] = Convert.ToInt32(Console.ReadLine());
                }


                Console.WriteLine();
            }
        Console.Clear();

            for (int i = 0; i < intJagged.Length; i++) 
            {
                Console.Write($"{months[i]}\t");

                for (int j = 0; j < intJagged[i].Length; j++)
                {

                    Console.Write($"{intJagged[i][j]} ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();


           
               
        }
}

    }
