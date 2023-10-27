using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Using the .NET framework

namespace Voting_Application
{
    internal class voting_application
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[Online Voting Application]");
            
            Console.WriteLine("\nWelcome to the voting application!");
            
            Console.WriteLine("\nWe will ask you a series of questions to register you as a voter.");
            Console.Write("\nFirstly, what is your full name? - ");
            string name = Console.ReadLine();
            

            Console.Write("\n Hello, " + name + "! Next we will you for your DOB: ");
            string birth = Console.ReadLine();

            Console.Write("Okay! We have received your DOB as " + birth + ". Now, have you voted before (Y/N)? - ");
            string ans = Console.ReadLine();

            if (ans == "Y")
            {
                Console.Write("\nWhat party did you vote for (Democratic/Republican/Other)? - ");
                string party_type = Console.ReadLine();
            }

            if (ans == "N")
            {
                Console.Write("What party do you lean mostly towards (Democratic/Republican/Other? - ");
                string party2 = Console.ReadLine();
            }

            Console.Write("Lastly, please enter the county and state you reside in: ");
            string location = Console.ReadLine();

            Console.WriteLine("\nAnd that's all! You are sucessfully registered.)");
            Console.WriteLine("Here is the information you have recorded:");
            
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("DOB: " + birth);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Whether or not you have voted before: " + ans);

            Console.WriteLine("\nHave a great day!");
        }
    }
}
