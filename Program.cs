using AssistantClass;
internal class Program
{
    public static string[] getWorldLength(string[] mas, int wordSize = 4)
    {
        int countWord = 0;
        int sizeArray = mas.Length;
        if (sizeArray % 2 != 0)
        {
            if (mas[sizeArray / 2].Length < wordSize)
                countWord++;
        }
        for (int i = 0; i < sizeArray / 2; i++)
        {
            if (mas[i].Length < wordSize)
                countWord++;
            if (mas[sizeArray - 1 - i].Length < wordSize)
                countWord++;
        }
        string[] result = new string[countWord];
        countWord = 0;
        for (int i = 0; i < sizeArray; i++)
        {
            if (mas[i].Length < wordSize)
            {
                result[countWord] = mas[i];
                countWord++;
            }
        }
        return result;
    }
    private static void Main(string[] args)
    {
        Assistant ass = new Assistant();
        string[] mas = { "123456", "2", ":-)", "21", "123", "333" };
        string[] result = getWorldLength(mas);
        if (result.Length != 0)
            ass.PrintArray(result);
        else
            Console.Write($"not found word\n");
    }
}