using System;

class CompanyDetails
{
    static void Main()
    {
        Console.WriteLine("Write company name");
        string inputDetails = Console.ReadLine();
        string companyName = inputDetails;

        Console.WriteLine("Write company address");
        inputDetails = Console.ReadLine();
        string companyAddress = inputDetails;

        Console.WriteLine("Write company phone number");
        inputDetails = Console.ReadLine();
        int companyPhone = int.Parse(inputDetails);

        Console.WriteLine("Write company fax");
        inputDetails = Console.ReadLine();
        int companyFax = int.Parse(inputDetails);

        Console.WriteLine("Write company web page");
        inputDetails = Console.ReadLine();
        string companyWebAddress = inputDetails;

        Console.WriteLine("Write manager first name");
        inputDetails = Console.ReadLine();
        string managerFirstName = inputDetails;

        Console.WriteLine("Write manager last name");
        inputDetails = Console.ReadLine();
        string managerLastName = inputDetails;

        Console.WriteLine("Write manager age");
        inputDetails = Console.ReadLine();
        byte managerAge = byte.Parse(inputDetails);

        Console.WriteLine("Write manager phone number");
        inputDetails = Console.ReadLine();
        int managerPhone = int.Parse(inputDetails);

        Console.WriteLine("CompanyName - {0}\n CompanyAddress - {1}\n CompanyPhone - {2}\n CompanyFax - {3}\n Company WebPage - {4}\n Manager - {5} T{6}\n Age - {7}\n Phone - {8}", companyName, companyAddress, companyPhone, companyFax, companyWebAddress, managerFirstName,                           managerLastName, managerAge, managerPhone);
    }
}

