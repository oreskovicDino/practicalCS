namespace DemoLibrary
{
    public abstract class DataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            System.Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
    }
}
