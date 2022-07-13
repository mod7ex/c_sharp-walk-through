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

            // ---------------------------------- Math stuff ----------------------------------

            Console.WriteLine(Math.Pow(4, 2)); // 16
            Console.WriteLine(Math.Sqrt(16)); // 4
            Console.WriteLine(Math.Abs(-100)); // 100
            Console.WriteLine(Math.Round(3.7)); // 4
            Console.WriteLine(Math.Floor(3.7)); // 3
            Console.WriteLine(Math.Ceiling(3.3)); // 4
            Console.WriteLine(Math.Max('a', 'b')); // 98 <--> b
            Console.WriteLine(Math.Min('a', 'b')); // 97 <--> a

            // Random numbers
            Random ran = new Random();
            Console.WriteLine(ran.Next(1, 7));
            Console.WriteLine(ran.NextDouble()); // 0<= x <1


            // Exo
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The hypotenus is: " + c);

            // ---------------------------------- String methods ----------------------------------
            string my_full_name = "Mourad ELCADI";
            string my_phone_number = "123-456-7890";
            string my_username = "modex";

            Console.WriteLine(my_full_name + " --> " + my_full_name.ToUpper());
            Console.WriteLine(my_full_name + " --> " + my_full_name.ToLower());
            Console.WriteLine(my_phone_number + " --> " + my_phone_number.Replace('-', '/'));
            Console.WriteLine(my_username + " --> " + my_username.Insert(0, "@"));
            Console.WriteLine(my_username + " has length of " + my_username.Length);

            string my_first_name = my_full_name.Substring(0, 6);
            string my_last_name = my_full_name.Substring(7, 6);

            Console.WriteLine("my first name " + my_first_name);
            Console.WriteLine("my last name " + my_last_name);

            // ---------------------------------- If statements ----------------------------------
            Random my_ran = new Random();
            
            if(my_ran.NextDouble() * 10 > 5) 
            {
                Console.WriteLine("You got a number higher than 5");
            }
            else
            {
                Console.WriteLine("You got a number less or equale to 5");
            }

            // ---------------------------------- Rock-Paper-Scissors ----------------------------------

            Random randy = new Random();
            bool playAgain = true;
            string player = "";
            string computer = "";
            string answer = "";

            while(playAgain) 
            {
                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter Rock, Paper, or Scissors: ");
                    player = Console.ReadLine()!;
                    player = player.ToUpper();
                }

                switch (randy.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    default:
                        computer = "SCISSORS"; // default is 3
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if(computer == "ROCK") { Console.WriteLine("It's a draw!"); }
                        else if(computer == "PAPER") { Console.WriteLine("You lose!"); }
                        else { Console.WriteLine("You win!"); }
                        break;
                    case "PAPER":
                        if(computer == "ROCK") { Console.WriteLine("You win!"); }
                        else if(computer == "PAPER") { Console.WriteLine("It's a draw!"); }
                        else { Console.WriteLine("You lose!"); }
                        break;
                    case "SCISSORS":
                        if(computer == "ROCK") { Console.WriteLine("You lose!"); }
                        else if(computer == "PAPER") { Console.WriteLine("It's a win!"); }
                        else { Console.WriteLine("It's a draw!"); }
                        break;
                }

                Console.Write("Would you like to play again ? (Y for yes): ");
                answer = Console.ReadLine()!.ToUpper();

                if(answer == "Y")  { player = ""; }
                else playAgain = false;
            }

            Console.WriteLine("Thanks for playing!");


            // ---------------------------------- Arrays ----------------------------------
            
            // Fixed size
            // string[] cars = { "BMW", "Mustang", "Mercides" };
            // or
            string[] cars = new string[3];
            cars[0] = "BMW";
            cars[1] = "Mustang";
            cars[2] = "Mercides";

            Random car_rand = new Random();
            Console.WriteLine(cars[car_rand.Next(0, cars.Length)]);
            cars[car_rand.Next(0, cars.Length)] = "Mourad Car";

            for(int i=0; i<cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.WriteLine("Using foreach!");

            foreach(string car in cars)
            {
                Console.WriteLine("foreach ==> " + car);
            }

            sayHappyBirthday("Mourad", 24);

            // ---------------------------------- params keyword ----------------------------------

            double sum = checkOut(1, 1.2, 2.365, 2, 55);


            // ---------------------------------- Try Catch ----------------------------------

            Console.WriteLine("Enter a dvider to get 1/x : ");

            int devider = Convert.ToInt32(Console.ReadLine());
            double result;

            try
            {
                result = 1/devider; // devider might be a string --> Exception
                Console.WriteLine("the fraction 1/" + devider + " is: " + result);
            }
            catch (System.DivideByZeroException e)
            {
                Console.WriteLine("You can't devide by 0 Ediot!");
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Enter a valid number different than 0");
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Finally either code worked or not we're here");
            }

            */
        }

        private static void sayHappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birth day to you!");
            Console.WriteLine("Happy birth day to you!");
            Console.WriteLine("Happy birth day dear " + name);
            Console.WriteLine("Happy birth day to you!");
            Console.WriteLine("You're " + age + " years old");
            Console.WriteLine();
        }

        
        private static double checkOut(params double[] arr)
        {
            double sum = 0;
            foreach(double item in arr)
            {
                sum += item;
            }

            return sum;
        }

    }
}
