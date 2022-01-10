namespace HRAdministration;

public class EmployeeBase : IEmployee
{
    public int Id { get ; set ; }
    public string FirstName { get ; set ; } = string.Empty;
    public string LastName { get ; set ; } = string.Empty;
    public virtual decimal Salary { get ; set ; }
}
