using AssistantClass;
internal class Program
{
       private static void Main(string[] args)
    {
        Assistant ass = new Assistant();
        string[] mas = Assistant.TakeConsoleStringToArray(); //{ "123456", "2", ":-)", "21", "123", "3333" };
        string[] result = Assistant.getWorldLength(ref mas);
        if (result.Length != 0)
            ass.PrintArray(result);
        else
            Console.Write($"not found word\n");
    }
}