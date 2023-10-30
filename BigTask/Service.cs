using BigTask.Models;
using System.Data.SqlClient;

namespace BigTask;

public class Service
{
    public static readonly string connect = "Server=(localdb)\\MSSQLLocalDB;Database=BigTask;Trusted_Connection=True;";
    public static void Create(Employee employee)
    {
        using(SqlConnection connection = new SqlConnection(connect)) 
        {
            var query = $"INSERT INTO dbo.Employee(Name,Surname,Email,Status,Role,CreatedDate) VALUES('{employee.Name}','{employee.Surname}','{employee.Email}','{employee.status}','{employee.role}','{employee.CreatedDate}');";
            SqlCommand cmd = new SqlCommand(query,connection);
            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Succesfuly!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Notugri Malumot kiritdingiz");
            }
        }
    }
    public static void GetAll()
    {
        using (SqlConnection connection = new SqlConnection(connect))
        {
            connection.Open();
            var query = $"Select * from dbo.Employee;";
            var command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var c = reader.FieldCount;///column sonini bilish
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    public static void DeepDelete(int id)
    {
        using (SqlConnection connection = new SqlConnection(connect))
        {
            var query = $"Delete * from Employee Where Id = {id};";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Succesfuly!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
            }
        }
    }
    public static void DeleteById(int Id)
    {
        using (SqlConnection connection = new SqlConnection(connect))
        {
            var query = $"Update Employee SET Status = {Enums.Status.Deleted} Where Id = {Id};";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Succesfuly!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
            }
        }
    }
    public static void GetById(int id)
    {
        using (SqlConnection connection = new SqlConnection(connect))
        {
            connection.Open();
            var query = $"Select * from dbo.Employee Where ID = {id};";
            var command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var c = reader.FieldCount;///column sonini bilish
                    for (int i = 0; i < c; i++)
                    {
                        Console.Write(reader[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
