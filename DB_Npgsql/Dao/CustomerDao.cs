using DB_Npgsql.Models;
using NLog;
using Npgsql;

namespace DB_Npgsql.Dao;

public class CustomerDao : ICustomerDao
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private readonly NpgsqlConnection _connection;

    public CustomerDao(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public List<Customer> GetAll()
    {
        var customersList = new List<Customer>();
        
        // Retrieve all rows
        using var cmd = new NpgsqlCommand("SELECT * FROM \"customers\";", _connection);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var customer = new Customer
            {
                Id = reader.GetInt32(reader.GetOrdinal("id")),
                Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                Email = reader.GetString(reader.GetOrdinal("email")),
                Age = reader.GetInt32(reader.GetOrdinal("age"))
            };
            
            _logger.Info(customer.ToString);
            
            customersList.Add(customer);
        }
        
        return customersList;
    }

    public Customer GetById(int id)
    {
        using (var cmd = new NpgsqlCommand("SELECT * FROM customers WHERE id = @id", _connection))
        {
            cmd.Parameters.AddWithValue("id", id);
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Customer
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id")),
                        Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                        Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                        Email = reader.GetString(reader.GetOrdinal("email")),
                        Age = reader.GetInt32(reader.GetOrdinal("age"))
                    };
                }
            }
        }

        return null;
    }
    
    public int Add(Customer customer)
    {
        using (var cmd = new NpgsqlCommand($"insert into customers (firstname, lastname, email, age) " +
                                           $"values (@firstname, @lastname, @email, @age)", _connection))
        {
            cmd.Parameters.AddWithValue("firstname", customer.Firstname);
            cmd.Parameters.AddWithValue("lastname", customer.Lastname);
            cmd.Parameters.AddWithValue("email", customer.Email);
            cmd.Parameters.AddWithValue("age", customer.Age);

            return cmd.ExecuteNonQuery();
        }
    }

    public int Update(Customer customer)
    {
        using (var command = new NpgsqlCommand("UPDATE customers SET firstname = @firstname, lastname = @lastname, " +
                                               "email = @email, age = @age WHERE id = @id",
                   _connection))
        {
            command.Parameters.AddWithValue("firstname", customer.Firstname);
            command.Parameters.AddWithValue("lastname", customer.Lastname);
            command.Parameters.AddWithValue("email", customer.Email);
            command.Parameters.AddWithValue("age", customer.Age);
            command.Parameters.AddWithValue("id", customer.Id);

            return command.ExecuteNonQuery();
        }
    }

    public int Delete(int? id)
    {
        using (var command = new NpgsqlCommand("DELETE FROM customers WHERE id = @id",
                   _connection))
        {
            command.Parameters.AddWithValue("id", id);

            return command.ExecuteNonQuery();
        }
    }

    public void Create()
    {
        var createTableSQL = "CREATE TABLE customers (" +
                             "id SERIAL PRIMARY KEY, " +
                             "firstname CHARACTER VARYING(30), " +
                             "lastname CHARACTER VARYING(30), " +
                             "email CHARACTER VARYING(30), " +
                             "age INTEGER" +
                             ");";
        using (var command = new NpgsqlCommand(createTableSQL, _connection))
        {
            command.ExecuteNonQuery();
        }
    }

    public void Drop()
    {
        var dropTableSQL = "drop table if exists customers;";

        using (var command = new NpgsqlCommand(dropTableSQL, _connection))
        {
            command.ExecuteNonQuery();
        }
    }
}