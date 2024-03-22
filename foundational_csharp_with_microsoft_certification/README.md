# Using .NET C# Visual Studio Code (Local Environment)

## Requirements
<details>
<summary>Downloads</summary>

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio Code](https://code.visualstudio.com/download)
- [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
- [C# DevKit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
- [IntelliCode for C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscodeintellicode-csharp)

</summary>
</details>


## Getting started
<ul>
    <li>Download the latest <code>.NET SDK</code>;</li>
    <li>After downloading, install it;</li>
    <li>Once you have installed the <code>.NET SDK</code> open your Terminal and type the following command to make sure that the SDK has been successfully installed:</li>
</ul>


---
    dotnet --version
---

<br />

- Use the command `code .` into your terminal;
- From now now on we are going to use `.NET CLI` to to create or build applications on C# using the Visual Studio Code IDE;
    - First run this command to create your first Console Application:
    ---

        dotnet new console -o ./cs_studies/first_project ${app_name}

    ---
    - The structure of must of the Terminal commands which includes the CLI commands Consists of the following three parts:
        - The driver: `dotnet` in this example;
        - The command: `new console` in this example;
        - The command arguments: `-o ./CsharpProjects/TestProject` in this example;
        - The optional command arguments: `${app_name}`;
        - **Note 1**: `./` means "in this folder" or "in this directory";
        - **Note 2**: Replace the `${appNameHere}` with the name of your application.

<br />

- Now that you understood how to use `CLI` it is time to generate your first console application, navigate to the desired folder for your project through the `Terminal` using these commands:
  - `cd` - *Change Directory*;
  - `cd ../` - *Change dir to a previous dir*;
  - `cd X` - *To change the disk*;
  - `ls` or `list` - *To check the files and folders present in the current directory*.

<br />

- The `CLI` command will create a template to create a **new C# console application project** in the specified folder by creating a **CSharp Project file** (`*.csproj`), and a **CSharp Program File** (`*.cs`) that you are going to use to write your code.
- Now open the **internal Terminal** from **Visual Studio Code** and make sure to navigate to the specified folder where it is located your project file.
  - **Note**: Before running a build or run command, you must ensure that the Terminal is open to your project folder.
- Now run the following command in Terminal:

    ---
        dotnet build
    ---

- The dotnet build command builds the project and its dependencies into a set of binaries. The `binaries`, the project's code in `Intermediate Language` (IL) files with a `*.dll` extension. Depending on the project type and settings, other files may also be included.
- To run your application, run the following command:

    ---
        dotnet run
    ---

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