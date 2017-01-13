namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private DateTime creationDate;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, DateTime creationDate, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.CreationDate = creationDate;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            internal set
            {
                this.balance = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return this.creationDate;
            }

            private set
            {
                this.creationDate = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterestAmount()
        {
            return this.NumberOfMonths() * this.InterestRate;
        }

        public override string ToString()
        {
            string result;

            result = $"{this.Customer.Name} - {this.Customer.Type}, banalce: {this.Balance}, created: {this.CreationDate}, interest: {this.InterestRate}%";

            return result;
        }

        internal int NumberOfMonths()
        {
            return DateTime.Now.Year * 12 - this.CreationDate.Year * 12 + DateTime.Now.Month - this.CreationDate.Month;
        }
    }
}
