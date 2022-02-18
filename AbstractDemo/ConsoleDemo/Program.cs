namespace ConsoleDemo
{
    using DemoLibrary;
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> database = new List<DataAccess>()
            {
                new SqlDataAccess(),
                new SqliteDataAccess(),
            };

            foreach (var db in database)
            {
                //db.LoadConnectionString("demo");
                //db.LoadData("select * from table");
                //db.SaveData("insert into table");

                Console.WriteLine(db.LoadConnectionString("Demo"));

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
