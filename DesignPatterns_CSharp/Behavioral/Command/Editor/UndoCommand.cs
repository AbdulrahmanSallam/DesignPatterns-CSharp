using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Command.Editor
{
    public class UndoCommand:ICommand
    {
        private readonly History history;

        public UndoCommand(History history)
        {
            this.history = history;
        }

        public void Execute()
        {
            if (history.Size() > 0)
            history.Pop().Unexecute();
        }

    }
}
