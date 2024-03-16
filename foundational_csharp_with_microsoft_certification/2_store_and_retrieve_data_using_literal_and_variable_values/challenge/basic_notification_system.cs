// Default Solution:
string userName = "Bob";
int unreadMessages = 3;
decimal weatherInformation = 34.4m;

Console.Write("Hello, ");
Console.Write(userName);
Console.Write("! You have ");
Console.Write(unreadMessages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(weatherInformation);
Console.Write(" celsius.");

// Faster Solution:
string userName = "Bob";
int unreadMessages = 3;
decimal weatherInformation = 34.4m;

Console.WriteLine("Hello " + userName + "! You have " + unreadMessages + " messages in your inbox. The temperature is " + weatherInformation + " celsius.");