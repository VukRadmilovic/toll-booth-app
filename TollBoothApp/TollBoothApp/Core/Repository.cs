using TollBoothApp.Core.Database;

namespace TollBoothApp.Core
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
