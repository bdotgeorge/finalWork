using System.Linq;
namespace AssistantClass;
public class Assistant
{
    public void PrintArray(Array massive)
    {
        bool stop = true;
        try
        {
            stop = true;
            int row = massive.GetLength(0);
            int column = massive.GetLength(1); ;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"value = {massive.GetValue(i, j)}; ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message
            );
            stop = false;
        }

        if (stop)
            return;

        int size = massive.Length;
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Print Array data {i} = {massive.GetValue(i)}\n");
        }
    }
    public int[,] CreateIntMultiArray(int row = 8, int column = 4)
    {
        int[,] tempArray = new int[row, column];
        return tempArray;
    }

    public double[,] CreateDoubleMultiArray(int row = 8, int column = 4)
    {
        double[,] tempArray = new double[row, column];
        return tempArray;
    }
    public int[] CreateIntArray(int sizeArray = 8)
    {
        int[] tempArray = new int[sizeArray];
        return tempArray;
    }

    public double[] CreateDoubleArray(int sizeArray = 8)
    {
        double[] tempArray = new double[sizeArray];
        return tempArray;
    }
    public void FillArray(ref int[] array, int from = 0, int to = 10)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(from, to);

        }
    }

    public void FillDoubleArray(ref double[] array, int from = 0, int to = 10)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(from, to);
        }
    }

    public void FillMultiArray(ref double[,] array, int from = 0, int to = 10)
    {
        int row = array.GetLength(0);
        int column = array.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = new Random().Next(from, to + 1);
            }
        }
    }
    public int TakeConsoleInt(string str = "Enter integer")
    {
        Console.Write($"{str}\n");
        return StrToInt(Console.ReadLine()!);
    }

    private int StrToInt(string str)
    {
        int num = 0;
        int.TryParse(str, out num);
        return num;
    }
    public double[] TakeArrayInConsole(string str = "Enter integer")
    {
        Console.Write($"{str}\n");
        double[] array = Console.ReadLine()!.Split(',', ' ').Where(i => double.TryParse(i, out _)).Select(double.Parse).ToArray();
        return array;
    }

    public void QuickSortArray(ref double[] array, int first, int last) //multi Array stack over flow
    {
        int size = array.Length;
        int mid = size / 2;
        double middle = array[mid];

        do
        {
            int pivotIndex = PivotIndex(ref array, first, last);

            QuickSortArray(ref array, first, pivotIndex - 1);

            QuickSortArray(ref array, pivotIndex + 1, last);

        } while (first < last);

        if (last > 0)
        {
            QuickSortArray(ref array, last + 1, mid);
        }
        if (first < size)
        {
            QuickSortArray(ref array, first, mid - 1);
        }
    }

    private static int PivotIndex(ref double[] array, int minIndex, int maxIndex)
    {
        int pivot = minIndex - 1;
        for (int i = minIndex; i <= maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                pivot++;
                double temp = (double)array[pivot];
                array[pivot] = array[i];
                array[i] = temp;

            }
        }
        return pivot;
    }
    public int findMaxSizeElement(ref int[,] mas)
    {
        int max = Int32.MinValue;
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] > max)
                    max = mas[i, j];
            }
        }
        return max;
    }
    public void SortArray(ref double[,] array, int row, bool ascending = true)
    {
        if (ascending)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                double temp = array[row, j];
                int size = j;
                while (size > 0 && array[row, size - 1] > temp)
                {
                    array[row, size] = array[row, size - 1];
                    size--;
                }
                array[row, size] = temp;
            }
        }
        else
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                double temp = array[row, j];
                int size = j;
                while (size > 0 && array[row, size - 1] < temp)
                {
                    array[row, size] = array[row, size - 1];
                    size--;
                }
                array[row, size] = temp;
            }
        }
    }

}