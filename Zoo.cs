namespace ZooManagement;

class Zoo {
    public string Name { get; private set; }
    public List<Enclosure> Enclosures { get; private set; }

    public Zoo() {
        Name ="";
        Enclosures = new List<Enclosure>();
    }

    public Zoo(string name) : this() {
        Name = name;
    }

    public void AddEnclosure(Enclosure enclosure) {
        Enclosures.Add(enclosure);
    }

    public void ListAllAnimals() {
        System.Console.WriteLine($"Listing all animals in {Name}: ");
        foreach (Enclosure enclosure in Enclosures) {
            enclosure.ListAnimals();
        }
    }
}