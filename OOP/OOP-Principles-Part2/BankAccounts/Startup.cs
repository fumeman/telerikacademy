namespace BankAccounts
{
    using System;

    class Startup
    {
        static void Main()
        {
            Bank bank = new Bank();
            Customer customer1 = new Customer("Gosho", CustomersEnumerator.Individuals);
            Customer customer2 = new Customer("Tosho", CustomersEnumerator.Companies);
            Customer customer3 = new Customer("Pesho", CustomersEnumerator.Individuals);
            Customer customer4 = new Customer("Ceca", CustomersEnumerator.Companies);

            Deposit c1Account1 = new Deposit(customer1, 2000, DateTime.Now, 7m);
            Mortgage c1Account2 = new Mortgage(customer1, 5000, new DateTime(2012, 10, 20), 6.55m);

            Mortgage c2Account1 = new Mortgage(customer2, 1000, new DateTime(2010, 12, 29), 3.88m);
            Loan c2Account2 = new Loan(customer2, 5000, new DateTime(2015, 2, 2), 12.65m);

            Loan c3Account1 = new Loan(customer2, 5000, new DateTime(2015, 2, 2), 12.65m);
            Deposit c3Account2 = new Deposit(customer4, 10000, new DateTime(2000, 11, 10), 18m);

            Deposit c4Account1 = new Deposit(customer4, 500, new DateTime(2000, 3, 5), 18m);
            Mortgage c4Account2 = new Mortgage(customer2, 1300, new DateTime(2009, 5, 29), 3.88m);
            Loan c4Account3 = new Loan(customer2, 300, new DateTime(2011, 3, 3), 12.65m);

            bank.Add(c1Account1);
            bank.Add(c1Account2);
            bank.Add(c2Account1);
            bank.Add(c2Account2);
            bank.Add(c3Account1);
            bank.Add(c3Account2);
            bank.Add(c4Account1);
            bank.Add(c4Account2);
            bank.Add(c4Account3);

            c1Account1.DepositMoney(1000);
            c2Account2.DepositMoney(500);
            c4Account1.DrawMoney(600);
            c4Account1.DepositMoney(0);
            c1Account1.DrawMoney(2000);

            Console.WriteLine(c1Account1.CalculateInterestAmount());

            Console.WriteLine(c2Account2.CalculateInterestAmount());
        }
    }
}
