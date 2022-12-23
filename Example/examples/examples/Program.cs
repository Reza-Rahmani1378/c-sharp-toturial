namespace examples
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Username :");

            string username = Console.ReadLine();

            Console.WriteLine("Username is :" + username);

            Console.WriteLine("Enter Your Age :");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is :" + age);
        }
    }
}