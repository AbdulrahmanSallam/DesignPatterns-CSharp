namespace DesignPatterns_CSharp.Behavioral.Mediator.UsingObserver
{
    public class LevelsDialogBox
    {
        private ObservableListBox  levelsListBox= new();
        private ObservableTextBox  titleTextBox = new();
        private ObservableButton  saveButton= new();

        public LevelsDialogBox()
        {
            levelsListBox.Attach(new ListBoxObserver(this));
            titleTextBox.Attach(new TitleTextBoxObserver(this));
        }
        public void SimulateChanges()
        {
            levelsListBox.Selection = "hello";
            //titleTextBox.Content = "";
            Console.WriteLine($"title = {titleTextBox.Content}");
            Console.WriteLine($"button = {saveButton.IsEnabled}");
        }


        private void TitleChanged()
        {
            var isEmpty = String.IsNullOrWhiteSpace(titleTextBox.Content);
            saveButton.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            var selectedArticle = levelsListBox.Selection;
            titleTextBox.Content = selectedArticle;
            saveButton.IsEnabled = true;

        }

        private class ListBoxObserver : IObserver
        {
            private readonly LevelsDialogBox levelsDialogBox;

            public ListBoxObserver(LevelsDialogBox levelsDialogBox)
            {
                this.levelsDialogBox = levelsDialogBox;
            }

            public void Update()
            {
                levelsDialogBox.ArticleSelected();
            }
        }

        private class TitleTextBoxObserver : IObserver
        {
            private readonly LevelsDialogBox levelsDialogBox;

            public TitleTextBoxObserver(LevelsDialogBox levelsDialogBox)
            {
                this.levelsDialogBox = levelsDialogBox;
            }

            public void Update()
            {
                levelsDialogBox.TitleChanged();
            }
        }

    }



}
