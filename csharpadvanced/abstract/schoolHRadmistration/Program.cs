using HRAdministration;
using HRAdministrationApi;

List<IEmployee> employees = new List<IEmployee>();

SeedData(employees);


/*
decimal totalSalaries = 0;
foreach (IEmployee employee in employees){
   totalSalaries += employee.Salary;
}
Console.WriteLine($"The total salaries including bonuses are {totalSalaries}");
*/

Console.WriteLine($"The total salaries including bonuses are {employees.Sum(e => e.Salary)}");

static void SeedData(List<IEmployee> employees)
{

    IEmployee teacher1 = EmployeeFactory.GetEmployeeInstance(EmployeeType.Teacher,1,"Edwin","Muraya",40000);
    employees.Add(teacher1);

    IEmployee teacher2 = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 2, "Edie", "Kamau", 50000);
    employees.Add(teacher2);


    IEmployee teacher3 = EmployeeFactory.GetEmployeeInstance(EmployeeType.HeadOfDepartment, 3, "Nancy", "Kimani", 60000);
    employees.Add(teacher3);

    IEmployee teacher4 = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 4, "Edward", "Kuria", 70000);
    employees.Add(teacher4);

    IEmployee teacher5 = EmployeeFactory.GetEmployeeInstance(EmployeeType.DeputyHeadMaster, 5, "Jackson", "Mworia", 90000);
    employees.Add(teacher5);
}

public class Teacher : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.02m); }
}


public class HeadOfDepartment : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.03m); }
}

public class DeputyHeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
}

public class HeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.05m); }
}

public static class EmployeeFactory
{
    public static IEmployee GetEmployeeInstance(EmployeeType employeetype, int id, string firstName, string lastName, decimal salary)
    {
        IEmployee employee = null;
        switch (employeetype)
        {
            case EmployeeType.Teacher:
                employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                break;
            case EmployeeType.HeadMaster:
                employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                break;
            case EmployeeType.HeadOfDepartment:
                employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                break;
        }
        if(employee is not null) {
          employee.Id = id;
          employee.FirstName = firstName;
          employee.LastName = lastName;
          employee.Salary = salary;
        }
        return employee;
    }
}
