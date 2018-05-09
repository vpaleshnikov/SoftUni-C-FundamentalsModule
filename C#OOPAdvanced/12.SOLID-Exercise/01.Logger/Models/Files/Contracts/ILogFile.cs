namespace Problem1_Logger.Models.Files.Contracts
{
    public interface ILogFile
    {
        int Size { get; }

        void Write(string message);
    }
}