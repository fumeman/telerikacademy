namespace BankAccounts
{
    using System;

    public class Deposit : Account, IDeposit, IWithdraw
    {
        public Deposit(Customer customer, decimal balance, DateTime creationDate, decimal interestRate) : base(customer, balance, creationDate, interestRate)
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

        public bool DrawMoney(decimal drawSum)
        {
            bool result = false;

            if (this.Balance == 0)
            {
                Console.WriteLine($"{this.Customer.Name}, Balance is zero!");
            }
            else if (this.Balance - drawSum <= 0)
            {
                Console.WriteLine($"{this.Customer.Name}, Insufficient availability!");
            }
            else if (drawSum <= 0)
            {
                Console.WriteLine($"{this.Customer.Name}, Negative or zero withdrawal amount!");
            }
            else
            {
                this.Balance -= drawSum;
                result = true;
            }

            Console.WriteLine(this.ToString());
            Console.WriteLine();
            return result;
        }

        public override decimal CalculateInterestAmount()
        {
            decimal result = 0;

            if (this.Balance > 1000)
            {
                result = base.CalculateInterestAmount();
            }

            return result;
        }
    }
}
