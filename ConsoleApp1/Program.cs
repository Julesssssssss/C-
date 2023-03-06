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
        Console.WriteLine("Entrez dabord votres salaire, puis les taxes:");
        Console.WriteLine("Votre salaire a l'année: ");
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);
        if (salaryIsInt)
        {
            Console.WriteLine("Votre pourcentage de taxes: ");
            bool taxIsInt = int.TryParse(Console.ReadLine(), out int taxes);

            if (taxIsInt)
            {
                Show(salary,taxes);
        
                if (salary > 50000)
                {
                    Console.WriteLine("Il faudrait faire des dons pour réduire tes impots");
    }
                else if ((salary / 12) < 1500)
                {
                    Console.WriteLine("C'est normal pour un alternant :)");
                }
                else if (salary< 40000 || salary > 30000)
                {
                    Console.WriteLine("Je te conseille de venir faire un bac +5 en dev au CESI");
                }
            }
            else
            {
                Console.WriteLine("You had to enter an integer");
            }
        }
        else
        {
            Console.WriteLine("You had to enter an integer");
        }


    }
    static void Show(float a, float b)
    {
        Console.WriteLine("Salaire: " + a / 12 + "€");
        Console.WriteLine("Taux d'imposition: " + b + "%");
        Console.WriteLine("Votre salaire net, apres l'imposition est de: " + ((a / 12) - ((a / 12)) * b / 100) + "€");
   
}
