using AssistantClass;
internal class Program
{
    public static string[] getWorldLength(string[] mas, int wordSize = 4)
    {
        int countWord = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i].Length < wordSize)
                countWord++;
        }
        string[] result = new string[countWord];
        countWord = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i].Length < 4)
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
        ass.PrintArray(result);
    }
}