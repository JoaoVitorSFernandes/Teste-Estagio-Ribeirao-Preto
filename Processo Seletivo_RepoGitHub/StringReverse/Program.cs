using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe a string: ");
        var res = Console.ReadLine();
        var stringReversed = ReverseString(res);
        Console.WriteLine(stringReversed);
    }

    static StringBuilder ReverseString(string word)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = word.Length; i > 0; i--)
            sb.Append(word[i - 1]);

        return sb;
    }
}