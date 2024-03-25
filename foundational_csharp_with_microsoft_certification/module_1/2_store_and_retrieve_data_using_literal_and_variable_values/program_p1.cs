// Data Types in C#
// This data type is officially named "char", but frequently referred to as a "character";
// You must use single quotation marks to create a char just like C/C++, otherwise it's a string data type.
// This is a Char Data Type:
Console.WriteLine('c');

// This is a String Data Type:
Console.WriteLine("This is a string");

// If you want to display a numeric whole number (no fractions) value in the output console, you can use an int literal. The term int is short for integer.
Console.WriteLine(123456);

// Literal Suffixes
// Literal Suffixes are characters that you append to the end of a value telling the compiler that you want to work with a certain value;
// Literal Suffixes could be lower-case or upper-case. 
// Float Literal Suffix: F/f
// Decimal Literal Suffix: M/m

// The first Literal Suffix is the Float one.
Console.WriteLine(0.12F);

// The second is the Double one.
Console.WriteLine(1.500);

// The last but not least is Decimal.
Console.WriteLine(30.300m);

// Boolean Literals are basically true or false values;
// Boolean Literals are represented by the bool term as a short for Boolean;
// Boolean Literals are Case Sensitive, you should always use lower-case characters for it.
Console.WriteLine(true);
Console.WriteLine(false);

/*
 Literal ➝ Hard-Coded Values ➝ Constant and Unchanged throughout the execution of the program.
 Hard-Coded: Console.WriteLine("Hello user!");
 A variable name is a human-friendly label that the compiler assigns to a memory address;
 i.e Memory Address ➝ "0x757365724E616D65" ➝ Variable Assigned to that Address ➝ "userName".
 Non Hard-Coded: string userName = 

 How to name your variables properly
 - Name your variables using Camel Case Notation (thisIscamelCase);
 - Use alphanumeric characters and underscore character (for special cases);
 - No special characters like: @, #, $, %, !;
 - Names must begin with an alphabetical letter or an underscore not a number;
 - Variable names are case-sensitive;
 - Don't use contractions or abbreviations.
 - Don't include the data type of the variable name when using coding in typed languages (C#, C/C++, Java).
   - It can be useful in JavaScript though.
 - Variable names should be descriptive and meaningful.
 - Variables can't be a keyword reserved by the programming language built-in functions or such.

 Creating a string variable:
*/

char userOption = "a";

string userName = "Hello World";

int userAge = 30;

decimal userWeight = 1.200m;

float weatherCalc = 1.2000f;

double quanticData = 5.950642324541561887789789151351564;

bool userAnswer = true;
