namespace DesignPatterns.Structural.Decorator;
internal class EmployeeNotificationDecorator : IEmployeeTask
{
    private readonly IEmployeeTask _employeeTask;

    public EmployeeNotificationDecorator(IEmployeeTask employeeTask)
    {
        _employeeTask = employeeTask;
    }

    public List<string> Excute()
    {
        var result = _employeeTask.Excute();

        //logic to send notification
        result.Add("A notification with sent to the employee.");

        return result;
    }
}
