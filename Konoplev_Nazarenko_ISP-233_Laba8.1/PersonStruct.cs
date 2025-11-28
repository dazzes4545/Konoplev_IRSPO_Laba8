public struct PersonStruct
{
    public string name;
    public int age;
    //public PersonStruct()
    //{
    //    name = "Undefined";
    //    age = 18;
    //}
    public PersonStruct(string name = "Tom", int age = 1)
    {
        this.name = name;
        this.age = age;
    }
    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
}
