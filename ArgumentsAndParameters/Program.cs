
Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyword(userInput);  //userInput = argument


static void PrintAnyword(string anyString) //anyString = parameter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}