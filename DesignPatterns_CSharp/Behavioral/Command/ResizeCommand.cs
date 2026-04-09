using DesignPatterns_CSharp.Behavioral.Command.Fx;

namespace DesignPatterns_CSharp.Behavioral.Command
{
    public class ResizeCommand : ICommand
    {
        
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
