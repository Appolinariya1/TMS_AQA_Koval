// See https://aka.ms/new-console-template for more information

using HomeWork_OOP.FirstTask;
using HomeWork_OOP.SecondTask;
using HomeWork_OOP.ThirdTask;
using HomeWork_OOP.ThirdTask.TransportPark;

Console.WriteLine("Задание 1");

Figure[] figures = new Figure[]
{
    TriangleCreator.CreateTriangle(101, 5.5f, 100), //разносторонний треугольник
    TriangleCreator.CreateTriangle(2, 2, 2), //равносторонний треугольник
    TriangleCreator.CreateTriangle(3, 4, 5), // прямоугольный треугольник
    TriangleCreator.CreateTriangle(5, 5, 2), // равнобедренный треугольник
    new Rectangle(4, 5),
    new Square(3)
};

foreach (var figure in figures)
{
    var figureArea = figure.GetArea();
    Console.WriteLine($"Площадь фигуры = {figureArea}"); //можно добавить {figure.GetType()} для проверки фигуры
}

Console.WriteLine("\nЗадание 2");

var hospital = new Hospital();
var patients = new Patient[]
{
    new Patient("Patient 1", new TreatmentPlan(1)),
    new Patient("Patient 2", new TreatmentPlan(2)),
    new Patient("Patient 3", new TreatmentPlan(99))
};
hospital.StartDay(patients);

Console.WriteLine("\nЗадание 3");

var tps = new TransportService();

SuperTransport[] transports = new SuperTransport[]
{
    new Bus() { AmountSeats = 20, DepartureTime = new TimeOnly(10, 15), Destination = "Puponechka", Number = 13 },
    new Helicopter() { AmountSeats = 4, DepartureTime = new TimeOnly(23, 00), Destination = "Maldives", Number = 1 },
    new Tramcar() { AmountSeats = 40, DepartureTime = new TimeOnly(09, 05), Destination = "Market", Number = 99 }
};

Console.WriteLine("Our transport park includes such types of transport:");
foreach (var transport in transports)
{
    tps.PrintTransportType(transport);
}
Console.WriteLine("\nTransport info:");
transports = tps.SortByAmountSeats(transports);
foreach (var transport in transports)
{
    transport.WriteTransportInfo();
}

var searchResults = new SuperTransport[transports.Length];
int searchIndex = 0;

Console.WriteLine("\nEnter the departure time in the format hh:mm or leave the field blank");
string rawDepartureTime = Console.ReadLine();
TimeOnly? departureTime = null;
if (rawDepartureTime != string.Empty)
{
    departureTime = new TimeOnly(int.Parse(rawDepartureTime.Split(':')[0]), int.Parse(rawDepartureTime.Split(':')[1]));
}

Console.WriteLine("Enter your destination or leave the field blank");
string destination = Console.ReadLine();
foreach (var transport in transports)
{
    if (!(rawDepartureTime == string.Empty ||
          (rawDepartureTime != string.Empty && transport.DepartureTime > departureTime)))
    {
        continue;
    }

    if (!(destination == String.Empty || (destination != String.Empty && destination == transport.Destination)))
    {
        continue;
    }

    searchResults[searchIndex] = transport;
    searchIndex++;
}

bool isAnyResultDisplayed = false;

foreach (var transport in searchResults)
{
    if (transport != null)
    {
        transport.WriteTransportInfo();
        isAnyResultDisplayed = true;
    }
}

if (!isAnyResultDisplayed)
{
    Console.WriteLine("There is no suitable transport for your request in our transport park");
}