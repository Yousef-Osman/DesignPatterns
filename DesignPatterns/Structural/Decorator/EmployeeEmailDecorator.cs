namespace DesignPatterns.Structural.Decorator;
internal class EmployeeEmailDecorator : IEmployeeTask
{
    private readonly IEmployeeTask _employeeTask;

    public EmployeeEmailDecorator(IEmployeeTask employeeTask)
    {
        _employeeTask = employeeTask;
    }

    public List<string> Excute()
    {
        var result = _employeeTask.Excute();
        result.Add("An email with sent to the employee.");

        return result;
    }
}
