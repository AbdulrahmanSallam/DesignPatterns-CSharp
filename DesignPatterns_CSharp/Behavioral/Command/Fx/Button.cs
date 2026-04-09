namespace DesignPatterns_CSharp.Behavioral.Command.Fx
{
    internal class Button
    {
        public string Label { get; set; }

        private ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {

            command.Execute();
            // ----
        }
    }
}
