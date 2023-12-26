using HomeWork_Exceptions.SecondTask.Exceptions;

namespace HomeWork_Exceptions.SecondTask;

public static class CreateOrder
{
    public static void CheckOrderInfo(int orderNumber, List<Product> products, string address)
    {
        if (!products.Any())
        {
            throw new EmptyOrderException("Ошибка: в заказе нет товаров!");
        }

        if (orderNumber < 0)
        {
            throw new InvalidOrderNumberException("Ошибка: номер заказа не может быть отрицательным числом!");
        }

        if (string.IsNullOrEmpty(address))
        {
            throw new DeliveryInformationMissingException("Ошибка: нет данных для доставки!");
        }
    }
}