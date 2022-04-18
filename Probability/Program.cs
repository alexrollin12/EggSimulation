using System.Dynamic;
using MySql;
namespace Probability;

public class Program
{
    public static void Main(string[] args)
    {
        /*
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        myConnectionString = "server=localhost;uid=root;" + "pwd=ENTERPASSWORD;database=schema_name";
        try
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
            conn.Open();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine("FAIL");
        }
        */
        /*
        double counter = 0;
        double numberEgg = 0;
        double numberRune = 0;
        */
        
        double winning = 1;
        double eggRandom;
        double runeRandom;
        int simNumber = 0;
        int times = 50;
        int totalEgg = 0;
        Random random = new Random();
        for (int a = 0; a < 10000; a++)
        {
            simNumber++;
            int simWithEgg = 0;
            for (int k = 0; k < 365; k++)
            {
                double counter = 0;
                double numberEgg = 0;
                double numberRune = 0;
                string blue = "Blue";
                
               // Console.WriteLine();
               // Console.WriteLine($"Simulation #{simNumber}");

                for (int i = 0; i < times; i++)
                {
                    counter++;
                    eggRandom = random.Next(1, 1001);
                    runeRandom = random.Next(1, 101);
                    if (eggRandom == winning)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                       // Console.WriteLine($"EGG Gotten on Quest # {counter}");
                        numberEgg++;
                        simWithEgg++;

                    }

                    if (runeRandom == winning)
                    {
                        //Console.WriteLine($"Rune Gotten on Quest # {counter}");
                        numberRune++;
                    }

                    if (i == times - 1)
                    {
                        /*
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Total amount of quest : {counter}");
                        Console.WriteLine($"Total amount of EGG : {numberEgg}");
                        Console.WriteLine($"Total amount of Runes : {numberRune}");
                        */
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine($"-Simulation # {simNumber} ended-");
            Console.WriteLine($"Total days with Egg : {simWithEgg}");
            
            totalEgg += simWithEgg;
            
        }

        Console.ForegroundColor = ConsoleColor.Blue;
        int avg = totalEgg / simNumber;
        Console.WriteLine($"Avg # of Egg per year : {avg}");
    }
    
}