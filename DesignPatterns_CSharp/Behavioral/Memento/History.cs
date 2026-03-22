using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CSharp.Behavioral.Memento
{

    // caretaker
    internal class History
    {
        private Stack<EditorState> _editorStates = new();

        public void Push(EditorState editorState)
        {
            _editorStates.Push(editorState);
        }

        public EditorState? Pop()
        {
            if (!_editorStates.Any()) return null;

            return _editorStates.Pop();
        }


    }
}
