namespace DesignPatterns.Creational.FactoryMethod;
internal class FactoryClient
{
    public static void Test()
    {
        var serial = "333";

        var bankFactory = new BankFactory();
        var bank = bankFactory.GetBank(serial);

        if (bank == null ) {
            Console.WriteLine("Invalid Bank Card");
            return;
        }

        bank.Deposite(1000);
        bank.Deposite(6000);
        bank.Deposite(500);

        bank.Withdraw(5500);

        Console.WriteLine($"Bank Name: {bank.GetBankName()}");
        Console.WriteLine($"Amount: {bank.GetAmount()}");

        Console.WriteLine("======================================================");

        var serial2 = "444";

        var bank2 = bankFactory.GetBank(serial2);

        if (bank2 == null)
        {
            Console.WriteLine("Invalid Bank Card");
            return;
        }

        bank2.Deposite(8000);
        bank2.Deposite(200);
        bank2.Deposite(3000);

        bank2.Withdraw(7800);

        Console.WriteLine($"Bank Name: {bank2.GetBankName()}");
        Console.WriteLine($"Amount: {bank2.GetAmount()}");
    }
}
