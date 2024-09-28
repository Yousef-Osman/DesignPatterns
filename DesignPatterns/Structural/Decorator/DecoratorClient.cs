namespace DesignPatterns.Structural.Decorator;
internal class DecoratorClient
{
    public static void Test()
    {
        IEmployeeTask employeeTask = new EmployeeTask();

        employeeTask = new EmployeeEmailDecorator(employeeTask);
        employeeTask = new EmployeeNotificationDecorator(employeeTask);
        employeeTask = new EmployeeSMSDecorator(employeeTask);

        var result = employeeTask.Excute();

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
