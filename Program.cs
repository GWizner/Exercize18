public class Program
{
    public static void Main(string[] parameters)
    {

        int userInt = 0;
        string yes = "yes";
        string y = "y";
        bool keepOn = true;
        

        var sumInt = new List<int>();
        while (keepOn)
        {
            Console.WriteLine("Please enter an integer: ");
            string userIn = Console.ReadLine();
            Console.WriteLine();
            bool userInput = false;
            userInput = int.TryParse(userIn, out userInt);
            

            if (userInput)
            {
                
                for (int currInt = 0; currInt < userInt; currInt++)
                
                {
                    
                    sumInt.Add((int)currInt + 1);
                    
                   
                }
                int sum = sumInt.Sum();
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine($"Unrecognized input {userIn}. Please enter an integer.");
            }

            Console.WriteLine();
            Console.WriteLine("Continue (y/n)? ");
            string userAns = Console.ReadLine().ToLower();
            userAns.Trim();
            userAns = userAns.Trim();
            Console.WriteLine();

            if (userAns == y || userAns == yes)
            {
                keepOn = true;
                sumInt.Clear();
            }
            else
            {
                keepOn = false;
            }
        }
    }
}