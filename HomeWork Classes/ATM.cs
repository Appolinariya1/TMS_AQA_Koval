namespace HomeWork_Classes;

public class ATM
{
    private int _amount20;
    private int _amount50;
    private int _amount100;

    public ATM(int amount20, int amount50, int amount100)
    {
        _amount20 = amount20;
        _amount50 = amount50;
        _amount100 = amount100;
    }

    public void PutMoney(int amount20, int amount50, int amount100)
    {
        _amount20 += amount20;
        _amount50 += amount50;
        _amount100 += amount100;
    }

    public bool GetMoney(int requestedSum)
    {
        int leftToGet = requestedSum;
        bool isSucceed = true;

        int preparedAmount20 = 0;
        int preparedAmount50 = 0;
        int preparedAmount100 = 0;

        while (leftToGet - 100 >= 0 && preparedAmount100 != _amount100)
        {
            preparedAmount100 += 1;
            leftToGet -= 100;
        }

        while (leftToGet - 50 >= 0 && preparedAmount50 != _amount50)
        {
            preparedAmount50 += 1;
            leftToGet -= 50;
        }

        while (leftToGet - 20 >= 0 && preparedAmount20 != _amount20)
        {
            preparedAmount20 += 1;
            leftToGet -= 20;
        }

        if (leftToGet == 0)
        {
            _amount20 -= preparedAmount20;
            _amount50 -= preparedAmount50;
            _amount100 -= preparedAmount100;

            Console.WriteLine($"Выдано: \n{preparedAmount20} купюр номиналом 20 рублей.");
            Console.WriteLine($"{preparedAmount50} купюр номиналом 50 рублей.");
            Console.WriteLine($"{preparedAmount100} купюр номиналом 100 рублей.");
        }
        else
        {
            isSucceed = false;
            Console.WriteLine($"Не удалось выдать сумму {requestedSum}");
        }

        return isSucceed;
    }

    public void DebugShowAmount()
    {
        Console.WriteLine($"Номинал 20: {_amount20} шт, Номинал 50: {_amount50} шт, Номинал 100: {_amount100} шт");
    }
}