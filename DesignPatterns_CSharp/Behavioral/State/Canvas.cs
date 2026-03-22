namespace DesignPatterns_CSharp.Behavioral.State
{
    // context
    internal class Canvas
    {
        public Tool CurrentTool { get; set; } = new SelectionTool();

        public void MouseDown()
        {
            CurrentTool.MouseDown();
        }

        public void MouseUp()
        {
            CurrentTool.MouseUp();
        }
    }
}
