namespace DesignPatterns.Creational.AbstractFactory;
internal class MasterCard: IPaymentCard
{
    private readonly string Type = "MasterCard";

    public string GetCardType()
    {
        return Type;
    }
}
