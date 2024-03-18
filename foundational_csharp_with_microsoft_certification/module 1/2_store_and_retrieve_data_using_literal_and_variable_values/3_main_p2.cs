// Variable Declaretion
// ➝ To declare a variable, enter the data type you want to use followed by a name for the variable;
// ➝ To assign a value to a variable, use the assignment operator ( = );
// ➝ Variable assignment happens from right to left.
// ➝ You can't use a variable before setting a variable to a value.
// For Example:
// `Console.WriteLine(myVariable);`
// `string myVariable;`

string userName;
userName = "Douglas";
Console.WriteLine(userName);

// You can re-assign a new value to your variable
userName = "Kitagawa";
Console.WriteLine(userName);
userName = "Link";
Console.WriteLine(userName);
userName = "Zelda";
Console.WriteLine(userName);

// Setting up and properly initializing a variable:
string fullName = "Douglas Vanelli Kitagawa";
Console.WriteLine(fullName);

// Implicitly Typed Local Variables
// Use the var keyword to create a local variable;
// This is going to be interpreted as a string variable and cannot be changed during the code;
// You can also use var when you begin developing a new thing and don't immediately know what data type to use.
var myMessage = "This is a local variable";
