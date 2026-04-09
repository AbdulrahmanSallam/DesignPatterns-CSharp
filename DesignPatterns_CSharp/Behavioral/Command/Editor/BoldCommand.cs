namespace DesignPatterns_CSharp.Behavioral.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        private string prevCotent;

        private HtmlDocument document;

        private History history;


        public BoldCommand(HtmlDocument document, History history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            prevCotent = document.Content;

            document.MakeBold();

            history.Push(this);     
        }

        public void Unexecute()
        {
            document.Content = prevCotent;
        }
    }
}
