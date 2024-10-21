public interface IIOHandler
{
    /// <summary>
    /// A method that can read a variety of different files and prints the output to the console
    /// </summary>
    /// <param name="path">the current working directory ./{$unixpath}, {windows drive}:\{dir}</param>
    public void ReadFile(string path);

    /// <summary>
    /// A method that can write to a variety of different files, the write call in the I/O class, overrides each file it writes to
    /// </summary>
    /// <param name="path">the current working directory ./{$unixpath}, {windows drive}:\{dir}</param>
    /// <param name="content">the content of the given file opened with the I/O stream</param>
    public void WriteToFile(string path, string content);

    /// <summary>
    /// A method that appends text to a given file
    /// </summary>
    /// <param name="path">the current working directory ./{$unixpath}, {windows drive}:\{dir}</param>
    /// <param name="content">the content of the given file opened with the I/O stream</param>
    public void AppendToFile(string path, string content);
}