public class IOHandler : IIOHandler
{
    public void AppendToFile(string path, string content)
    {
        try
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        File.AppendAllText(path, content);
    }

    public void ReadFile(string path)
    {
        string[] lines = File.ReadAllLines(path);
        try
        {
            foreach (string line in lines)
            {
                Console.WriteLine($"{line}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the content of the file {path} {ex}");
        }
    }

    public void WriteToFile(string path, string content)
    {
        try
        {
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
        File.WriteAllText(path, content);
    }
}