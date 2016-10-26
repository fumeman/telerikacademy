using System;

class BankAccountData
{
    static void Main()
    {
        string FirstName, MiddleName, LastName, BankName, IBAN, tmp;
        long balance;
        ulong cardNumber1, cardNumber2, cardNumber3;

        Console.Write("Enter First Name: ");
        FirstName = Console.ReadLine();

        Console.Write("Enter Middle Name: ");
        MiddleName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        LastName = Console.ReadLine();

        Console.Write("Enter Bank Name: ");
        BankName = Console.ReadLine();

        Console.Write("Enter IBAN: ");
        IBAN = Console.ReadLine();

        Console.Write("Enter Balance: ");
        tmp = Console.ReadLine();
        balance = Convert.ToInt64(tmp);

        Console.Write("Enter Card Number #1: ");
        tmp = Console.ReadLine();
        cardNumber1 = Convert.ToUInt64(tmp);

        Console.Write("Enter Card Number #2: ");
        tmp = Console.ReadLine();
        cardNumber2 = Convert.ToUInt64(tmp);

        Console.Write("Enter Card Number #3: ");
        tmp = Console.ReadLine();
        cardNumber3 = Convert.ToUInt64(tmp);

        Console.WriteLine();
        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Middle Name: {0}", MiddleName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Bank Name: {0}", BankName);
        Console.WriteLine("IBAN: {0}", IBAN);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("Card #1: {0}", cardNumber1);
        Console.WriteLine("Card #2: {0}", cardNumber2);
        Console.WriteLine("Card #3: {0}", cardNumber3);
    }
}
