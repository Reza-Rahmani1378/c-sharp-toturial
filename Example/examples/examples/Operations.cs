﻿int x = 5;
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