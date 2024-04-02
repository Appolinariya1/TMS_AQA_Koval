using System.Data.Common;
using DB_Npgsql.Connector;
using DB_Npgsql.Models;
using DB_Npgsql.Services;
using NLog;

namespace DB_Npgsql.Tests;

public class DatabaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private DBConnector? _dbConnector;
    private CustomerService? _customerService;
    
    [OneTimeSetUp]
    public void SetupConnect()
    {
        _dbConnector = new DBConnector();
        _customerService = new CustomerService(_dbConnector.Connection);
    }

    [Test]
    public void GetAllCustomersTest()
    {
        _logger.Info("Started GetAllCustomersTest...");
        
        Assert.That(_customerService!.GetAllCustomers().Count, Is.EqualTo(5));
        
        _logger.Info("Completed GetAllCustomersTest...");
    }
    
    [Test]
    public void GetSingleCustomerTest()
    {
        _logger.Info("Started GetSingleCustomerTest...");

        Customer actualCustomer = _customerService!.GetCustomerById(1);
        Assert.That(actualCustomer.Firstname, Is.EqualTo("Ольга"));
        
        _logger.Info("Completed GetSingleCustomerTest...");
    }
    
    [Test]
    public void AddCustomerTest()
    {
        _logger.Info("Started AddCustomerTest...");

        var expectedCustomer = new Customer
        {
            Firstname = "Lis",
            Lastname = "Fur",
            Email = "nora@com",
            Age = 10
        };
        
        Assert.That(_customerService!.AddCustomer(expectedCustomer), Is.EqualTo(1));
        
        _logger.Info("Completed AddCustomerTest...");
    }
    
    [Test]
    public void UpdateCustomerTest()
    {
        
    }
    
    [Test]
    public void DeleteCustomerTest()
    {
        _logger.Info("Started DeleteCustomerTest...");

        var expectedCustomer = new Customer
        {
            Firstname = "Lis",
            Lastname = "Fur",
            Email = "nora@com",
            Age = 10
        };
        
        Assert.That(_customerService!.DeleteCustomer(expectedCustomer), Is.EqualTo(1));
        
        _logger.Info("Completed DeleteCustomerTest...");
    }
    
    [OneTimeTearDown]
    public void TearDownConnection()
    {
        _dbConnector!.CloseConnection();
    }
}