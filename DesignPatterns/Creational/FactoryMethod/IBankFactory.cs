namespace DesignPatterns.Creational.FactoryMethod;
internal interface IBankFactory
{
    IBank? GetBank(string serial);
}
