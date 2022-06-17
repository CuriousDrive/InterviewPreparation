Employee employee = new CEO();
employee.EnterBuilding("AXNF");
employee.CalculateBonus();

interface IPerson
{
    int GetAge();
    string GetFullName();
}

public class Person : IPerson
{
    public int FirstName { get; set; }
    public int LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public int GetAge() => DateTime.Now.Year - DateOfBirth.Year;
    public string GetFullName() => $"{FirstName} {LastName}";
}

public abstract class Employee : Person
{
    public virtual void EnterBuilding(string accessCode)
       => Console.WriteLine("Employee is entering the building");
    
    public abstract int CalculateBonus();
}

public class CEO : Employee
{
    public override int CalculateBonus()
    {
        Console.WriteLine("Calculating bonus for \"CEO\"");
        return 100;
    }

    public override void EnterBuilding(string accessCode)
    {
        base.EnterBuilding(accessCode);
        Console.WriteLine("CEO is entering the building");
    }
}