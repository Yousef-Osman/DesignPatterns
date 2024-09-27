namespace DesignPatterns.Structural.Decorator;
internal class EmployeeSMSDecorator : IEmployeeTask
{
    private readonly IEmployeeTask _employeeTask;

    public EmployeeSMSDecorator(IEmployeeTask employeeTask)
    {
        _employeeTask = employeeTask;
    }

    public List<string> Excute()
    {
        var result = _employeeTask.Excute();
        result.Add("An SMS with sent to the employee.");

        return result;
    }
}
