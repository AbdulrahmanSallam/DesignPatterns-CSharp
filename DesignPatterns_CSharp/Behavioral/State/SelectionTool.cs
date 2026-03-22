namespace DesignPatterns_CSharp.Behavioral.State
{
    // concreteStateA
    internal class SelectionTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection MouseDown"); 
        }

        public void MouseUp()
        {
            Console.WriteLine("Selection MouseUp");

        }
    }
}
