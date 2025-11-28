//class Person
//{
//    private string name = "Undefined";
//    private int age = 1;
//    public string Name
//    {
//        get { return name; }  //get => name;(сокращенная запись)
//        set { name = value; }
//    }

//    public int Age
//    {
//        get => age;
//        set
//        {
//            if (value < 1 || value > 120)
//            {
//                Console.WriteLine("Недопустимый возраст");
//            }
//            else { age = value; }
//        }
//    }
//}

using Base;

class Person
{
    string name;
    Company company;

    public Person(string name, Company company)
    {
        this.name = name;
        this.company = company;
    }

    public void Print()
    {
        Console.WriteLine($"Имя: {name}");
        company.Print();
    }
}