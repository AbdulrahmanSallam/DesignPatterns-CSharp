namespace DesignPatterns_CSharp.Behavioral.Observer
{
    public class Chart : IObserver
    {
        // pull style
        private  DataSource dataSource;
      
        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public void Update()
        {
            Console.WriteLine($"Chart got notified with ${dataSource.GetValue()}.");
        }


        // push style
        //public void Update(int value)
        //{
        //    Console.WriteLine($"Chart got notified with ${value}.");
        //}


    }
}
