using static System.Collections.Specialized.BitVector32;

namespace DesignPatterns_CSharp.Behavioral.Mediator
{
    public class TextBox:UiControl
    {
        private string content;
        public string Content { 
            get{
                return content;
            }
            set {
                content = value;
                owner.Changed(this);
            } }

        public TextBox(DialogBox owner) : base(owner)
        {
        }


    }



}
