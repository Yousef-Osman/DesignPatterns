namespace DesignPatterns.Creational.FactoryMethod;
internal class BankFactory : IBankFactory
{
    public IBank? GetBank(string serial)
    {
        switch (serial)
        {
            case "333":
                return new BankA();
            case "444":
                return new BankB();
            default:
                return null;
        }
    }
}
