using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;

            while(true)
            {
                Console.WriteLine("1 : Multiples de 2");
                Console.WriteLine("2 : Somme jusqu'à n");
                Console.WriteLine("3 : Calcul de moyenne");
                Console.WriteLine("4 : Somme des entiers entre x et y");
                Console.WriteLine("5 : Calcul de moyenne sur une liste");
                Console.WriteLine("6 : Entiers communs à deux listes");
                Console.WriteLine("");
                Console.Write("Quel exercice tester ?");
                choix = Int32.Parse(Console.ReadLine());


                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Exercice 1 : Multiples de 2");
                        for (int i = 0; i <= 20; i = i + 2)
                        {
                            Console.WriteLine(i);
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Exercice 2 : Somme jusqu'à n");
                        Console.Write("Saisissez un nombre :");
                        int nb = Int32.Parse(Console.ReadLine());
                        int somme = nb;
                        for (int i = 0; i < nb; i++)
                        {
                            somme += i;
                        }
                        Console.Write("Le total est de : " + somme);
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Exercice 3 : Calcul de moyenne");
                        int[] valeurs = new int[5];
                        int sommeValeurs = 0;

                        for (int i = 0; i < valeurs.Length; i++)
                        {
                            Console.Write("nombre n°" + (i + 1) + " :");
                            valeurs[i] = Int32.Parse(Console.ReadLine());
                        }

                        for (int i = 0; i < valeurs.Length; i++)
                        {
                            sommeValeurs += valeurs[i];
                        }
                        int moyenne = sommeValeurs / valeurs.Length;
                        Console.Write("La moyenne est de : " + moyenne);
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Exercice 4 : Somme des entiers entre x et y");
                        Console.Write("Saisissez le premier nombre :");
                        int nb1 = Int32.Parse(Console.ReadLine());

                        Console.Write("Saisissez le deuxième nombre :");
                        int nb2 = Int32.Parse(Console.ReadLine());

                        int moyenneEntiers = CalculSommeEntiers(nb1, nb2);
                        Console.WriteLine("La moyenne des entiers compris entre " + nb1 + " et " + nb2 + " et de " + moyenneEntiers);

                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("Exercice 5 : Calcul de moyenne sur une liste");
                        var liste = new List<double>();

                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("Renseignez le nombre n°" + (i + 1) + " :");
                            liste.Add(Double.Parse(Console.ReadLine()));
                        }

                        var moyenneListe = CalculMoyenneListe(liste);
                        Console.WriteLine("La moyenne des nombres est de " + moyenneListe);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Exercice 6 : Construction de listes et entiers communs");
                        List<int> multiplesDeTrois = ObtenirMultiples(3);
                        List<int> multiplesDeCinq = ObtenirMultiples(5);
                        List<int> entierscommuns = TrouverEntiersCommuns(multiplesDeCinq, multiplesDeTrois);

                        var sommeEntiers = 0;
                        entierscommuns.ForEach(entier => {
                            sommeEntiers += entier;
                        });

                        Console.Write("La moyenne est de : " + sommeEntiers);
                        Console.ReadLine();
                        break;

                }

            };

        }

        public static int CalculSommeEntiers(int x, int y)
        {
            int moyenne = 0;

            for (int i = x; i <= y; i++)
            {
                moyenne += i;
            }

            return moyenne;
        }

        public static double CalculMoyenneListe(List<double> liste)
        {
            double moyenne = liste.Average();
            return moyenne;
        }

        public static List<int> ObtenirMultiples(int multiplicateur)
        {
            var multiples = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if (i % multiplicateur == 0)
                {
                    multiples.Add(i);
                    Console.WriteLine(i);
                }
            }

            return multiples;
        }

        public static List<int> TrouverEntiersCommuns(List<int> liste1, List<int> liste2)
        {
            var entiersCommuns = new List<int>();
            foreach (int entier in liste1)
            {
                if (liste2.Contains(entier))
                {
                    entiersCommuns.Add(entier);
                    Console.WriteLine(entier);
                }
            }

            return entiersCommuns;
        }
    }
}