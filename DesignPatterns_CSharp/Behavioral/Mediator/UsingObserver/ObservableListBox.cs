namespace DesignPatterns_CSharp.Behavioral.Mediator.UsingObserver
{
    public class ObservableListBox:ObservableUiControl
    {
        public string selection;

        public string Selection
        {
            get => selection; set
            {
                selection = value;
                NotifyObservers();
            }
        }

    }



}
