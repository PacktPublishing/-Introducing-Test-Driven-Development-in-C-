using System;
using System.Configuration;
using System.Data.SqlClient;

namespace NoSRP
{
    public class SqlEntityDataHandler
    {
        public void ReadProcessUpdate()
        {
            var connectionString = ConfigurationManager.AppSettings["connectionString"];
            int currenValue = 0;
            int type = 0;

            Console.WriteLine("Enter new value:");
            int newValue = Convert.ToInt32(Console.ReadLine());

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                try
                {
                    using (var readCommand = new SqlCommand("select * from Entity", sqlConnection))
                    {
                        var reader = readCommand.ExecuteReader();
                        while (reader.Read())
                        {
                            currenValue = reader.GetInt32(0);
                            type = reader.GetInt32(0);
                        }
                        reader.Close();
                    }

                    switch (type)
                    {
                        case 1:
                            newValue *= 2;
                            break;
                        case 2:
                            newValue *= 3;
                            break;
                        default:
                            break;
                    }

                    using (var updateCommand = new SqlCommand(String.Format("update Entity set Data = {0} where Data = {1}", newValue, currenValue), sqlConnection))
                    {
                        updateCommand.ExecuteNonQuery();
                    }

                    Console.WriteLine("Data successfuly modified!");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to modify data");
                }
            }
        }
    }
}
