namespace DesignPatterns_CSharp.Behavioral.Observer
{
    public class SpreadSheet : IObserver
    {
        // pull style
        private DataSource dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"SpreadSheet got notified with ${dataSource.GetValue()}.");
        }


        // push style
        //public void Update(int value)
        //{
        //    Console.WriteLine($"SpreadSheet got notified with ${value}.");
        //}
    }
}
