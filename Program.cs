namespace Hobbies
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            var randomNumber = rand.Next(0, 5);
            string message = "";
            if (randomNumber == 0)
            {
                message = "din nye hobby er fisking";
            }
            else if (randomNumber == 2)
            {
                message = "din nye hobby er matlaging";
            }
            else if (randomNumber == 3)
            {
                message = "din nye hobby er musikk";
            }
            else if (randomNumber == 4)
            {
                message = "din nye hobby er gaming";

            }
            else if (randomNumber == 5)
            {
                message = "din nye hobby er Gandhi qoutes";

            }
            Console.WriteLine("Hva heter du?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hei {name} {message}");
        }
    }
}