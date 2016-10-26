using System;

class CompanyInfo
{
    static void Main()
    {
        string companyName, address, phoneNo, faxNo, website, managerFirst, managerLast, managerPhone;
        int managerAge;
        companyName = Console.ReadLine();
        address = Console.ReadLine();
        phoneNo = Console.ReadLine();
        faxNo = Console.ReadLine();
        website = Console.ReadLine();
        managerFirst = Console.ReadLine();
        managerLast = Console.ReadLine();
        managerAge = byte.Parse(Console.ReadLine());
        managerPhone = Console.ReadLine();
        if (faxNo == String.Empty) faxNo = "(no fax)";
        Console.WriteLine(@"{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})", companyName, address, phoneNo, faxNo, website, managerFirst, managerLast, managerAge, managerPhone);
    }
}
