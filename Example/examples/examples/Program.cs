using System.Collections.ObjectModel;
using System.Text;

namespace examples
{
    
    class Program
    {

        static StreamWriter streamWriter = new StreamWriter("log.txt");
      
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

            string nameClass = typeof(Program).Name;
            Console.WriteLine(nameClass);

            division(1, 0);

        }

        public static void Log(String message)
        {
            lock (streamWriter)
            {
                try 
                {
                    streamWriter.WriteLine(message);
                }

                    catch (Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                finally 
                { 
                    streamWriter.Flush();
                }
            }
        }

        public static void division(int num1 , int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            } 
            catch(DivideByZeroException e)
            {
                joinStringMessages(e, 100, "Mem Error");
                Console.WriteLine($"Exception caught:{e.Message}");
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        public static void joinStringMessages(Exception ex , int code , string message)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("***********Start Log For Exception*********").
                AppendLine($"The Code is :{Convert.ToString(code)}")
                  .AppendLine($"The Messages is :{message}")
                  .AppendLine($"The Message Exception :{ex.Message}")
                  .AppendLine($"The Stack Trace Of Exception :{ex.StackTrace}")
                  .AppendLine("***********End Log For Exception*********");

             Console.WriteLine(result.ToString());
        }
    }
}