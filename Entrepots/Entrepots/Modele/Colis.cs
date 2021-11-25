using System;
using System.Collections.Generic;
using System.Text;

namespace Entrepots.Modele
{
    public class Colis
    {
        #region Attributs

        public static List<Colis> CollClasse = new List<Colis>();

        private CategorieColis _laCategorie;
        private int _ligne;
        private int _colonne;
        private Casier _leCasier;

        #endregion

        #region Constructeurs

        public Colis(CategorieColis laCategorie, int ligne, int colonne, Casier leCasier)
        {
            Colis.CollClasse.Add(this);
            LaCategorie = laCategorie;
            this.Ligne = ligne;
            this.Colonne = colonne;
            this.LeCasier = leCasier;
            
        }

        #endregion

        #region Getters/Setters
        public CategorieColis LaCategorie { get => _laCategorie; set => _laCategorie = value; }
        public int Ligne { get => _ligne; set => _ligne = value; }
        public int Colonne { get => _colonne; set => _colonne = value; }
        public Casier LeCasier { get => _leCasier; set => _leCasier = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
