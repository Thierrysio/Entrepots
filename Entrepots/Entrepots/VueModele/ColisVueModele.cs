using Entrepots.Modele;
using Entrepots.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Entrepots.VueModele
{
    internal class ColisVueModele : BaseVueModele    
    {
        #region Attributs


        #endregion

        #region Constructeurs

        public ColisVueModele()
        {
        }

        #endregion

        #region Getters/Setters

        public ICommand CommandPlacerPetitColis => new Command(ActionCommandPlacerPetitColis);

        public ICommand CommandPlacerGrosColis => new Command(ActionCommandPlacerGrosColis);


        #endregion

        #region Methodes
        public void ActionCommandPlacerPetitColis()
        {
            this.GetPlacerColis("petit colis");
        }

        public void ActionCommandPlacerGrosColis()
        {
            this.GetPlacerColis("gros colis");
        }
        public void GetPlacerColis(string param)
        {
            var laCategorie = CategorieColis.CollClasse.FirstOrDefault(a => a.Libelle ==param);

            foreach (Entrepot unEntrepot in Entrepot.CollClasse)
            {
                if (!unEntrepot.EtrePlein())
                {
                    foreach (Casier unCasier in unEntrepot.LesCasiers)
                    {
                        if (!unCasier.EtrePlein() && unCasier.GetEmplacementLibre(laCategorie.NbCases))
                        {
                            List<List<int>> resultat = unCasier.RecherchePlaceLibre(new Colis(laCategorie, 0, 0, null));
                            Application.Current.MainPage = new CasierVue(resultat, unCasier);
                        }
                    }
                }



            }
        }
        #endregion
    }
}
