using System.Collections.ObjectModel;

namespace examples
{
    
    class Program
    {
      
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Username :");

            string username = Console.ReadLine();

            Console.WriteLine("Username is :" + username);

            Console.WriteLine("Enter Your Age :");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is :" + age);

            /*
             * IReadOnlyDictionary Example
             */

            ReadOnlyDictionary<int, string> dict = new ReadOnlyDictionary<int, string>(new Dictionary<int , string>()
            {
                {1,username }
            }
                );

            string outUsername = dict.GetValueOrDefault(1, username);
            Console.WriteLine(outUsername);

        }
    }
}