namespace DesignPatterns.Structural.Decorator;
internal class EmployeeTask : IEmployeeTask
{
    public List<string> Excute()
    {
        //assign user to task logic
        return new List<string> { "User assigned to task" };
    }
}
