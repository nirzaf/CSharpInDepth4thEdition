using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Chapter09
{
    [Description("Listing 9.7")]
    class SqlInjection
    {
        static void Main()
        {
            var connectionString = "not a real database";
            int userId = 15; // Determined elsewhere. Assume this is valid.
            var tag = Console.ReadLine();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = $@"SELECT Description FROM Entries
                                WHERE Tag='{tag}' AND UserId={userId}";
                using (var command = new SqlCommand(sql, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Use the data
                    }
                }
            }
        }
    }
}
