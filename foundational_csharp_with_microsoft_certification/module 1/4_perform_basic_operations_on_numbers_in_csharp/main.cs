// Perform addition with implicit data conversion
int firstNumber = 10;
int secondNumber = 15;
Console.WriteLine(firstNumber + secondNumber);

// Mixing data types to force implicit type conversions with concatenation
string firstName = "Douglas";
int widgetsSold = 10;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

// Mixing data types with concatenation and adding numbers
string lastName = "Kitagawa";
int graphicsProcessingUnits = 12;
Console.WriteLine(lastName + " sold " + graphicsProcessingUnits + 5 + " GPUs.");

// Adding parenthesis to clarify your intention to the compiler
string middleName = "Vanelli";
int kitchenFurniture = 25;
Console.WriteLine(middleName + " sold " + (kitchenFurniture + 5) + " widgets.");

/*
 Performing basic math operations
 + : Addition operator
 - : Subtraction operator
 * : Multiplication operator
 / : Division operator
*/
int operationAddition = 5 + 13;
int operationSubtraction = 10 - 5;
int operationMultiplication = 2 * 1;
int operationDivision = 12 / 4;

Console.WriteLine("Sum: ", operationAddition);
Console.WriteLine("Difference: ", operationSubtraction);
Console.WriteLine("Product: ", operationMultiplication);
Console.WriteLine("Quotient: ", operationDivision);

// Mixing data types with Decimal, Float and Double
decimal decimalQuotient = 7.0m / 5;
float floatQuotient = 7.0f / 5;
double doubleQuotient = 7.0 / 5;

Console.WriteLine($"Decimal quotient: {decimalQuotient}");
Console.WriteLine($"Float quotient: {floatQuotient}");
Console.WriteLine($"Double quotient: {doubleQuotient}");

// Add code to cast results of integer division
int numberOperationA = 7;
int numberOperationB = 5;
decimal anotherQuotient = (decimal)numberOperationA / (decimal)numberOperationB;
Console.WriteLine(decimalQuotient);

// % : Modulus operator
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

/*
 Operation Priority
 1 - Parenthesis (whatever is inside the parenthesis is performed first)
 2 - Exponents
 3 - Multiplication and Division (from left to right)
 4 - Addition and Subtraction (from left to the right)
*/
int firstValue = 3 + 4 * 5;
int secondValue = (3 + 4) * 5;
Console.WriteLine(firstValue);
Console.WriteLine(secondValue);

/*
 Incrementing and Decrementing Values with Increment and Decrement Operators in C#
 - Pre/Post Increment/Decrement Operators

 thisThing = 0
 thisThing = thisThing +5;    ➝ Output: 5
 thisThing += 5;              ➝ Output: 10
 thisThing++;                 ➝ Output: 11
 thisThing = thisThing - 1;   ➝ Output: 10
 thisThing--;                 ➝ Output: 5
 thisThing -= 5;              ➝ Output: 
*/
int someValue = 0;
someValue = someValue + 5;
Console.WriteLine("First increment: " + someValue + " (0 + 5)");
someValue += 5;
Console.WriteLine("Second increment: " + someValue + " (5 + 5)");
someValue++;
Console.WriteLine("Third increment: " + someValue + " (10 + 1)");
someValue = someValue - 1;
Console.WriteLine("First decrement: " + someValue + " (11 - 1)");
someValue--;
Console.WriteLine("Second decrement: " + someValue + " (10 - 1)");
someValue -= 5;
Console.WriteLine("Third decrement: " + someValue + " (9 - 5)");

/*
 Positioning Increment and Decrement Operators including Concatenation and String Interpolation
 Remember String Interpolation it's sort of equivalent to:
.---------------------------------------------------.
| Format:                          |     Python     |
| Template Literals:               |     JavaScript |
| Format / Positional Arguments:   |      C/C++     |
*---------------------------------------------------*
*/
int thisValue = 1 ;
thisValue++;
Console.WriteLine("First value: " + thisValue);
Console.WriteLine($"Second value: {thisValue++}");
Console.WriteLine("Third value: " + thisValue);
Console.WriteLine("Fourth value: " + (++thisValue));
