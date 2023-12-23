namespace Delegate;

public class Example4
{
    private delegate void NoParameters();

    public void Run()  //анонимный метод
    {
        NoParameters noPrm = delegate
        {
            Console.WriteLine("Have fun!!!");
        };

        noPrm();
    }
}