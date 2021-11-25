using System;
using System.Collections.Generic;
using System.Text;

namespace Entrepots.Modele
{
    public class CategorieColis
    {
        #region Attributs

        public static List<CategorieColis> CollClasse = new List<CategorieColis>();

        private string _libelle;
        private int _nbCases;

        #endregion

        #region Constructeurs

        public CategorieColis(string libelle, int nbCases)
        {
            CategorieColis.CollClasse.Add(this);
            Libelle = libelle;
            NbCases = nbCases;
        }


        #endregion

        #region Getters/Setters
        public string Libelle { get => _libelle; set => _libelle = value; }
        public int NbCases { get => _nbCases; set => _nbCases = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
