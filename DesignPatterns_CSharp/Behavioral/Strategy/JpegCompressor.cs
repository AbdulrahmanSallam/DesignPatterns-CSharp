using DesignPatterns_CSharp.Behavioral.Strategy;

public class JpegCompressor : ICompression
{
    void ICompression.Compress(string fileName)
    {
        Console.WriteLine("Compressing using jpeg");
    }
}


