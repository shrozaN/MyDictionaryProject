using MyDictionaryProject;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
        myDictionary.Add(12, "Ali");
        myDictionary.Add(24, "Emre");
        myDictionary.Add(26, "Atilla");
    }
}