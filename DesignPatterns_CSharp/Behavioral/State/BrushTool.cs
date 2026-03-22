namespace DesignPatterns_CSharp.Behavioral.State
{
    // concreteStateB
    internal class BrushTool : Tool
    {
        public  void MouseDown()
        {
            Console.WriteLine("Brush MouseDown");
        }

        public void MouseUp()
        {
            Console.WriteLine("Brush MouseUp");
        }
    }
}
