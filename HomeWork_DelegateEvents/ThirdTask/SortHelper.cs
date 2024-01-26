namespace HomeWork_DelegateEvents.ThirdTask;

public class SortHelper
{
    private int[] BubbleSort(int[] array)
    {
        int[] result = new int[array.Length];
        Array.Copy(array, result, array.Length);

        static void Swap(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        for (var i = 1; i < result.Length; i++)
        {
            for (var j = 0; j < result.Length - i; j++)
            {
                if (result[j] > result[j + 1])
                {
                    Swap(ref result[j], ref result[j + 1]);
                }
            }
        }

        Console.WriteLine("Сортировка пузырьком");
        return result;
    }

    private int[] SimpleSort(int[] array)
    {
        int[] result = new int[array.Length];
        Array.Copy(array, result, array.Length);
        int i, j, min, temp;

        for (i = 0; i < result.Length - 1; i++)
        {
            min = i;

            for (j = i + 1; j < result.Length; j++)
            {
                if (result[j] < result[min])
                    min = j;
            }

            temp = result[i];
            result[i] = result[min];
            result[min] = temp;
        }

        Console.WriteLine("Простая сортировка");
        return result;
    }

    public SortDelegate GetSortDelegateBySortType(SortType sortType)
    {
        SortDelegate sortDelegate;
        switch (sortType)
        {
            case SortType.Bubble:
                sortDelegate = BubbleSort;
                break;
            case SortType.Simple:
                sortDelegate = SimpleSort;
                break;
            default:
                throw new ArgumentException("Некорректный тип сортировки");
        }

        return sortDelegate;
    }
}