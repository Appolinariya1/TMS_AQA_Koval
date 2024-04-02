using DB_EFCore.Connector;
using DB_EFCore.Models;
using NLog;

namespace DB_EFCore.Tests;

public class InitialDataBaseTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();

    [Test]
    public void DB_Test1()
    {
        using (var dbConnector = new DataBaseConnector())
        {
            var customer1 = new Customer { Firstname = "Ivan", Lastname = "Petrov" };
            var customer2 = new Customer { Firstname = "Sergey", Lastname = "Ivanov" };

            var entityCustomer1 = dbConnector.Customers.Add(customer1);
            var entityCustomer2 = dbConnector.Customers.Add(customer2);
            dbConnector.SaveChanges();

            _logger.Info(entityCustomer1);


            var customers = dbConnector.Customers.ToList();
            _logger.Info("Customers List: ");

            foreach (var customer in customers)
            {
                _logger.Info(customer.ToString);
            }
            
            _logger.Info(dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Firstname);
            _logger.Info(dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Lastname);
            _logger.Info(dbConnector.Customers.Find(entityCustomer2.Entity.Id)?.Email);
            
            foreach (var customer in customers)
            {
                if (customer.Id > 10)
                {
                    dbConnector.Customers.Remove(customer);
                }
            }
            dbConnector.SaveChanges();
        }
    }
}