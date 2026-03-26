using DesignPatterns_CSharp.Behavioral.Strategy;

public class PngCompressor : ICompression
{
    void ICompression.Compress(string fileName)
    {
        Console.WriteLine("Compressing using png");
    }
}


