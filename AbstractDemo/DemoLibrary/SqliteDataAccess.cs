namespace DemoLibrary
{
    public class SqliteDataAccess : DataAccess
    {
        public override void LoadData(string sql)
        {
            System.Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            System.Console.WriteLine("Saving data to SQLite");
        }
    } 
}
