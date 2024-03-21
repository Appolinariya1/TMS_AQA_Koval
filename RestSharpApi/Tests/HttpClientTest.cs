namespace RestSharpApi.Tests;

public class HttpClientTest
{
    [Test]
    public async Task SimpleHttpClientTest()
    {
        const string restUrl = "https://reqres.in/";

        //Создаем экземпляр HttpClient
        using (HttpClient client = new HttpClient())
        {
            try
            {
                //Настраиваем и выполняем Get-запрос к указанному URL
                HttpResponseMessage response = await client.GetAsync(restUrl);
                
                //Проверяем успешность запроса
                if (response.IsSuccessStatusCode)
                {
                    //Читаем содержимое ответа как строку
                    string content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(content);
                }
                else
                {
                    Console.WriteLine($"Ошибка: {response.StatusCode}");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}