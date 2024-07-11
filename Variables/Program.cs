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

// fullName = Console.ReadLine();
// We have a warning => we can use fullName = Console.ReadLine() ?? "Default Name"; to solve it
// Console.WriteLine($"Hello {fullName}");


// ============================== Types ============================================================================
/* Intro:
 *      - In the following example, I use two literals of type int: 12 and 30
 *      - I declare a variable of type int: x
*/
int x = 12 * 30;
Console.WriteLine(x);
// System.Console.WriteLine(x); // WrtieLine is the method in the class Console, wich is defined in a namespace called system.

/* All values in C# are instances of a type
 * All c# types fall into the following categories:
 *      - Value types
 *      - Reference types
 *      - Generic type parameters
 *      - Pointer types
 */


/* ==== Value types vs reference types =====
 * The content of a value type variable or constant is simply a value.
 * Value types:
 *  - Value types are stored in the stack. This is a region of memory that is organized in a last-in-first-out (LIFO) manner. 
 *  - They occupy precisely the memory required to store their fields.
 *  - Each value type variable contains its own data directly.
 *  - When you assign one value type variable to another, a copy of the value is made. Changes to one variable do not affect the other.
 *  - Value types are generally faster to access because they are stored on the stack, which has fast access time.
 *  - Primitive data types such as int, float, double, bool, char. Structs (including user-defined structs like Point).
 *  - Example: 
 *          * public struct Point { public int X; public int Y; } // public struct Point { public int X, Y; }  Structures (structs) in C# are value types that can contain data and methods. 
 * Reference types:
 *  -  Reference types are stored in the heap. The stack contains a reference (pointer) to the actual data, which resides in the heap.
 *  -  When you assign one reference type variable to another, you copy the reference, not the actual object. Both variables then refer to the same object. 
 *  - Changes made through one variable will be reflected in the other.
 *  -  Accessing data through references can be slower due to the additional layer of indirection (following the reference to the heap). 
 *  - However, reference types are more flexible and can represent more complex data structures.
 *  - Classes, arrays, delegates, strings.
 *  - Example:
 *          * public class PointClass { public int X; public int Y; }
 *
 */

// ==== Predefined Types ===

/* Value types:
 *  - Numeric:
 *      + Signed integer (sbyte, short, int, long)
 *      + Unsigned integer (byte, ushort, uint, ulong)
 *      + Real number (float, double, decimal)
 *  - Logical (bool)
 *  - Character (char)
 *  
 *  Reference types:
 *  - String (string)
 *  - Object (object)
 * 
 */


// ================================ Numeric Values ============================================
/* Numeric Literals: Numeric literals in C# represent fixed values directly written in the code that correspond to numbers. 
 * 
 *  - Integer Literals: Integer literals represent whole numbers.
 *      + Decimal:Regular numbers without a prefix. int decimalNumber = 1234;
 *      + Hexadecimal: Prefixed with 0x or 0X. int hexNumber = 0x1A3F;
 *      + Binary: Prefixed with 0b or 0B. int binaryNumber = 0b1010;
 *      + Underscore in Literals: For better readability, underscores can be used to separate digits. int largeNumber = 1_000_000; 
 *      
 * - Floating-Point Literals: Floating-point literals represent numbers with fractional parts.      
 *      + Decimal: Without any suffix, considered as double by default. double decimalDouble = 1234.56;
 *      + Scientific Notation: Uses e or E to denote the power of 10. double scientificNotation = 1.23e4; // 1.23 × 10^4
 * 
 * - Suffixes for type Specification:
 *      + f or F for float.
 *      + d or D for double (optional as double is the default).
 *      + m or M for decimal.
 *      
 */

x = 1_000_000;
Console.WriteLine(x);
// Getting the type of the variable x
Console.WriteLine(x.GetType()); // Output: System.Int32

// float myFloat = 4.7; Output: error CS0664: Literal of type double cannot be implicitly converted to type 'float'; use an 'F' suffix to create a literal of this type

float myFloat = 4.7f;
Console.WriteLine(myFloat);

//======== Numeric conversions ===============

// Converting between integral types 
// Integral type conversions are implicit when the destination type can represent every
// possible value of the source type. Otherwise, an explicit conversion is required;


int x = 12345; // int is a 32-bit integer
long y = x; // Implicit conversion to 64-bit integral type
short z = (short)x; // Explicit conversion to 16-bit integral type

