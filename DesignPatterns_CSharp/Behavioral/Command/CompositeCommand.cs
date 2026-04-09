using DesignPatterns_CSharp.Behavioral.Command.Fx;

namespace DesignPatterns_CSharp.Behavioral.Command
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> commands = new();

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach(var command in commands)
            {
                command.Execute();
            }
        }
    }
}
