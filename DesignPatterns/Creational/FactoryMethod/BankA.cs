namespace DesignPatterns.Creational.FactoryMethod;
internal class BankA: IBank
{
    private readonly string BankName = "BankA";
    private int Amount = 0;

    public void Deposite(int amount)
    {
        //bankA Deposite implementation

        Amount += amount;
    }

    public void Withdraw(int amount)
    {
        if (amount > Amount)
            throw new ArgumentException("Invalid");

        //bankA Withdraw implementation

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
