namespace DesignPatterns.Structural.Proxy;
public class ProxyClient
{
    public static void Test()
    {
        var sender = new SMSServiceProxy();

        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("32569", "Some random text message"));
        Console.WriteLine(sender.SendMessage("32569", "Some random text message"));
        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("65285", "Some random text message"));
        Console.WriteLine(sender.SendMessage("83527", "Some random text message"));
    }
}
