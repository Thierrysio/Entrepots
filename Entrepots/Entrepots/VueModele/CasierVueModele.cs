using Entrepots.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entrepots.VueModele
{
    internal class CasierVueModele : BaseVueModele
    {
        #region Attributs
        private List<CategorieColis> _lesColis = new List<CategorieColis>();
        Casier _leCasier;

        #endregion

        #region Constructeurs

        public CasierVueModele(List<List<int>> param,Casier param2)
        {
            LeCasier = param2;

            LesColis = this.GetlisteImages(param);
        }


        #endregion

        #region Getters/Setters

        #endregion

        public List<CategorieColis> LesColis
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
        public List<CategorieColis> GetlisteImages(List<List<int>>  param)
        {
            List<CategorieColis> resultat = new List<CategorieColis>();

            for (int x = 0; x < LeCasier.Ligne; x++)
            {
                for (int y = 0; y < LeCasier.Colonne; y++)
                {
                    // codage du remplissage de la liste d'images
                   
                        var laCategorie = CategorieColis.CollClasse.FirstOrDefault(a => a.NbCases == param[x][y]);

                        resultat.Add(laCategorie);
                    

                }
            }

            return resultat;

        }
        #endregion
    }
}
