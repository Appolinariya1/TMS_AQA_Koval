namespace Exceptions;

public class ThrowExceptions
{
    public void CheckUsername()
    {
        try
        {
            Console.Write("Введите имя: ");
            string? name = Console.ReadLine();
            if (name== null || name.Length < 2)
            {
                throw new Exception("Длина имени меньше 2 символов"); //создаем сообщение об ошибке
            }

            Console.WriteLine($"Ваше имя: {name}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e.Message}"); //обрабатываем созданное нами исключение и выводим кастомное сообщение
        }
    }
    
    public void CheckUsername1()
    {
        try
        {
            try
            {
                Console.Write("Введите имя: ");
                string? name = Console.ReadLine();
                if (name == null || name.Length < 2)
                {
                    throw new Exception("Длина имени меньше 2 символов");
                }

                Console.WriteLine($"Ваше имя: {name}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                throw; //вызов exception еще раз (отправить ошибку дальше и т.д.)
            }
        }
        catch (Exception ex) //более высокоуровневое срабатывание Exception
        {
            Console.WriteLine(ex.Message);
        }
    }
}