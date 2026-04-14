namespace DesignPatterns_CSharp.Behavioral.Mediator
{
    public class ListBox: UiControl
    {


        private string selection;
        public string Selection
        {
            get {
                return selection;
            }
            set
            {
                selection = value;
                owner.Changed(this);
            }
        }

        public ListBox(DialogBox owner) : base(owner)
        {
        }

        
    }



}
