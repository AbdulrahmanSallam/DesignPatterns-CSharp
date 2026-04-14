namespace DesignPatterns_CSharp.Behavioral.Mediator
{
    public class Button: UiControl
    {
        private bool isEnabled;
        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                isEnabled = value;
                owner.Changed(this);
            }
        }

        public Button(DialogBox owner) : base(owner)
        {
        }


    }



}
