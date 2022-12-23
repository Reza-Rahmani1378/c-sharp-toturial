int x = 5;
int y = 6;

Console.WriteLine(x > y);

/*
 * Interpolation in String 
 */

string firstName = "Reza";
string lastName = "Anonymous";

string fullName = $"My full name is :{firstName} {lastName}";

Console.WriteLine(fullName);

/*
 * Access The Strings 
 */

string name = $"{firstName} {lastName}";

int charPos = name.IndexOf('A');

string lastName2 = name.Substring(charPos);

Console.WriteLine(lastName2);

/*
 * Special Characters
 */

string txt = "We are the so-called \"Vikings\" from the north.";

Console.WriteLine(txt);


/*
 * short hand if else statement
 */

int time = 18;

string result = (time < 18) ? "Good day." : "Good evening.";

Console.WriteLine(result);

/*
 * Switch Statement
 */

int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
   default:
        Console.WriteLine("Default");
        break;
}

/*
 * while and for and do/while loop
 */

int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

for(int j = 0; j < 5; j++)
{
    Console.WriteLine(j);
}

int k = 0;
do
{
    Console.WriteLine(k);
    k++;
}
while (k < 5);

/*
 * Foreach Loop 
 */
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string test in cars)
{
    Console.WriteLine(test);
}