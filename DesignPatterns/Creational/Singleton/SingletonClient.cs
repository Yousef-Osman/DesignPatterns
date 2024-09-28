namespace DesignPatterns.Creational.Singleton;
internal class SingletonClient
{
    public static void Test()
    {
        var instance1 = Singleton.GetInstance("1");
        var instance2 = Singleton.GetInstance("2");

        var message = instance1 != instance2 ? "Not the same instance" : "Same instance";

        Console.WriteLine(instance1.Value);
        Console.WriteLine(instance2.Value);

        Console.WriteLine(message);
    }
}
