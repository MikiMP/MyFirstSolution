namespace MySecondConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //float - precision 7 digits, number + f
            //double - precision 15-16 digits, number + d
            //decimal - precision 28-29 digits, number + m

            const double doublePiNumber = 3.141592653d;
            const decimal doubleENumber = 1.414213562373095048m;

            double pi = doublePiNumber;
            decimal e = doubleENumber;

            int a = 3;
            byte b = Convert.ToByte(a);

            double doubleArithmeticMean = 0.0;      //default double
            int[] arrayNumbers = new int[3];        //Without inicialization of array

            string stringFirstName = "";            //With inicialization "" Is it correct ?
            string stringGreeting  = "Hi ";         //Added space after word 'hi'

            Console.WriteLine("Please, type your name:");
            stringFirstName = Console.ReadLine();
            stringGreeting = String.Concat(stringGreeting, stringFirstName);

            Console.WriteLine(stringGreeting);


            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.WriteLine($"Please {stringFirstName} type number {i+1}");
                int.TryParse(Console.ReadLine(),out arrayNumbers[i]);
                doubleArithmeticMean += arrayNumbers[i];
            }
            doubleArithmeticMean = doubleArithmeticMean / arrayNumbers.Length;


            Console.WriteLine(" pi = {0}\n e = {1} ",pi,e) ;
            Console.WriteLine(" value int a = {0} \n value byte b = {1}",a,b);
            Console.WriteLine($" Number1 = {arrayNumbers[0]}; \n Number2 = {arrayNumbers[1]}; \n Number3 = {arrayNumbers[2]}; \n ");
            Console.WriteLine($" Arithmetic mean of numbers = {doubleArithmeticMean}");
            Console.WriteLine($" Your name is {stringFirstName}");

            Console.WriteLine(" Type any key to close this console app");
            Console.ReadKey();
        }
    }
}