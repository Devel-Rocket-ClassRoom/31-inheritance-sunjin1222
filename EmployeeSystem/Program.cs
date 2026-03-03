using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");


class Employee
{
    private string _name;
    private int _baseSalary;

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
    public new int CalculatePay()
    {
        return _baseSalary;
    }
    public void PrintInfo()
    {
        Console.WriteLine("이름: ");
           
    }

}








