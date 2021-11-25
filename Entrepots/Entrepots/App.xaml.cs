using Entrepots.Modele;
using Entrepots.Vue;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Entrepots
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ColisVue();

            CategorieColis ct1 = new CategorieColis("petit colis", 1);
            CategorieColis ct2 = new CategorieColis("gros colis", 3);


            Entrepot E1 = new Entrepot(1, "Entrepot 01");

            Casier C1 = new Casier(1, 3, 3, E1, 9);
            E1.AjoutUnCasier(C1);


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
