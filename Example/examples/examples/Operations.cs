int x = 5;
int y = 6;

Console.WriteLine(x > y);

/*
    Interpolation in String 
 */

string firstName = "Reza";
string lastName = "Anonymous";

string fullName = $"My full name is :{firstName} {lastName}";

Console.WriteLine(fullName);

/*
  Access The Strings 
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