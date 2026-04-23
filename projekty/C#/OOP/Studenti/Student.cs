public class Student
{
    public string Jmeno { get; set; }
    public int Vek { get; set; }
    public string Trida { get; set; }

    public List<int> Znamky;


    public Student(string jmeno, int vek, string trida)
    {
        Jmeno = jmeno;
        Vek = vek;
        Trida = trida;
        Znamky = new List<int>();

    }
    public void PridatZnamky(int novaZnamka)
    {
        Znamky.Add(novaZnamka);
    }
    public void VypisZnamky()
    {
        Console.WriteLine("Znamky studenta:");
        foreach (int z in Znamky)
        {
            Console.WriteLine("    " + z);

        }
    }
}


