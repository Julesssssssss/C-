using Microsoft.Win32.SafeHandles;
using System.Collections;

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
        Console.WriteLine("Votre salaire a l'année (en brut): ");
        bool salaryIsInt = double.TryParse(Console.ReadLine(), out double salary);
        if (salaryIsInt)
        {
            Console.WriteLine("Votre pourcentage de taxes: ");
            bool taxIsInt = double.TryParse(Console.ReadLine(), out double taxes);

            if (taxIsInt)
            {
                Show(salary, taxes);
                
                if (salary > 50000)
                {
                    Console.WriteLine("Il faudrait faire des dons pour réduire tes impots");
                }
                else if ((salary / 12) < 1500)
                {
                    Console.WriteLine("C'est normal pour un alternant :)");
                }
                else if (salary < 40000 || salary > 30000)
                {
                    Console.WriteLine("Je te conseille de venir faire un bac +5 en dev au CESI");
                }
                salary = ((salary / 12) - ((salary / 12) * taxes / 100));
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

        try
        {
            Console.WriteLine("Quel est le pourcentage de votre prime en décembre ? ");
            bool primeIsInt = int.TryParse(Console.ReadLine(), out int prime);
            if (primeIsInt)
            {
                string[] months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };

                foreach (string month in months)
                {
                    if (month == "Decembre")
                    {
                        Console.WriteLine("En " + month + " votre salaire est de: " + (salary + salary * prime / 100) + "€");
                    }
                    else if (month == "Aout")
                    {
                        Console.WriteLine("En " + month + " vous n'avez pas de salaire puisque l'entreprise est fermé");
                    }
                    else
                    {
                        Console.WriteLine("En " + month + " votre salaire est de: " + salary + "€");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter an integer for your december bounty");
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e + " You had to enter an integer");
        }
        


    }
    static void Show(double a, double b)
    {
        Console.WriteLine("Salaire brut mensuel: " + a / 12 + "€");
        Console.WriteLine("Taux d'imposition: " + b + "%");
        Console.WriteLine("Votre salaire net, apres l'imposition est de: " + ((a / 12) - ((a / 12)) * b / 100) + "€");

    }
}


