using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Creational.FactoryMethod;
internal class BankFactory2 : IBankFactory2
{
    public IBank2? GetBank(string serial)
    {
        switch (serial)
        {
            case "333":
                return new BankC();
            case "444":
                return new BankD();
            default:
                return null;
        }
    }

    public IPaymentCard? GetCard(string serial)
    {
        switch (serial)
        {
            case "66":
                return new VisaCard();
            case "77":
                return new MasterCard();
            default:
                return null;
        }
    }
}
