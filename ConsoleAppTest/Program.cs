
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{

    
    class Program
    {

        public static bool IsSquare(int n)
        {
            
            var sqrt = Math.Sqrt(n);
            return sqrt % 1 == 0;
            // return Math.Abs(Math.Ceiling(sqrt) - Math.Floor(sqrt)) < Double.Epsilon;

        }
        
        public static String Accum(string s)
        {

            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
               
                result += Char.ToUpper(s[i]);

                for (int j = 0; j < i; j++)
                {
                    result += Char.ToLower(s[i]);
                }

                result += "-";
            }
                       
            return result.Remove(result.Length - 1);
        }

        public static String Glazing(double width, double height, string measure)
        {

            double glassarea, woodlength;
            string result;

            if (measure == "f")
            {

                woodlength = (height + width) * 2 * 3.25; //         in feet
                glassarea = height * width * 2 * 3.25;

                result = ("The required wood legth is " + woodlength + " feet.") + ("\nThe required glass area is " + glassarea + " sq feet.");
            }

            else
            {

                woodlength = (height + width) * 2; //         in meters
                glassarea = height * width * 2;

                result = ("The required wood length is " + woodlength + " meters.") + ("The required glass area is " + glassarea + " sq meters.");
            }
                       
            return result;



        }


        
        static void Main(string[] args)
        {


            Console.WriteLine("Gib strink:");
            Console.WriteLine("Get strink: {0}", Accum(Console.ReadLine())); 


            Console.WriteLine("Enter Number To Check Square:");

            int n = int.Parse(Console.ReadLine());

            if (IsSquare(n))
            {
                Console.Write("The number {0} is square.", n);
            }

            else
            {
                Console.Write("The number {0} is not square.", n);
            }

            
            /////////////////////////////////////////////////////////////////////

            Console.WriteLine("\nNow let's go to glazing.");
            Console.ReadLine();
            

            //double width, height, glassarea, woodlength;
            //string inputwidth, inputheight, measure;

            Console.WriteLine("Feet or Meters (enter f or m):");
            string measure = Console.ReadLine();

            Console.WriteLine("Enter width:");
            string inputwidth = Console.ReadLine();
            double width = double.Parse(inputwidth);

            Console.WriteLine("Enter height:");
            string inputheight = Console.ReadLine();
            double height = double.Parse(inputheight);

            Console.WriteLine(Glazing(width, height, measure));


            //if (measure == "f")
            //{

            //    woodlength = (height + width) * 2 * 3.25; //         in feet
            //    glassarea = height * width * 2 * 3.25;

            //    Console.WriteLine("The required wood legth is " + woodlength + " feet.");
            //    Console.WriteLine("The required glass area is " + glassarea + " sq feet.");

            //}

            //else
            //{


            //    woodlength = (height + width) * 2; //         in meters
            //    glassarea = height * width * 2;

            //    Console.WriteLine("The required wood legth is " + woodlength + " meters.");
            //    Console.WriteLine("The required glass area is " + glassarea + " sq meters.");


            //}




#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif


        //    int x = 200, y = 4;
        //    int count = 0;
        //    string[,] array = new string[x, y];

        //    // Initialize the array:
        //    for (int i = 0; i < x; i++)

        //        for (int j = 0; j < y; j++)
        //            array[i, j] = (++count).ToString();

        //    // Read input:
        //    Console.Write("Enter the number to search for: ");

        //    // Input a string:
        //    string myNumber = Console.ReadLine();

          
        //    // Search:
        //    for (int i = 0; i < x; i++)
        //    {
        //        for (int j = 0; j < y; j++)
        //        {
        //            if (array[i, j].Equals(myNumber))
        //            {
        //                goto Found;
        //            }
        //        }
        //    }

        //    Console.WriteLine("The number {0} was not found.", myNumber);
        //    goto Finish;

        //Found:
        //    Console.WriteLine("The number {0} is found.", myNumber);

        //Finish:
        //    Console.WriteLine("End of search.");


        //    // Keep the console open in debug mode.
        //    Console.WriteLine("Press any key to exit.");
        //    Console.ReadKey();


        }

    }


   
}
