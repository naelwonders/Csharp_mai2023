using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace exos_20230509_tableaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exo 1 
            //Écrire un algorithme qui saisit 6 entiers et les stocke dans un tableau, puis affiche le contenu de ce tableau une fois qu’il est rempli.

            //int[] tableau1 = new int[6];

            //for (int i = 0; i < 6; i++)
            //{
            //    int entier = 0;
            //    bool success = false;
            //    while (!success)
            //    {
            //        Console.WriteLine($"Donne un entier ({i + 1}/{tableau1.Length}) : ");
            //        success = int.TryParse(Console.ReadLine(), out entier);

            //    }

            //    tableau1[i] = entier;

            //}

            //Console.Write($"Les elements du tableaux : ");

            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write($"{tableau1[i]} ");
            //}

            #endregion

            #region Exo 2

            // BONUS : initialiser un tableau de 10 entiers avec les valeurs 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 à l’aide d’une boucle. Ensuite, à l’aide d’une boucle, afficher la valeur de chaque cellule du tableau avec l’opération Ecrire()

            //int[] tableau2 = new int[10]; // {2, 4, 8, 16, 32, 64, 128, 256, 512, 1024}
            //int number = 1;

            //for (int i = 0; i < tableau2.Length; i++) 
            //{
            //    tableau2[i] = number *= 2;

            //}

            //foreach (int i in tableau2)
            //{
            //    Console.WriteLine(i + " ");
            //}

            #endregion

            #region Exo 3

            // Ecrire un algorithme demandant à l’utilisateur le nombre de joueurs (max 10 joueurs). Ensuite,l’algorithme doit demander à l’utilisateur le score de chaque joueur. Une fois ceci fini, il faut afficher la moyenne des scores.

            //int joueurs = -1;
            //bool is_int = false;

            //while (joueurs < 0 || joueurs > 11)
            //{
            //    Console.WriteLine("Donnez le nombre de joueurs (max 10) : ");
            //    is_int = int.TryParse(Console.ReadLine(), out joueurs);
            //    Console.Clear();
            //}
            //// une liste de la taille du nombre de joueurs
            //int[] scores = new int[joueurs];
            //int score;
            //int somme_scores = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"Donnez le score du joueur {i + 1} : ");
            //    is_int = int.TryParse(Console.ReadLine(), out score);
            //    Console.Clear();

            //    if (is_int)
            //    {
            //        scores[i] = score;
            //        somme_scores += scores[i];
            //    }
            //}

            //int resultat = somme_scores / scores.Length;

            //Console.WriteLine(resultat);
            #endregion

            #region Exo 4 (ICI pour la prochaine fois mais fait un new document)
        }
    }
}