using DesignPatterns_CSharp.Behavioral.Strategy;

public class BlackAndWhiteFilter : IFilter
{
    public void Apply(string fileName)
    {
        Console.WriteLine("Applying Black and white filter");

    }
}