using DesignPatterns_CSharp.Structural.Adapter.AvaFilters;

namespace DesignPatterns_CSharp.Structural.Adapter.Solution
{
    public class AvaCarmelFilter : IFilter
    {
        private AvaCaremel filter = new ();
        public void Apply(Image image)
        {
            filter.Init();

            filter.Render(image);
        }
    }
}
