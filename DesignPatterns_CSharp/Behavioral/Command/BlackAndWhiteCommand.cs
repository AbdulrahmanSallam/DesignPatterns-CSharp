using DesignPatterns_CSharp.Behavioral.Command.Fx;

namespace DesignPatterns_CSharp.Behavioral.Command
{
    public class BlackAndWhiteCommand : ICommand
    {

        public void Execute()
        {
            Console.WriteLine("Black and white");
        }
    }
}
