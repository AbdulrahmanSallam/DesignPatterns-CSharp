using DesignPatterns_CSharp.Behavioral.Command.Fx;

namespace DesignPatterns_CSharp.Behavioral.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService service;

        public AddCustomerCommand(CustomerService service)
        {
            this.service = service;
        }

        public void Execute()
        {
            service.AddCustomer();
        }
    }
}
