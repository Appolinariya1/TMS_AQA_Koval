using DB_Npgsql.Connector;
using DB_Npgsql.Dao;
using DB_Npgsql.Models;
using NLog;

namespace DB_Npgsql.Tests;

public class DaoDatabaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private DBConnector? _dbConnector;
    private CustomerDao? _customerDao;

    [OneTimeSetUp]
    public void SetupConnection()
    {
        _dbConnector = new DBConnector();
        _customerDao = new CustomerDao(_dbConnector.Connection);

        _customerDao.Drop();
        _customerDao.Create();
        _customerDao.Add(new Customer
        {
            Firstname = "Александр",
            Lastname = "Тростянко",
            Email = "wp@test.com",
            Age = 45
        });
    }

    [OneTimeTearDown]
    public void TearDownConnection()
    {
        _dbConnector?.CloseConnection();
    }

    [Test]
    public void AddCustomerTest()
    {
        _logger.Info("Started AddCustomerTest...");

        Assert.That(_customerDao.Add(new Customer
        {
            Firstname = "dmitry",
            Lastname = "sidorov",
            Email = "ds@test.com",
            Age = 25
        }), Is.EqualTo(1));

        _logger.Info("Ended AddCustomerTest...");
    }
    
    [Test]
    public void GetAllCustomersTest()
    {
        _logger.Info("GetAllCustomersTest started...");
        var customersList = _customerDao?.GetAll();

        Assert.That(customersList, Has.Count.GreaterThan(0));

        _logger.Info("GetAllCustomersTest completed...");
    }
    
    [Test]
    public void DeleteCustomerTest()
    {
        _logger.Info("DeleteCustomerTest started...");

        Assert.That(_customerDao?.Delete(_customerDao?.GetAll()[0].Id), Is.EqualTo(1));

        _logger.Info("DeleteCustomerTest completed...");
    }
}