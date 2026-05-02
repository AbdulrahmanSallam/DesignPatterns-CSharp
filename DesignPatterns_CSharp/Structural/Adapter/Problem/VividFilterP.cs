namespace DesignPatterns_CSharp.Structural.Adapter.Problem
{
    public class VividFilterP : IFilterP
    {
        public void Apply(ImageP image)
        {
            Console.WriteLine("Apply vivid filter");
        }
    }
}
