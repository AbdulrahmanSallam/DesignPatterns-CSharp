namespace DesignPatterns_CSharp.Behavioral.Mediator
{
    public class ArticlesDialogBox : DialogBox
    {
        private ListBox articleListBox;
        private TextBox titleTextBox ;
        private Button saveButton;

        public ArticlesDialogBox()
        {
            saveButton = new Button(this);
            articleListBox = new ListBox(this);
            titleTextBox = new TextBox(this);
        }

        public void SimulateChanges()
        {
            articleListBox.Selection = "hello";
            titleTextBox.Content = "";
            Console.WriteLine($"title = {titleTextBox.Content}");
            Console.WriteLine($"button = {saveButton.IsEnabled}");
        }

        public override void Changed(UiControl control)
        {
            if (control == articleListBox)
                ArticleSelected();
            else if (control == titleTextBox)
                TitleChanged();
        }

        private void TitleChanged()
        {
            var isEmpty = String.IsNullOrWhiteSpace(titleTextBox.Content);
             saveButton.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            var selectedArticle = articleListBox.Selection;
            titleTextBox.Content = selectedArticle;
            saveButton.IsEnabled = true;

        }
    }



}
