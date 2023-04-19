Console.WriteLine("Are you coming or leaving? (in/out):");
String userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();

}


static void PrintHello() //funtion / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator.");
}