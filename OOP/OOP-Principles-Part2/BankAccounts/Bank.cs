namespace BankAccounts
{
    using System.Collections.Generic;

    public class Bank
    {
        private IList<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public IList<Account> Accounts
        {
            get
            {
                return new List<Account>(this.accounts);
            }
        }

        public void Add(Account account)
        {
            this.accounts.Add(account);
        }
    }
}
