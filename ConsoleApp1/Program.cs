class Program
{
    static void Square(int a, int b)
    {
        a = a + 1;
        b++;
        a = a * a;
        b *= b;
        Console.WriteLine(a + " " + b);
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Salary: ");
        string salary = Console.ReadLine();
        Console.WriteLine("Taxes: ");
        string taxes = Console.ReadLine();
        Show(float.Parse(salary), float.Parse(taxes));
        
    }

    static void Show(float a, float b)
    {
        Console.WriteLine("Salaire: " + a/12 + "€");
        Console.WriteLine("Taux d'imposition: " + b + "%");
        Console.WriteLine("Votre salaire net, apres l'imposition est de:" + ((a / 12) - ((a / 12)) * b / 100) + "€");
    }
}
