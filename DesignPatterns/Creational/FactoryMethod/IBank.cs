namespace DesignPatterns.Creational.FactoryMethod;
internal interface IBank
{
    void Deposite(int amount);
    void Withdraw(int amount);
    int GetAmount();
    string GetBankName();
}
