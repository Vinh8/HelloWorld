namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stg = "Hello World";
            Console.WriteLine(stg);
            Console.WriteLine("Enter Username");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter user's age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Username is "+ userName +" " + "Age is " + age);
        }
    }
}