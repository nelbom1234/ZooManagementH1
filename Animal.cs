namespace ZooManagement;

abstract class Animal {
    public string Name { get; private set;}
    public string Species { get; private set;}
    public DateTime Birthdate { get; private set;}
    public string Sound { get; private set;}

    public Animal(string name, string species, DateTime birthdate, string sound) {
        Name = name;
        Species = species;
        Birthdate = birthdate;
        Sound = sound;
    }

    public void MakeSound() {
        System.Console.WriteLine(Sound);
    }

    public void Eat() {
        System.Console.WriteLine($"{Name} the {Species} is eating.");
    }

    public void Sleep() {
        System.Console.WriteLine($"{Name} the {Species} is sleeping.");
    }

    //calculate the age of the animal through mathemagic
    public int Age() {
        int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
        int dob = int.Parse(Birthdate.ToString("yyyyMMdd"));
        return (now - dob) / 10000;
    }

    //format the output when printing animal
    public override string ToString()
    {
        return $"{Name} the {Age()} year old {Species}";
    }
}