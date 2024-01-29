namespace HomeWork_LINQ.SecondTask;

public class Client
{
    public int ClientCode { get; set; }
    public int Year { get; set; }
    public int MonthNumber { get; set; }
    public int ExerciseDuration { get; set; }

    public Client(int clientCode, int year, int monthNumber, int exerciseDuration)
    {
        ClientCode = clientCode;
        Year = year;
        MonthNumber = monthNumber;
        ExerciseDuration = exerciseDuration;
    }

    public Client()
    {
    }

    public override string ToString()
    {
        return
            $"Код клиента: {ClientCode}, Год: {Year}, Номер месяца: {MonthNumber}, Продолжительность занятий (в часах): {ExerciseDuration}";
    }
}