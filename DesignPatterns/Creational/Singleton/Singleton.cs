using System.Runtime.InteropServices;

namespace DesignPatterns.Creational.Singleton;
internal sealed class Singleton
{
    private static readonly object _lock = new object();
    private static Singleton? _instance { get; set; }
    public string? Value { get; set; } //extra info (not important)

    private Singleton() { }

    public static Singleton GetInstance([Optional] string? value)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.Value = value;
                }
            }
        }

        return _instance;
    }
}
