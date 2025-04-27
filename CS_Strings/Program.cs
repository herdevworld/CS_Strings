/*
 * This project will help you practice strings, 
 * including concatenation, interpolation, 
 * accessing characters, and special characters.
 */

// 1. Strings
string firstName = "John";
string lastName = "Doe";
Console.WriteLine(firstName);
Console.WriteLine(lastName);

// 2. Concatenation
string fullName = firstName + " " + lastName;
Console.WriteLine("Full Name (Concatenation): " + fullName);

// 3. Interpolation
Console.WriteLine($"Welcome, {firstName} {lastName}!");

// 4. Access Strings (Indexing)
Console.WriteLine($"First letter of first name: {firstName[0]}");
Console.WriteLine($"Last letter of last name: {lastName[lastName.Length - 1]}");

// 5. Special Characters
Console.WriteLine("This is the first line.\n\tThis line is indented with a tab.");
Console.WriteLine("She said, \"C# is awesome!\"");

// Bonus Challenge
Console.WriteLine($"Hello!\nMy name is {firstName} {lastName}.\n\tI am learning C# and it's really \"fun\"!");