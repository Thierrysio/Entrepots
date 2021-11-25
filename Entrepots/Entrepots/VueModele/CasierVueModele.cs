using Entrepots.Modele;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entrepots.VueModele
{
    internal class CasierVueModele : BaseVueModele
    {
        #region Attributs
        private List<string> _lesColis = new List<string>();
        Casier _leCasier;

        #endregion

        #region Constructeurs

        public CasierVueModele(List<List<int>> param,Casier param2)
        {
            LesColis = this.GetlisteImages(param);
            LeCasier = param2;
        }


        #endregion

        #region Getters/Setters

        #endregion

        public List<string> LesColis
        {
            get
            {
                return _lesColis;
            }
            set
            {
                SetProperty(ref _lesColis, value);
            }
        }
        public Casier LeCasier { get => _leCasier; set => _leCasier = value; }


        #region Methodes
        public List<string> GetlisteImages(List<List<int>>  param)
        {
            List<string> resultat = new List<string>();

            for (int x = 0; x < LeCasier.Ligne; x++)
            {
                for (int y = 0; y < LeCasier.Colonne; y++)
                {
                    // codage du remplissage de la liste d'images


                }
            }

            return resultat;

        }
        #endregion
    }
}
