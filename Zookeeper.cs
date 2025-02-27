namespace ZooManagement;

class Zookeeper {
    public string Name { get; private set; }
    public DateTime Birthdate { get; private set; }
    public Enclosure AssignedEnclosure { get; private set; }

    public Zookeeper(string name, DateTime birthdate, Enclosure assignedEnclosure) {
        Name = name;
        Birthdate = birthdate;
        AssignedEnclosure = assignedEnclosure;
    }

    //calculate the age of zookeeper through mathemagic
    public int Age() {
        int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int dob = int.Parse(Birthdate.ToString("yyyyMMdd"));
        return (now - dob) / 10000;
    }

    public void FeedAnimals() {
        //mention which zookeeper is doing the feeding
        System.Console.Write($"{Name} is ");
        AssignedEnclosure.FeedAnimals();
    }

    public void CleanEnclosure() {
        System.Console.WriteLine($"{AssignedEnclosure.Name} has been cleaned by {Name}");
    }
}