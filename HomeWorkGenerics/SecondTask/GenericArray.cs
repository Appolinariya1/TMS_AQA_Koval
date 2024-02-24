using System.Collections;

namespace HomeWorkGenerics.SecondTask;

public class GenericArray<T>
{
    private T[] _array;

    public GenericArray(T[] array)
    {
        _array = array;
    }

    public GenericArray()
    {
        _array = new T[] { };
    }

    public void Add(T element)
    {
        Array.Resize(ref _array, GetLength() + 1);
        _array[GetLength() - 1] = element;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= GetLength())
        {
            throw new IndexOutOfRangeException(message:"Некорректный индекс массива");
        }

        T[] result = new T[] { };
        Array.Resize(ref result, GetLength() - 1);
        if (index > 0)
        {
            Array.Copy(_array, 0, result, 0, index);
        }

        if (index < (GetLength() - 1))
        {
            Array.Copy(_array, index + 1, result, index, GetLength() - index - 1);
        }

        _array = result;
    }

    public T GetAt(int index)
    {
        if (index < 0 || index >= GetLength())
        {
            throw new IndexOutOfRangeException(message:"Некорректный индекс массива");
        }

        return _array[index];
    }

    public int GetLength()
    {
        return _array.Length;
    }

    public void Print()
    {
        Console.WriteLine(String.Join(", ", _array));
    }
}