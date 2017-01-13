namespace BankAccounts
{
    using System;

    public class Mortgage : Account, IDeposit
    {
        public Mortgage(Customer customer, decimal balance, DateTime creationDate, decimal interestRate) : base(customer, balance, creationDate, interestRate)
        {
        }

        public bool DepositMoney(decimal depositSum)
        {
            bool result = false;

            if (depositSum <= 0)
            {
                Console.WriteLine($"{this.Customer.Name}, Negative or zero-sum deposit!");
            }
            else
            {
                this.Balance += depositSum;
                result = true;
            }

            Console.WriteLine(this.ToString());
            Console.WriteLine();
            return result;
        }

        public override decimal CalculateInterestAmount()
        {
            decimal result = base.CalculateInterestAmount();
            if (((this.NumberOfMonths() <= 6) && (this.Customer.Type == CustomersEnumerator.Individuals))
                || ((this.NumberOfMonths() <= 12) && (this.Customer.Type == CustomersEnumerator.Companies)))
            {
                result /= 2;
            }

            return result;
        }
    }
}
