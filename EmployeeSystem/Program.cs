using System;


Console.WriteLine("=== 직원 급여 시스템 ===");
Manager manager = new Manager("김부장", 5000000, 1000000);
Developer developer = new Developer("이개발", 4000000, 10);
Intern intern = new Intern("박인턴");

manager.PrintInfo();
developer.PrintInfo();
intern.PrintInfo();

class Employee
{
    protected string _name;
    protected int _baseSalary;
    public Employee(string name, int baseSalary)
    {
        _name = name;
        _baseSalary = baseSalary;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetBaseSalary()
    {
        return _baseSalary;
    }

    public int CalculatePay()
    {
        return _baseSalary;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"이름: {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
    }
}


class Manager : Employee
{
    private int _bonus;

    public Manager(string name, int baseSalary, int bonus) : base(name, baseSalary)
    {
        _bonus = bonus;
    }
    public new int CalculatePay()
    {
        return _baseSalary + _bonus;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[매니저] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"보너스: {_bonus:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
        Console.WriteLine();
    }
}


class Developer : Employee
{
    private int _overtimeHours;
    public Developer(string name, int baseSalary, int overtimeHours) : base(name, baseSalary)
    {
        _overtimeHours = overtimeHours;
    }
    public new int CalculatePay()
    {
        return _baseSalary + _overtimeHours * 20000;
    }
    public new void PrintInfo()
    {
        Console.WriteLine($"[개발자] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"초과근무: {_overtimeHours}시간");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
        Console.WriteLine();
    }
}


class Intern : Employee
{
    public Intern(string name): base(name, 1500000)
    {
    }
    public new int CalculatePay()
    {
        return _baseSalary;
    }

    public new void PrintInfo()
    {
        Console.WriteLine($"[인턴] {_name}");
        Console.WriteLine($"기본급: {_baseSalary:N0}원");
        Console.WriteLine($"총 급여: {CalculatePay():N0}원");
        Console.WriteLine();
    }
}
