namespace HomeWork_OOP.SecondTask.Doctors;

public class Surgeon : Doctor
{
    public override void Treat(string patientName)
    {
        Console.WriteLine($"{patientName} is being treated by a surgeon");
    }
}