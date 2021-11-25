using System;
using System.Collections.Generic;
using System.Text;

namespace Entrepots.Modele
{
    public class Entrepot
    {
        #region Attributs

        public static List<Entrepot> CollClasse = new List<Entrepot>();
        private int _numeroEntrepot;
        private string _libelleEntrepot;
        private List<Casier> _lesCasiers;

        #endregion

        #region Constructeurs

        public Entrepot(int numeroEntrepot, string libelleEntrepot)
        {
            Entrepot.CollClasse.Add(this);
            NumeroEntrepot = numeroEntrepot;
            LibelleEntrepot = libelleEntrepot;
            LesCasiers = new List<Casier>();
        }

        #endregion

        #region Getters/Setters
        public int NumeroEntrepot { get => _numeroEntrepot; set => _numeroEntrepot = value; }
        public string LibelleEntrepot { get => _libelleEntrepot; set => _libelleEntrepot = value; }
        public List<Casier> LesCasiers { get => _lesCasiers; set => _lesCasiers = value; }
        #endregion

        #region Methodes

        public bool EtrePlein()
        {
            bool resultat = false;
            foreach(Casier unCasier in this.LesCasiers)
                {
                if (unCasier.EtrePlein())
                {
                    resultat = true;    
                }
                else
                {
                    resultat = false;
                    break;
                }
            }
            return resultat;
        }

        public Casier GetCasierPasPlein()
        {
            Casier resultat = null;
            foreach (Casier unCasier in this.LesCasiers)
            {
                if (unCasier.EtrePlein()== false) resultat = unCasier;
            }
            return resultat;
        }

        public void AjoutUnCasier(Casier param)
        {
            this.LesCasiers.Add(param);
        }


        #endregion
    }
}
