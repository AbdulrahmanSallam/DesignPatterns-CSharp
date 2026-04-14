namespace DesignPatterns_CSharp.Behavioral.Mediator.UsingObserver
{
    public class ObservableTextBox : ObservableUiControl
    {
        private string content;
        public string Content { get => content; set {
                content = value;
                NotifyObservers();
            } }
    }



}
