namespace csharp;

public class Person
{
    public Person(string firtname, string lastname, int age)
    {
        this.FirstName = firtname;
        this.LastName = lastname;
        this.Age = age;
    }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }

    public void Writeline(string s)
    {
        System.Console.WriteLine(s);
    }

}
