namespace TollBoothApp.Core.Database
{
    internal class DatabaseConnectionException : Exception
    {
        public DatabaseConnectionException(string message) : base(message) { }
    }
}
