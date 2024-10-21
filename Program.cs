namespace Uke_2;

class Program
{
    static void Main(string[] args)
    {
        // creating a new instance of the IOHandler class
        IOHandler iOHandler = new IOHandler();

        Console.WriteLine("Choose which file you want to open:\n");

        string? filePath = Console.ReadLine();

        Console.WriteLine("Write something to a text file:\n");
        string? textContent = Console.ReadLine();

        // created the filePath variable, to handle the user-input for each file

        if (string.IsNullOrWhiteSpace(filePath) && string.IsNullOrWhiteSpace(textContent))
        {
            throw new IOException();
        }

        iOHandler.ReadFile(filePath);

        iOHandler.WriteToFile(filePath, textContent);
    }
}
