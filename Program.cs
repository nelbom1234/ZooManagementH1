namespace ZooManagement;

class Program
{
    static void Main(string[] args)
    {
        Lion leo = new Lion("Leo", new DateTime(2013, 2, 10));
        Elephant dumbo = new Elephant("Dumbo", new DateTime(2022, 5, 14));
        Giraffe george = new Giraffe("George", new DateTime(2020, 6, 15));
        Penguin pingu = new Penguin("Pingu", new DateTime(2018, 10, 25));
        Enclosure enclosure = new Enclosure("Enclosure 1");
        Enclosure enclosure2 = new Enclosure("Enclosure 2");
        Zookeeper bill = new Zookeeper("Bill", new DateTime(1990, 7, 19), enclosure);
        Zookeeper Conny = new Zookeeper("Connie", new DateTime(1997, 12, 5), enclosure2);
        Zoo zoo = new Zoo("Zoo 1");

        zoo.AddEnclosure(enclosure);
        zoo.AddEnclosure(enclosure2);

        enclosure.AddAnimal(leo);
        enclosure.AddAnimal(dumbo);
        enclosure2.AddAnimal(george);
        enclosure2.AddAnimal(pingu);
        
        zoo.ListAllAnimals();
        
    }
}
