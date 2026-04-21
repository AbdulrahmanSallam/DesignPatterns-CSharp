namespace DesignPatterns_CSharp.Behavioral.Visitor
{
    public class HtmlDocument
    {
        public List<IHtmlNode> Nodes { get; set; } = new();

        public void Add(IHtmlNode node)
        {
            Nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in Nodes)
            {
                node.Execute(operation);
            }
        }
        
        
    }



}
