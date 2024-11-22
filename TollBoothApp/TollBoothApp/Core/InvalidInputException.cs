namespace TollBoothApp.Core
{
    internal class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message) { }
    }
}
