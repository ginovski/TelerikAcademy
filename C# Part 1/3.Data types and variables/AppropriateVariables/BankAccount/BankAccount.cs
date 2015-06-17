using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Alexandar";
        string middleName = "Ivaylov";
        string lastName = "Ginovski";
        short money = 900;
        string bank = "UnicreditBulbank";
        string IBAN = "BH56AAAA00000123456789";
        string bic = "UNCRBGSF";
        long number1 = 0123412451241232;
        long number2 = 0123312312312312;
        long number3 = 0125483574385758;

        Console.WriteLine("Bank Details of:\n FirstName:{0}\n MiddleName:{1}\n LastName:{2}\n Money:{3}$\n Bank:{4}\n IBAN:{5}\n BIC:{6}\n CardNumber 1:{7}\n CardNumber 2:{8}\n CardNumber 3:{9}",firstName, middleName, lastName, money, bank, IBAN, bic, number1, number2, number3);

    }
}

