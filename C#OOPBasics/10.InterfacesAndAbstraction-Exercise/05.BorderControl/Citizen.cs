public class Citizen:DystopianSociety
{
    public int Age { get; set; }

    public Citizen(string name,int age ,string id) : base(name, id)
    {
        this.Age = age;
    }
}