namespace DesignPatterns_CSharp.Behavioral.Visitor
{
    public class HighlightOperation : IOperation
    {
        public void Apply(AnchorNode node)
        {
            Console.WriteLine("Highlight anchor");
        }

        public void Apply(HeadingNode node)
        {
            Console.WriteLine("Highlight heading");
        }
    }


}
