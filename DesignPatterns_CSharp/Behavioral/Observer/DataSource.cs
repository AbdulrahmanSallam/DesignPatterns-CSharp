namespace DesignPatterns_CSharp.Behavioral.Observer
{
    public class DataSource:Subject
    {

        private int value;
        public int Value
        {
            get => value;
            set
            {
               this.value = value;
                NotifyObservers();
            }
        }


        // pull style 
        public int GetValue() => Value;

    }

}
