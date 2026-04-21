namespace DesignPatterns_CSharp.Behavioral.Visitor
{
    // visitor that has visit methods
    public interface IOperation
    {
        void Apply(AnchorNode node); 
        void Apply(HeadingNode node);
    }

}
