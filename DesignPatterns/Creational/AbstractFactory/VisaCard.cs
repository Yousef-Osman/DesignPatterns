namespace DesignPatterns.Creational.AbstractFactory;
internal class VisaCard : IPaymentCard
{
    private readonly string Type = "Visa";

    public string GetCardType()
    {
        return Type;
    }
}
