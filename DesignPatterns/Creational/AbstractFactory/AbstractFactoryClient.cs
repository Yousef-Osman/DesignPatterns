namespace DesignPatterns.Creational.FactoryMethod;
internal class AbstractFactoryClient
{
    public static void Test()
    {
        var serial = "333";

        var bankFactory = new BankFactory2();
        var bank = bankFactory.GetBank(serial);

        if (bank == null ) {
            Console.WriteLine("Invalid Bank Serial");
            return;
        }

        bank.Deposite(1000);
        bank.Deposite(6000);
        bank.Deposite(500);

        bank.Withdraw(5500);

        Console.WriteLine($"Bank Name: {bank.GetBankName()}");
        Console.WriteLine($"Amount: {bank.GetAmount()}");

        Console.WriteLine("======================================================");

        var serial2 = "77";

        var card = bankFactory.GetCard(serial2);

        if (card == null)
        {
            Console.WriteLine("Invalid Bank Card");
            return;
        }

        Console.WriteLine($"Bank Name: {card.GetCardType()}");
    }
}
