namespace HomeWork_LINQ.SecondTask;

public static class ClientSearchEngine
{
    public static Client GetLaziestClient(List<Client> clientsList)
    {
        if (clientsList.Count == 0)
        {
            throw new Exception("Список клиентов пуст!");
        }

        var minDuration = clientsList.Min(client => client.ExerciseDuration);
        Client clientResult = clientsList.Last(client => client.ExerciseDuration == minDuration);
        return clientResult;
    }
}