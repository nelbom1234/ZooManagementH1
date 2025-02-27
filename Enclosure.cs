using System.Reflection;

namespace ZooManagement;

class Enclosure {
    public string Name {get; private set;}
    public int Size {get; private set;}
    public List<Animal> Animals {get; private set;}

    public Enclosure() {
        Name = "";
        Size = 0;
        Animals = new List<Animal>();
    }

    public Enclosure(string name) : this() {
        Name = name;
    }

    //add animal to enclosure and maintain correct size
    public void AddAnimal(Animal animal) {
        Animals.Add(animal);
        Size++;
    }

    //remove animal from enclosure and maintain the correct size
    public void RemoveAnimal (Animal animal) {
        if (Animals.Remove(animal)) {
            Size--;
        }
    }

    public void ListAnimals() {
        System.Console.WriteLine($"Animals in {Name}:");
        foreach (Animal animal in Animals) {
            System.Console.WriteLine(animal);
        }
    }

    public void FeedAnimals() {
        System.Console.WriteLine($"Feeding the animals in {Name}");
        foreach (Animal animal in Animals) {
            animal.Eat();
        }
    }
}