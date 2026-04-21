namespace DesignPatterns_CSharp.Behavioral.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }



}
