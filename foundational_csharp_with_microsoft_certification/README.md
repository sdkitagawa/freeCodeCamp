# Using .NET C# on Visual Studio Code

- Download the latest `.NET SDK` <a href="https://dotnet.microsoft.com/en-us/download">here</a>.
- After downloading, install it.
- Once you have installed the `.NET SDK` open your Terminal and type the following command to make sure that the SDK has been successfully installed:

    ```terminal
    dotnet --version
    ```
- Use the command `code .` into your terminal.  
- With your Visual Studio Code opened press `CTRL` (Or `Cmd`) + `'` to open the Visual Studio Code terminal.
- Now navigate to the desired folder by using the `cd` (Change Directory) terminal command.
- Type the following command to create a new console application and be able to run your code:

    ```terminal
    dotnet new console -o ${appNameHere}
    ```

- You can use `dotnet run` to run your code.
- Download these Visual Studio Code Extensions: `C# Dev Kit`, `C#` and `IntelliCode for C# Dev Kit` all these extensions are provided by `Microsoft`.
- After installing those press `CTRL` (or `Cmd`) + `P` and type `> .NET Generate Assets for Build and Debug`.
- Now press `CTRL` (or `Cmd`) + `P` again and type `>.NET New Project`.
- Select the Type of the application and Directory.

**Note**: Replace the `${appNameHere}` with the name of your application.