using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables");
            Console.ReadKey(true);

            // variables


            //Int (Whole numbers)

            int score; // declaration -- declaire "Score" as an intiger.
            score = 0; //initialization -- Init. "Score" to be 0.
            int enemiePoints;
            enemiePoints = 69;
            score = 1000000;
            score = score + enemiePoints;
           
            Console.WriteLine("Score: " + score); //display score
            

            //float (Fraction numbers)

            //floating points
            float lapTime; // declaration
            lapTime = 0.0f; // initialization
            Console.WriteLine(lapTime);
            lapTime = 65.357f;
            Console.WriteLine(lapTime);

            // string (Text)

            String name; // declaration
            name = "XBOX LIVE";
            Console.WriteLine(name);
            name = "Bababooey";
            Console.WriteLine(name);

            Console.ReadKey(true); // wait for keypress
             

        }
    }
}
