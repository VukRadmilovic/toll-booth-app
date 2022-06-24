using NaplataPutarine.Core.Database;

namespace NaplataPutarine.Core
{
    public abstract class Repository
    {
        protected DatabaseConnection database { get; }

        public Repository()
        {
            database = DatabaseConnection.GetInstance();
        }

    }
}
