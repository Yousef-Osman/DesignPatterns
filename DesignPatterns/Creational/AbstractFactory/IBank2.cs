namespace DesignPatterns.Creational.FactoryMethod;
internal interface IBank2
{
    void Deposite(int amount);
    void Withdraw(int amount);
    int GetAmount();
    string GetBankName();
}
