using System;
using System.Xml.Linq;



Console.WriteLine("=== 동물원에 오신 것을 환영합니다! ===");
Console.WriteLine();
Animal[] zoo =
{
     new Lion("시바", 5),
     new Elephant("덤보", 10),
     new Penguin("뽀로로", 3)
};
Console.WriteLine("[동물 정보]");
foreach (Animal animal in zoo)
{
    animal.DisplayInfo();
}
Console.WriteLine();
Console.WriteLine("[동물 소리]");
foreach (Animal animal in zoo)
{
    animal.MakeSound();
}
Console.WriteLine();
Console.WriteLine("[동물 행동]");
foreach (Animal animal in zoo)
{
    animal.Eat();
    if (animal is Lion lion)
        lion.Hunt();
    else if (animal is Elephant elephant)
        elephant.SprayWater();
    else if (animal is Penguin penguin)
        penguin.Swim();
}



// README.md를 읽고 코드를 작성하세요.
class Animal
{ 
    public string Name;
    public int Age;
    protected string _sound;

    public Animal(string name, int age, string _sound)
    { 
        Name = name;
        Age = age;
        this._sound = _sound;
    }
    public void Eat()
    {
        Console.WriteLine($"{Name}이(가)먹이를 먹습니다");
    }
    public void MakeSound()
    {
        Console.WriteLine($"{Name}: {_sound}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name},나이: {Age}살");
    }
}

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "으르렁!")
    {
    }
    public void Hunt()
    {
        Console.WriteLine($"{Name}이(가)사냥을 합니다");
    }
}
class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "뿌우!")
    {
    }
    public void SprayWater()
    {
        Console.WriteLine($"{Name}이(가)물을 뿌립니다");
    }
}
class Penguin : Animal
{
    public Penguin(string name, int age) : base(name, age, "꽥꽥!")
    {
    }
    public void Swim()
    {
        Console.WriteLine($"{Name}이(가)수영을 합니다");
    }
}













