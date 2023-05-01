namespace AnimalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dog circo = new Dog(15, true, "Circo");
            circo.Talk();
            circo.TouchMe();
            circo.FeedMe();
            Console.WriteLine(circo);

            Goat goat1 = new Goat(12, true, "Goaty");
            goat1.MilkMe();

            Console.ReadLine();
        }
    }
}