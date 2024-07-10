// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello World!");

Console.WriteLine("My name is Jose");

/* To open a new terminal => ctrl + '
 *  To run the script dotnet run
 */

/*
 * using System; => allows the code to use classes and 
 *                  other types defined in the System namespace without needing to fully qualify their names. 
 * 
 * namespace consoleapp2 => defines a namespace named consoleapp2. Namespaces are used to organize code 
 *                          and prevent naming conflicts by grouping related classes, interfaces, and functions together.
 * {
 *      internal class Program =>  defines a class named Program with an access modifier internal.
 *      {
 *          static void Main(string[] args)
 *          {
 *              console.writeline("hello world!");
 *          }
 *      }
 * }
 */

// Creating my first variable

// string fullName = 'Jose'; No => ' ' is used for characters
string fullName = "Jose"; // OK

Console.WriteLine("Hello" + fullName); // No space

Console.WriteLine("Hello " + fullName); // Space after Hello

// Using string interpolation
Console.WriteLine($"Hello {fullName}");


// Interacting with terminal

Console.WriteLine("What is your name?");
fullName = Console.ReadLine();
// We have a warning => we can use fullName = Console.ReadLine() ?? "Default Name"; to solve it
Console.WriteLine($"Hello {fullName}");