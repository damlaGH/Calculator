namespace Calculator
{ 
    public class Program
    {
        public static void Main()
        {
            Menu();

        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Menu\n1.Sum\n2.Subs\n3.Multi\n4.Divide\n5.Exit");
            Choose();
        }
        static void Choose()
        {
            Console.Write("Please choose which action do you want: ");
            string chosen = Console.ReadLine();

            switch (chosen)
            {
                case "1":
                    Sum();
                    break;
                case "2":
                    Subs();
                    break;
                case "3":
                    Multi();
                    break;
                case "4":
                    Divide();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choosen is not valid!");
                    break;
            }
            Again();
        }
        static (double n1, double n2) takeNumbers()
        {
            Console.WriteLine("please write number 1:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please write number 2:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            return (n1, n2);
        }

        static void Sum()
            {   var operants = takeNumbers();
                double result = operants.n1 + operants.n2;
                Console.WriteLine($"result: {result}");
            }
        static void Subs()
            {
                var operants = takeNumbers();
                double result = operants.n1 - operants.n2;
                Console.WriteLine($"result: {result}");
            }
        static void Multi()
            {
                var operants = takeNumbers();
                double result = operants.n1 * operants.n2;
                Console.WriteLine($"result: {result}");
            }
        static void Divide()
            {
                var operants = takeNumbers();
                double result = operants.n1 / operants.n2;
                Console.WriteLine($"result: {result}");
            }
        static void Again()
            {
                Console.WriteLine("Do you want to make action again?:(Y/N)");
                string again = Console.ReadLine();
                switch (again)
                {
                    case "Y":
                    case "y":
                        Menu();
                        break;
                    case "N":
                    case "n":
                        Environment.Exit(0);
                        break;

                default:
                    Console.WriteLine("Chosen is not valid!");
                    Again();
                    break;
                }
            }
        }
  
    }


