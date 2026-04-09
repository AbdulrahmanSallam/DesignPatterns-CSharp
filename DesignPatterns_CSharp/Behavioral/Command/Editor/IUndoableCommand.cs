namespace DesignPatterns_CSharp.Behavioral.Command.Editor
{
    public interface IUndoableCommand:ICommand
    {
        void Unexecute();
    }
}
