using System;
using System.Data.SqlClient;

public static partial class DataAccess
{
    private static readonly string connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True";

    public static SqlDataReader ExecuteReader(string commandText)
    {
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommand command = new SqlCommand(commandText, connection);
        connection.Open();
        return command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
    }
}
