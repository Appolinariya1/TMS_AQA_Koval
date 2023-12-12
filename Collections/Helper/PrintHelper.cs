using System.Collections;

namespace Collections.Helper;

public static class PrintHelper
{
// Обычный вариант
    public static void PrintCollection(System.Collections.IList list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}