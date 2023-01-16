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
            MessageColor("Menu\n1.Sum\n2.Subs\n3.Multi\n4.Divide\n5.Exit", ConsoleColor.Yellow);
            Choose();
        }
        static void Choose()
        {
            MessageColor("Please choose which action do you want: ",ConsoleColor.DarkCyan);
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
            MessageColor("please write number 1:", ConsoleColor.Magenta);
            double n1 = Convert.ToDouble(Console.ReadLine());
            MessageColor("please write number 2:",ConsoleColor.DarkRed);
            double n2 = Convert.ToDouble(Console.ReadLine());

            return (n1, n2);
        }
        static void Sum()
        {
            var operants = takeNumbers();
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
            MessageColor($"result: {result}",ConsoleColor.Green);
        }
        static void Divide()
        {
            var operants = takeNumbers();
            double result = operants.n1 / operants.n2;
            MessageColor($"result: {result}", ConsoleColor.Blue);
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
        static void MessageColor(string message, ConsoleColor messageColor)
        {
            Console.ForegroundColor = messageColor;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}


