/*
    Calling different kinds of methods in the .NET Class Library

    To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName();
    The "." is the Member Access Operator (it is like the key to open the door);
    The "()" is the Method Invocation Operator (it is where you pass your arguments to the function);
    Variables/Values inside of a Class are Parameters;
    Variables/Values being passed by a Method Invocation Operator are Arguments.

    An instance of a Class is called Object;
    We use the "new" operator to create a new instance.

        Stateless vs. Stateful:
            - Stateless Definition:
                Stateless are methods that don't rely on the current state of the application to work properly. In other words they can work without referencing or changing any values already stored in memory.
            - Stateful Definition:
                Stateful are methods must have access to the state of the application to work properly. In other words are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed.

    The Class name is "Random" and we are creating and Object called "myDice" by using the "new" operator;
    Here we are creating an instance of a Class (an Object) for a Stateless Method (which is Random);
    The "new" operator does several important things:
    - It first requests an address in the computer's memory large enough to store a new object based on the Random class;
    - It creates the new object, and stores it at the memory address;
    - It returns the memory address so that it can be saved in the dice variable.

    We could improve Code Readability by removing the instanced Class's (the Object's) name after using the "new" operator, i.e:
        Random myDice = new Random();   | Default
        Random myDice = new();          | Readability Improved
*/
Random myDice = new();

// Creating an integer variable called "diceRoll" and using the previously instanced Object (called myDice) but this time using a Stateful method called "Next" that is completely dependant from the "diceRoll" value;
int diceRoll = myDice.Next(1, 7);
Console.WriteLine($"You rolled the number {diceRoll}");

/*
    As an alternative to searching through product documentation, you can attempt to access the method directly from the class itself. If it works, you know that it's a stateless method. The worst that can happen is that you'll get a compilation error.

    Try accessing the Random.Next() method directly and see what happens.

    This is going to throw an error:
*/
//int intentionalError = Random.Next(1, 7);
//Console.WriteLine($"This is your new try: {intentionalError}");

/*
    - A Return Value is a value type returned by a method;
    - Input Parameters are value types (or variables) inside a method;
    - An Overloaded Method is a method that supports several implementations of the method, each one with unique method signature.
    - IntelliSense can help developers to write code quickly.   

    Testing Next method Overloads
*/
Random newDice = new Random();
int firstRoll = newDice.Next();
int secondRoll = newDice.Next(101);
int thirdRoll = newDice.Next(50, 101);

Console.WriteLine($"First roll: {firstRoll}");
Console.WriteLine($"Second roll: {secondRoll}");
Console.WriteLine($"Third roll: {thirdRoll}");
