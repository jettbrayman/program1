namespace program1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Whats your name?");
            /*writes to the console*/

            String fName = Console.ReadLine();
            /*reads user input and assigns it to the variable being declared*/

            Console.WriteLine("Last name?");

            String lName = Console.ReadLine();

            Console.WriteLine("first number");
            int x = int.Parse(Console.ReadLine());
            /*parses input to a integer*/

            Console.WriteLine("second number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("third number");
            int z = int.Parse(Console.ReadLine());

            int a = x + y +z;
            /*sets variable to sum*/

            Console.WriteLine($"x - y = {x - y}");
            /*writes sum after being made*/

            int b = x * z;
            Console.WriteLine($"a / y = {a / y}");

            Console.WriteLine($"x % b = {x % b}");
                
            Console.WriteLine($"variables: fName = {fName} lName = {lName} x = {x} y = {y} z = {z} a = {a} b = {b}");
            /*writes all variables*/


        }
    }
}
