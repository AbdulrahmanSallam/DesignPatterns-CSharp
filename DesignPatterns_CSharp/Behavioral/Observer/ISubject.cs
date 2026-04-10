namespace DesignPatterns_CSharp.Behavioral.Observer
{
    public interface ISubject
    {
        // Attach
        public void AddObserver(IObserver observer);

        // Detatch
        public void RemoveObserver(IObserver observer);

        // push style
        //public void NotifyObservers(int value);

     // pull style
        public void NotifyObservers();



    }
}
