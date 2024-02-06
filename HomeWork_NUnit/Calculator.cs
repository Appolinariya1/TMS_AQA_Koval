namespace HomeWork_NUnit;

public static class Calculator
{
    public static int Div(int a, int b)
    {
        int result = a / b;
        return result;
    }

    //если под проверкой на double.NaN вы подразумевали не это - то я не знаю, что делать :((
    public static double Div(double a, double b)
    {
        double result = a / b;
        if (double.IsNaN(result) || double.IsInfinity(result))
        {
            throw new DivideByZeroException();
        }

        return result;
    }
}