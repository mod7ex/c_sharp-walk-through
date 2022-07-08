namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Console.Write("Hey !"); // no new line

            Console.WriteLine("Hello world !");
            Console.WriteLine("It's really good");
            Console.Beep();

            // Console.ReadKey();

            // ---------------------------------- Variables & Data types ----------------------------------

            Console.WriteLine("");

            int age = 24;
            Console.WriteLine(age);
            Console.WriteLine("Your age is; " + age);

            Console.WriteLine("");

            double fraction = 1.33333333333333333333333333; // 16 will be stored
            Console.WriteLine(fraction);
            Console.WriteLine("Fraction; " + fraction);

            Console.WriteLine("");

            float flt = 1.33333333333333333333333333F; // we use 'F' suffix to get literal float type
            Console.WriteLine(flt);
            Console.WriteLine("Float; " + flt);

            Console.WriteLine("");

            bool strong = true;
            Console.WriteLine(strong);
            Console.WriteLine("Are you strong ? so ... " + strong);

            Console.WriteLine("");

            char symbol = '@';
            Console.WriteLine(symbol);
            Console.WriteLine("A single character " + symbol);

            Console.WriteLine("");

            string name = "Mourad";
            Console.WriteLine(name);
            Console.WriteLine("A string " + name);

            // ---------------------------------- Constats ----------------------------------

            Console.WriteLine("");

            const string surname = "Mourad";
            Console.WriteLine(surname);
            Console.WriteLine("A string " + surname);

            // ---------------------------------- Type casting ----------------------------------

            Console.WriteLine("");
            
            double a = 1.49;
            Console.WriteLine(" ___ Type casting a to [int] is " + Convert.ToInt32(a));
            Console.Write("The type of 'a' is ");
            Console.WriteLine(a.GetType());
            Console.WriteLine(a.GetTypeCode());
            Console.WriteLine("Convert an int to double " + Convert.ToDouble(123));
            Console.WriteLine("Convert an int to string " + Convert.ToString(123).GetTypeCode());

            Console.WriteLine("");

            string someStr = "f";
            Console.WriteLine("String to single character; " + Convert.ToChar(someStr));
            Console.WriteLine("String to boolean; " + Convert.ToBoolean("false")); // only "true" & "false" can be converted to boolean

            */

            // ---------------------------------- User input ----------------------------------

            Console.WriteLine("What is your name ? ");
            string? user_name = Console.ReadLine();
            // var user_name = Console.ReadLine();

            Console.WriteLine("What is your age ? ");
            var user_age = Convert.ToInt32(Console.ReadLine()); // this might throw an Exception
            // int user_age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(user_age.GetTypeCode());
            Console.Write("Hello " + user_name);
            Console.WriteLine(", you're " + user_age);

            // Console.ReadKey();
        }
    }
}
