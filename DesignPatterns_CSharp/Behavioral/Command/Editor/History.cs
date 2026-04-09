namespace DesignPatterns_CSharp.Behavioral.Command.Editor
{
    public class History
    {
        private Stack<IUndoableCommand> commands = new();

        public void Push(IUndoableCommand command)
        {
            commands.Push(command);
        }

        public IUndoableCommand Pop()
        {
           return commands.Pop();
        }

        public int Size()
        {
            return commands.Count;
        }
    }
}
