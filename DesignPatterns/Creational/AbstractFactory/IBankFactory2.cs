using DesignPatterns.Creational.AbstractFactory;

namespace DesignPatterns.Creational.FactoryMethod;
internal interface IBankFactory2
{
    IBank2? GetBank(string serial);
    IPaymentCard? GetCard(string serial);
}
