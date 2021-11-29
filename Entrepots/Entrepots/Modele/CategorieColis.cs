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
        private string _image;

        #endregion

        #region Constructeurs

        public CategorieColis(string libelle, int nbCases, string image)
        {
            CategorieColis.CollClasse.Add(this);
            Libelle = libelle;
            NbCases = nbCases;
            Image = image;
        }


        #endregion

        #region Getters/Setters
        public string Libelle { get => _libelle; set => _libelle = value; }
        public int NbCases { get => _nbCases; set => _nbCases = value; }
        public string Image { get => _image; set => _image = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
