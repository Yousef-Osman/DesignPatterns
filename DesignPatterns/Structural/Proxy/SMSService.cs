namespace DesignPatterns.Structural.Proxy;
public class SMSService : ISMSService
{
    public string SendSMS(string userId, string message)
    {
        //get user mobile number from database using userId
        //send sms to the mobile number

        return "Message was sent successfully";
    }
}
