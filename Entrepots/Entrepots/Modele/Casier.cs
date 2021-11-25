using System;
using System.Collections.Generic;
using System.Text;

namespace Entrepots.Modele
{
    public class Casier
    {
        #region Attributs

        public static List<Casier> CollClasse = new List<Casier>();
        private int _numeroCasier;
        private int _nbrePlaces;
        private int _ligne;
        private int _colonne;
        private Entrepot _lentrepot;
        private List<Colis> _lesColis;

        #endregion

        #region Constructeurs

        public Casier(int numeroCasier, int ligne, int colonne, Entrepot lentrepot, int nbrePlaces)
        {
            Casier.CollClasse.Add(this);
            NumeroCasier = numeroCasier;
            Ligne = ligne;
            Colonne = colonne;
            this.Lentrepot = lentrepot;
            NbrePlaces = nbrePlaces;
            LesColis = new List<Colis>();
        }

        #endregion

        #region Getters/Setters
        public int NumeroCasier { get => _numeroCasier; set => _numeroCasier = value; }
        public int Ligne { get => _ligne; set => _ligne = value; }
        public int Colonne { get => _colonne; set => _colonne = value; }
        public Entrepot Lentrepot { get => _lentrepot; set => _lentrepot = value; }
        public int NbrePlaces { get => _nbrePlaces; set => _nbrePlaces = value; }
        public List<Colis> LesColis { get => _lesColis; set => _lesColis = value; }

        #endregion

        #region Methodes

        public void AjoutColis(Colis param)
        {
            this.LesColis.Add(param);
        }
        public bool EtrePlein()
        {
            bool resultat = false;
            if(this.LesColis.Count == this.NbrePlaces) resultat = true;
            return resultat;
        }

        public List<List<int>> GetInitialisationConstructionCasier()
        {
            List<List<int>> resultat = new List<List<int>>();

            for(int x = 0; x<this.Ligne; x++)
            {
                List<int> sublist = new List<int>();
                for (int y = 0; y < this.Colonne; y++)
                {
                    sublist.Add(0);
                }
                resultat.Add(sublist);
            }
            return resultat;
        }

        public List<List<int>> GetConstructionCasier()
        {
            List<List<int>> resultat = this.GetInitialisationConstructionCasier();

            foreach(Colis unColis in this._lesColis)
            {
                if (unColis.Ligne == 0 && unColis.Colonne == 0) break;
                for(int x =0; x< unColis.LaCategorie.NbCases;x++)
                resultat[unColis.Ligne-1][unColis.Colonne-1+x] = Convert.ToInt32( unColis.LaCategorie.NbCases);
            }


            return resultat;

        }

        public List<List<int>> RecherchePlaceLibre(Colis param)
        {
            List<List<int>> resultat = this.GetConstructionCasier();
            bool isBreak = false;
            for(int x = this.Ligne-1;x>=0;x--)
            {
                for (int y = 0; y < this.Colonne; y++)
                {
                    if (resultat[x][y]==0)
                    {
                        if(y+param.LaCategorie.NbCases<=this.Colonne)
                        {
                            for (int z = 0; z < param.LaCategorie.NbCases; z++)
                            {
                                resultat[x][y+z] = Convert.ToInt32(param.LaCategorie.NbCases);
                            }
                            param.Ligne = x+1; param.Colonne = y+1; this.AjoutColis(param); param.LeCasier = this ;
                            isBreak = true;
                            break;
                        }
                    }

                }
                if (isBreak) break;
            }

            return resultat;
        }

        public bool GetEmplacementLibre(int param)
        {

            bool resultat = false;
            List<List<int>> tableau = this.GetConstructionCasier();

            bool isBreak = false;
            for (int x = this.Ligne - 1; x >= 0; x--)
            {
                for (int y = 0; y < this.Colonne; y++)
                {
                    if (tableau[x][y] == 0)
                    {
                        if (y + param <= this.Colonne)
                        {
                            resultat = true;
                            isBreak = true;
                            break;
                        }
                    }

                }
                if (isBreak) break;
            }

            return resultat;
        }

        #endregion
    }
}
