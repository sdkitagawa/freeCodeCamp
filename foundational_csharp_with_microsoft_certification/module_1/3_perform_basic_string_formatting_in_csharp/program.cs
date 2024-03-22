// Character Escape Sequences
// \n - To add a New Line.
// \t - To add a Tab.
// \" - To add double-quotation marks.
// \\ - To add backslashes.
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("C:\\Program Files\\Folder");

// Verbatim String Literal
// Use @ to create a verbatim string literal before the literal string.
// Using @ before the string you won't need to escape the backslash characters.
Console.WriteLine(@"C:\Program Files\Folder");

// Using a directive you can also spans more than just one line.
Console.WriteLine(@"This is
        using a
                Directive");

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Concatenation in C#
// String and a Variable
// Basic Formula: ("String goes here" + variableName);
// Intermediate Formula: (variableName1 + "String goes here" + variableName2);
// Complex Formula: (variableName1 " this is the value: " + variableName2 + "!\nResult: \t" + variableName3);
string userLogin = "douglas.kitagawa@driftking.com";
string userPass = "d0ugl4sK1t4gaw4-DoNk3y_K0nG_Drift!King.";
Console.WriteLine("Your username is: " + userLogin + "\nYour password is: " + userPass);

// Combining String using String Interpolation
// Example: $"{variableBeingReferenced}"
// Note: It's like template literals from JavaScript or Format from Python.
// Example 1
string apiToken = "pAJO36RUQ3V6YUcCWuamEojXvWlMBcsIua";
Console.WriteLine("This is the API Token:\t" + $"{apiToken}");

// Example 2
bool userIsRegistered = true;
Console.WriteLine($"User register status:\t {userIsRegistered}\nUser Token:\t {apiToken}");

// Example 3
decimal dkOsVersion = 1.00m;
string hardCodedText = "Updating dkOS to dkOS Version: ";
Console.WriteLine($"{hardCodedText} {dkOsVersion}");

// Combining Verbatim Literals and String Interpolation
string projectFileName = "First-Project";
Console.WriteLine($@"C:\Output\{projectFileName}\Data");


