using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using static System.FormattableString;

namespace Chapter09
{
    [Description("Listing 9.9")]
    public static class SqlFormattableString
    {
        public static SqlCommand NewSqlCommand(
            this SqlConnection conn, FormattableString formattableString)
        {
            SqlParameter[] sqlParameters = formattableString.GetArguments()
                .Select((value, position) => 
                    new SqlParameter(Invariant($"@p{position}"), value))
                .ToArray();
            object[] formatArguments = sqlParameters
                .Select(p => new FormatCapturingParameter(p))
                .ToArray();
            string sql = string.Format(formattableString.Format, formatArguments);
            var command = new SqlCommand(sql, conn);
            command.Parameters.AddRange(sqlParameters);
            return command;
        }

        private class FormatCapturingParameter : IFormattable
        {
            private readonly SqlParameter parameter;

            internal FormatCapturingParameter(SqlParameter parameter)
            {
                this.parameter = parameter;
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                if (!string.IsNullOrEmpty(format))
                {
                    parameter.SqlDbType =
                        (SqlDbType)Enum.Parse(typeof(SqlDbType), format, true);
                }
                return parameter.ParameterName;
            }
        }
    }

    [Description("Listing 9.8")]
    class ParameterizedSql
    {
        static void Main()
        {
            var connectionString = "not a real database";
            int userId = 15; // Determined elsewhere. Assume this is valid.
            var tag = Console.ReadLine();
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var command = conn.NewSqlCommand(
                    $@"SELECT Description
                       FROM Entries
                       WHERE Tag={tag:NVarChar} AND UserId={userId:Int}"))
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
