namespace HomeWork_NUnit;

internal class DivideTestData
{
    public static object[] DivideCasesInt =
    {
        new object[] { 100, 4, 25 },
        new object[] { 48, 8, 6 },
        new object[] { 4, 2, 2 }
    };

    public static object[] DivideCasesIntIncorrectData =
    {
        new object[] { 100, 4, 50 },
        new object[] { 48, 8, 7 },
        new object[] { 4, 2, 2 },
    };
    
    public static object[] DivideCasesDouble =
    {
        new object[] { 10, 4, 2.5 },
        new object[] { 100.8, 2, 50.4 },
        new object[] { 9, 4.5, 2 }
    };
}