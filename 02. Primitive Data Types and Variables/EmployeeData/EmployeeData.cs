using System;

class EmployeeData
{
    static void Main()
    {
        string FirstName, LastName, tmp;
        byte Age;
        char Gender;
        long PersonalID;
        int EmployeeNumber;

        Console.Write("Enter First Name: ");
        FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        LastName = Console.ReadLine();

        Console.Write("Enter Gender(m/f): ");
        Gender = Convert.ToChar(Console.ReadLine());
        while (Gender != 'm' && Gender != 'f')
        {
            Console.Write("Enter Gender(m/f): ");
            Gender = Convert.ToChar(Console.ReadLine());
        }

        Console.Write("Enter Personal ID Number: ");
        tmp = Console.ReadLine();
        PersonalID = Convert.ToInt64(tmp);

        Console.Write("Enter Employee Number: ");
        tmp = Console.ReadLine();
        EmployeeNumber = Convert.ToInt32(tmp);

        Console.WriteLine();
        Console.WriteLine("First Name: {0}", FirstName);
        Console.WriteLine("Last Name: {0}", LastName);
        Console.WriteLine("Gender: {0}", Gender);
        Console.WriteLine("Personal ID Number: {0}", PersonalID);
        Console.WriteLine("Employee Number: {0}", EmployeeNumber);
    }
}
