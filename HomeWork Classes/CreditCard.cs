namespace HomeWork_Classes;

public class CreditCard
{
    public ulong AccountNumber;
    public int CurrentAmount;

    public CreditCard(ulong accountNumber, int currentAmount)
    {
        AccountNumber = accountNumber;
        CurrentAmount = currentAmount;
    }

    public void PutMoney(int money)
    {
        CurrentAmount += money;
    }

    public void GetMoney(int money)
    {
        if (CurrentAmount - money >= 0)
        {
            CurrentAmount -= money;
        }
        else
        {
            Console.WriteLine($"Не удалось снять сумму {money} с карты {AccountNumber}. Недостаточно средств");
        }
    }

    public void CardInfo()
    {
        Console.WriteLine($"Остаток по карте {AccountNumber} = {CurrentAmount}");
    }
}