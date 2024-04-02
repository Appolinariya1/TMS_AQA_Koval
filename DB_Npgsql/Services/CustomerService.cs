using DB_Npgsql.Models;
using NLog;
using Npgsql;

namespace DB_Npgsql.Services;

public class CustomerService
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();

    private readonly NpgsqlConnection _connection;

    public CustomerService(NpgsqlConnection connection)
    {
        _connection = connection;
    }

    public List<Customer> GetAllCustomers()
    {
        var customerList = new List<Customer>();

        //Retrieve all rows
        var cmd = new NpgsqlCommand("select * from public.customers;", _connection);

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            var customer = new Customer
            {
                Id = reader.GetInt32(0),
                Firstname = reader.GetString(reader.GetOrdinal("firstname")),
                Lastname = reader.GetString(reader.GetOrdinal("lastname")),
                Email = reader.GetString(reader.GetOrdinal("email")),
                Age = reader.GetInt32(reader.GetOrdinal("age"))
            };

            _logger.Info(customer);

            customerList.Add(customer);
        }

        return customerList;
    }

    public int AddCustomer(Customer customer)
    {
        string sqlScript = $"insert into customers (firstname, lastname, email, age) " +
                           $"values ('{customer.Firstname}', '{customer.Lastname}', '{customer.Email}', {customer.Age})";

        var cmd = new NpgsqlCommand(sqlScript,
            _connection);

        return cmd.ExecuteNonQuery();
    }

    public void UpdateCustomer(Customer originCustomer, Customer updateCustomer)
    {
    }

    public int DeleteCustomer(Customer customer)
    {
        using var cmd = new NpgsqlCommand(
            "delete from customers where firstname = $1 AND lastname = $2;",
            _connection)
        {
            Parameters =
            {
                new() { Value = customer.Firstname },
                new() { Value = customer.Lastname }
            }
        };

        return cmd.ExecuteNonQuery();
    }

    public Customer GetCustomerById(int id)
    {
        var customer = new Customer();

        //Retrieve all rows
        var cmd = new NpgsqlCommand("select * from public.customers where id = $1;", _connection)
        {
            Parameters =
            {
                new() { Value = id }
            }
        };

        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            {
                customer.Id = reader.GetInt32(0);
                customer.Firstname = reader.GetString(reader.GetOrdinal("firstname"));
                customer.Lastname = reader.GetString(reader.GetOrdinal("lastname"));
                customer.Email = reader.GetString(reader.GetOrdinal("email"));
                customer.Age = reader.GetInt32(reader.GetOrdinal("age"));
            }
            ;

            _logger.Info(customer);
        }

        return customer;
    }
}