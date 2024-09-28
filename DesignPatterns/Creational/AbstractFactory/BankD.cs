namespace DesignPatterns.Creational.FactoryMethod;
internal class BankD : IBank2
{
    private readonly string BankName = "BankB";
    private int Amount = 0;

    public void Deposite(int amount)
    {
        //bankB Deposite implementation

        Amount += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount > Amount)
            throw new ArgumentException("Invalid");

        //bankB Withdraw implementation

        Amount -= amount;
    }

    public int GetAmount()
    {
        return Amount;
    }

    public string GetBankName()
    {
        return BankName;
    }
}
