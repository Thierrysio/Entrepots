using Entrepots.Modele;
using Entrepots.VueModele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Entrepots.Vue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CasierVue : ContentPage
    {
        CasierVueModele vueModele;

        public CasierVue(List<List<int>> param, Casier param2)
        {
            InitializeComponent();
            BindingContext = vueModele = new CasierVueModele(param,param2);

        }
    }
}