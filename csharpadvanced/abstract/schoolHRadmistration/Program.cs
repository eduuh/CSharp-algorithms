using HRAdministration;

List<IEmployee> employees = new List<IEmployee>();

SeedData(employees);


/*
decimal totalSalaries = 0;
foreach (IEmployee employee in employees){
   totalSalaries += employee.Salary;
}
Console.WriteLine($"The total salaries including bonuses are {totalSalaries}");
*/

Console.WriteLine($"The total salaries including bonuses are {employees.Sum( e => e.Salary)}");

static void SeedData (List<IEmployee> employees) {

  IEmployee teacher1 = new Teacher {
     FirstName = "Edwin",
     Id = 1,
     LastName = "Muraya",
     Salary = 40000
  };

  employees.Add(teacher1);


  IEmployee teacher2 = new Teacher {
     FirstName = "Edie",
     Id = 3,
     LastName = "Kamau",
     Salary = 50000
  };

  employees.Add(teacher2);


  IEmployee teacher3 = new Teacher {
     FirstName = "Nancy",
     Id = 3,
     LastName = "Kimani",
     Salary = 60000
  };

  employees.Add(teacher3);


  IEmployee teacher4 = new Teacher {
     FirstName = "Edward",
     Id = 4,
     LastName = "Kuria",
     Salary = 70000
  };

  employees.Add(teacher4);
  IEmployee teacher5 = new Teacher {
     FirstName = "Jackson",
     Id = 5,
     LastName = "Mworia",
     Salary = 70000
  };
  employees.Add(teacher5);
}

public class Teacher : EmployeeBase {
  public override decimal Salary { get => base.Salary + (base.Salary * 0.02m);}
}


public class HeadOfDepartment : EmployeeBase {
  public override decimal Salary { get => base.Salary + (base.Salary * 0.03m);}
}

public class DeputyHeadMaster : EmployeeBase {
  public override decimal Salary { get => base.Salary + (base.Salary * 0.04m);}
}

public class HeadMaster : EmployeeBase {
  public override decimal Salary { get => base.Salary + (base.Salary * 0.05m);}
}
