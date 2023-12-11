using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenR_CARS.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenR_CARS.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ppropina : ContentPage
    {
        public Ppropina()
        {
            InitializeComponent();
            BindingContext = new VMcalcularPro(Navigation);
        }
    }
}