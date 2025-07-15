using System.Text;

namespace RandomDataGenerator
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Magenta;

            while (true)
            {
                Console.WriteLine("Enter Option:");
                Console.WriteLine("1- Generate Random Numbers\t\t 2- Generate Random String");
                string SelectedOption = Console.ReadLine();
                if (SelectedOption == "1")
                    GenerateRandomNumbers();
                else if (SelectedOption == "2")
                    GenerateRandomStrings();
                else
                {
                    Console.WriteLine("InvlaidInput.....Try Agine !!!");
                }
                Console.WriteLine("==================================");
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void GenerateRandomNumbers()
        {
            var rmd = new Random();
            Console.WriteLine("Enter Min & Max ");
            int minNumber = int.Parse(Console.ReadLine());
            int maxNumber = int.Parse(Console.ReadLine());

            var value = rmd.Next(minNumber, maxNumber);
            Console.WriteLine($"Random Number is: {value}");
        }

        private const string BufferCapital = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string BufferSmall = "abcdefghijklmnopqrstuvwxyz";
        private const string BufferNumber = "0123456789";
        private const string BufferSymbols = "~!@#$%^&*()";


        static void GenerateRandomStrings()
        {
            var sb = new StringBuilder();
            var rmd = new Random();

            Console.WriteLine("Emter the length of string:");
            int lengthOfString = int.Parse(Console.ReadLine());

            Console.WriteLine("1- CapitalLatter\t\t 2-SmallLatter\t\t 3-Numbers\t\t 4-Symbols");
            string selectedRandom = Console.ReadLine();

            while (sb.Length < lengthOfString)
            {
                if (selectedRandom == "1")
                {
                    var randomIndex = rmd.Next(0, BufferCapital.Length - 1);
                    sb.Append(BufferCapital[randomIndex]);
                }
                else if (selectedRandom == "2")
                {
                    var randomIndex = rmd.Next(0, BufferSmall.Length - 1);
                    sb.Append(BufferSmall[randomIndex]);
                }
                else if (selectedRandom == "3")
                {
                    var randomIndex = rmd.Next(0, BufferNumber.Length - 1);
                    sb.Append(BufferNumber[randomIndex]);
                }
                else if (selectedRandom == "4")
                {
                    var randomIndex = rmd.Next(0, BufferSymbols.Length - 1);
                    sb.Append(BufferSymbols[randomIndex]);
                }
                else
                {
                    Console.WriteLine("Invalid Input...Try Again !!!");
                }


            }

            Console.WriteLine($"Random String is : {sb}");
        }


    }

}

