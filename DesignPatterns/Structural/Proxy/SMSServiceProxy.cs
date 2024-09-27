namespace DesignPatterns.Structural.Proxy;
internal class SMSServiceProxy
{
    private ISMSService _smsService { get; set; } = default!;
    private Dictionary<string, int> _UserSMSCount = new Dictionary<string, int>();
    private readonly int MaxCount = 5;
    private readonly int first = 1;

    public string SendMessage(string userId, string message)
    {
        if (_smsService is null)
            _smsService = new SMSService();

        if (!_UserSMSCount.ContainsKey(userId))
        {
            _UserSMSCount.Add(userId, first);
            return _smsService.SendSMS(userId, message);
        }

        if (_UserSMSCount[userId] == MaxCount)
            return "SMS quota maxed out";

        _UserSMSCount[userId] = ++_UserSMSCount[userId];
        return _smsService.SendSMS(userId, message);
    }
}
