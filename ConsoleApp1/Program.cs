using Microsoft.Win32.SafeHandles;
using System.Collections;

class User
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int Salary { get; set; }
    public double Tax { get; set; }
}
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
        User user = new User();
        Console.WriteLine("Quel est votre ID : ");
        user.ID = int.Parse(Console.ReadLine());
        Console.WriteLine("Quel est votre Prénom : ");
        user.FirstName = Console.ReadLine();
        Console.WriteLine("Quel est votre Nom : ");
        user.LastName = Console.ReadLine();
        Console.WriteLine("Quel est votre Âge : ");
        user.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Quel est votre Salaire annuel Brut : ");
        user.Salary = int.Parse(Console.ReadLine().Replace("€", ""));
        Console.WriteLine("Quel est votre Taux d'imposition : ");
        user.Tax = double.Parse(Console.ReadLine().Replace("%", ""));
        Console.WriteLine("\nID : " + user.ID);
        Console.WriteLine("Prénom : " + user.FirstName);
        Console.WriteLine("Nom : " + user.LastName);
        Console.WriteLine("Âge : " + user.Age);
        Console.WriteLine("Salaire Brut : " + user.Salary + "€");
        Console.WriteLine("Taux d'imposition : " + user.Tax + "%");
        

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




        static void Show(double a, double b)
        {
            Console.WriteLine("Salaire brut mensuel: " + a / 12 + "€");
            Console.WriteLine("Taux d'imposition: " + b + "%");
            Console.WriteLine("Votre salaire net, apres l'imposition est de: " + ((a / 12) - ((a / 12)) * b / 100) + "€");

        }
    }
}



