class Program
{
    static void Main()
    {
        Student borivoj = new Student("Borivoj", 67, "IT2B");

        Console.WriteLine("Jmeno: " + borivoj.Jmeno);

        borivoj.PridatZnamky(6);
        borivoj.PridatZnamky(7);

        borivoj.VypisZnamky();

        Student johnny = new Student ("Johnny", 47, "2.trida");
        Console.ReadKey();
    }
}