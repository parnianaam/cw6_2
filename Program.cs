// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void PrintMessage(string message)
{
    if(message.Length<5)
    {
        Console.WriteLine("Invalid");

    }
    else
    {
        Console.WriteLine($"* {message} *");
    }
}
