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
        bool salaryIsInt = int.TryParse(Console.ReadLine(), out int salary);
        if (salaryIsInt)
        {
            Console.WriteLine("Votre pourcentage de taxes: ");
            bool taxIsInt = int.TryParse(Console.ReadLine(), out int taxes);

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


        string[] mois = new string[12];
        mois[0]= "Janvier";
        mois[1]= "Fevrier";
        mois[2]= "Mars";
        mois[3]= "Avril";
        mois[4]= "Mai";
        mois[5]= "Juin";
        mois[6]= "Juillet";
        mois[7]= "Aout";
        mois[8]= "Septembre";
        mois[9]= "Octobre";
        mois[10]= "Novembre";
        mois[11]= "Decembre";

        foreach (string mo in mois)
        {
            if (mo == "Decembre")
            {
                Console.WriteLine("En " + mo + " votre salaire est de: " + (salary + salary * 10/100) + "€");
            }
            else if(mo == "Aout")
            {
                Console.WriteLine("En " + mo + " vous n'avez pas de salaire puisque l'entreprise est fermé");
            }
            else
            {
                Console.WriteLine("En " + mo + " votre salaire est de: " + salary + "€");
            }
        }




    }
    static void Show(float a, float b)
    {
        Console.WriteLine("Salaire brut mensuel: " + a / 12 + "€");
        Console.WriteLine("Taux d'imposition: " + b + "%");
        Console.WriteLine("Votre salaire net, apres l'imposition est de: " + ((a / 12) - ((a / 12)) * b / 100) + "€");

    }
}


