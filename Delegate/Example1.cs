namespace Delegate;

public class Example1
{
    private delegate void NoParameters();

    public void Run()
    {
        NoParameters noParameters1 = new NoParameters(ShowMessage); //в этом случае NoParameters это тип, а не переменная
        NoParameters noParameters2 = new (ShowMessage);
        NoParameters noParameters3 = ShowMessage;

        noParameters1(); //вызываем переменную как метод
        noParameters2();
        noParameters3();
    }

    private void ShowMessage()
    {
        Console.WriteLine("Have fun!!!");
    }
}