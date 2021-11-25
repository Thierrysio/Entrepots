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
    public partial class ColisVue : ContentPage
    {
        ColisVueModele vueModele;
        public ColisVue()
        {
            InitializeComponent();
            BindingContext = vueModele = new ColisVueModele();

        }
    }
}