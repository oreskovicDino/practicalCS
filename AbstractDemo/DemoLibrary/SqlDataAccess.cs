namespace DemoLibrary
{
    public class SqlDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (from SqlData)";
            return output;
        }

        public override void LoadData(string sql)
        {
            System.Console.WriteLine("Loading Microsoft SQL Data");
        }

        public override void SaveData(string sql)
        {
            System.Console.WriteLine("Saving data to Microsoft SQL Server");
        }
    }
}
