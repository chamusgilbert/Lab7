using System;
using System.Collections.Generic;
namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodOrHome();


        }
        public static void FoodOrHome()
        {
            int i = 1;
            List<string> aaron = new List<string>();
            aaron.Add("Hart, MI");
            aaron.Add("Ribeye");
            List<string> adam = new List<string>();
            adam.Add("Grand Rapdis, MI");
            adam.Add("Putine");
            List<string> albert = new List<string>();
            albert.Add("Grand Rapids, MI");
            albert.Add("Pounded Potatoes and Beans");
            List<string> andrew = new List<string>();
            andrew.Add("Fremont, IN");
            andrew.Add("Steak");
            List<string> chamus = new List<string>();
            chamus.Add("Zeeland, MI");
            chamus.Add("Sushi");
            List<string> david = new List<string>();
            david.Add("Fort Wayne, IN");
            david.Add("Lasagna");
            List<string> ian = new List<string>();
            ian.Add("Allendale, MI");
            ian.Add("Alfredo");
            List<string> jonathan = new List<string>();
            jonathan.Add("Middleville, MI");
            jonathan.Add("Stouts");
            List<string> kevin = new List<string>();
            kevin.Add("Chicago, IL");
            kevin.Add("Oatmeal");
            List<string> marshal = new List<string>();
            marshal.Add("Holland, MI");
            marshal.Add("Burgers");
            List<string> tommy = new List<string>();
            tommy.Add("Raleigh, NC");
            tommy.Add("Chicken Curry");


            System.Console.WriteLine("Hello, Welcome to the classroom! Who would you like to get to know?");
            System.Console.WriteLine("");
            System.Console.WriteLine("Tommy is the teacher, there is also Aaron, Kevin, Adam, Marshall, Albert, Chamus, Jonathan, Andrew, Ian, and David.");
            string classMate = Console.ReadLine().ToLower();
            CheckName(classMate);
            Console.WriteLine("Thanks, would you like information on their Hometown? or their Favorite Food?");
            string information = Console.ReadLine().ToLower();
            CheckInfo(information);

            if (information == "hometown" || information == "home town" || information == "home")
            {
                i = 0;
            }

            if (classMate == "tommy")
            {
                if (i == 1)
                {
                    tommy.Reverse();
                }
                foreach (var item in tommy)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "aaron")
            {
                if (i == 1)
                {
                    aaron.Reverse();
                }
                foreach (var item in aaron)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "kevin")
            {
                if (i == 1)
                {
                    kevin.Reverse();
                }
                foreach (var item in kevin)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "adam")
            {
                if (i == 1)
                {
                    adam.Reverse();
                }
                foreach (var item in adam)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "marshall")
            {
                if (i == 1)
                {
                    marshal.Reverse();
                }
                foreach (var item in marshal)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "albert")
            {
                if (i == 1)
                {
                    albert.Reverse();
                }
                foreach (var item in albert)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "chamus")
            {
                if (i == 1)
                {
                    chamus.Reverse();
                }
                foreach (var item in chamus)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "jonathan")
            {
                if (i == 1)
                {
                    jonathan.Reverse();
                }
                foreach (var item in jonathan)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "andrew")
            {
                if (i == 1)
                {
                    andrew.Reverse();
                }
                foreach (var item in andrew)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "ian")
            {
                if (i == 1)
                {
                    ian.Reverse();
                }
                foreach (var item in ian)
                {
                    Console.WriteLine(item);
                    break;
                }

            }
            if (classMate == "david")
            {
                if (i == 1)
                {
                    david.Reverse();
                }
                foreach (var item in david)
                {
                    Console.WriteLine(item);
                    break;
                }

            }

            ContinueInfo();

        }
        public static void CheckName(string classMate)
        {
            if (classMate == "tommy" || classMate == "aaron" || classMate == "kevin" || classMate == "adam" || classMate == "marshal" || classMate == "albert" || classMate == "chamus" || classMate == "jonathan" || classMate == "andrew" || classMate == "ian" || classMate == "david")
            {
                return;
            }
            else
            {
                Console.WriteLine("You have entered an incorrect name");
                FoodOrHome();
            }
        }
        public static void CheckInfo(string information)
        {
            if (information == "hometown" || information == "home town" || information == "home" || information == "food" || information == "favorite food")
            {
                return;
            }
            else
            {
                Console.WriteLine("I'm afraid that information is classified");
                FoodOrHome();
            }
        }
        public static void ContinueInfo()
        {

            Console.WriteLine("Would you like for information?");
            string more = Console.ReadLine().ToLower();
            if (more == "yes" || more == "y")
            {
                FoodOrHome();
            }
            else
            {
                Console.WriteLine("Goodbye");
                return;
            }
        }
    }
}
