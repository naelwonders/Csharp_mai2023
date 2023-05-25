using System.Collections;

namespace exos20230509
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pour déplacer un bout de code en meme temps, tu selectionnes et alt et fleches
            // pour mettre en commentaire: ctl  + K + C (ou U pour le contraire)
            #region Tableau (meme type et taille fixe)

            #region Tableau 1D

            //int[] tableau = { 1, 2, 3, 4, 5, 6, 7 };
            //for (int i = 0; i < tableau.Length; i++)
            //{
            //    Console.WriteLine(tableau[i]);
            //}
            #endregion

            #region Tableau 2D


            //int[,] tableau2 = { { 1, 2, 3 }, 
            //                    { 4, 5, 6 }, 
            //                    { 7, 8, 9 } };
            //for (int i = 0; i < tableau2.GetLength(0); i++) // 0 c'est ligne et 1 c'est colonnes
            //{
            //    for ( int j = 0; j < tableau2.GetLength(1); j++)
            //    {
            //        Console.WriteLine(tableau2[i,j]);
            //    }
            //}
            #endregion

            #region Tableau 3D

            // deux virgules pour un tableau en 3D (genre rubiscube)
            //int[,,] tableau3 = {
            //                    { { 0, 1, 0 }, { 0, 3, 0 }, { 0, 3, 0 } },
            //                    { { 0, 4, 0 }, { 0, 5, 0 }, { 0, 6, 0 } },
            //                    { { 0, 7, 0 }, { 0, 8, 0 }, { 0, 9, 0 } }
            //                    };

            //for (int i = 0; i < tableau3.GetLength(0); i++) // 0 c'est ligne et 1 c'est colonnes
            //{
            //    for (int j = 0; j < tableau3.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < tableau3.GetLength(2); k++)
            //        {
            //            Console.WriteLine(tableau3[i, j, k]);
            //        };
            //    }
            //}
            #endregion

            #endregion

            #region Collection (taille variable et typage different)

            ArrayList arrayList = new ArrayList(); // obliger de l'instancier avec un new

            // pour copier coller une ligne rapidement juste en dessous: tu te met à la fin de la ligne puis ctrl c et ctrl v et tac
            // selectionne une valeur + ctrl H -> pour les changer une à la fois (et ca te donne le nombre d'occurances aussi)
            // alt et tu clique ta valeur pour les selectionner toutes
            arrayList.Add(3);
            arrayList.Add("lala");

            foreach (var item in arrayList)
            {
                Console.WriteLine($"L'element \"{item}\" est : {item.GetType()}");
            }
            
            #endregion

        }
    }
}