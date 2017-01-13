namespace BankAccounts
{
    public class Customer
    {
        public Customer(string name, CustomersEnumerator type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name
        {
            get;
            private set;
        }

        public CustomersEnumerator Type
        {
            get;
            private set;
        }
    }
}
