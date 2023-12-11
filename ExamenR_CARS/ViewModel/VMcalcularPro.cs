using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenR_CARS.ViewModel
{
    public class VMcalcularPro : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        double _MontoTotal;
        double _Porcentaje;
        double _Cuentas;
        double _Respuesta;
        double _MostrarRes;
        bool _Img;
        bool _Img2;

        #endregion
        #region CONSTRUCTOR
        public VMcalcularPro(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }

        public double MontoTotal
        {
            get { return _MontoTotal; }
            set { SetValue(ref _MontoTotal, value); }
        }
        public double Porcentaje
        {
            get { return _Porcentaje; }
            set { SetValue(ref _Porcentaje, value); }
        }
        public double Cuentas
        {
            get { return _Cuentas; }
            set { SetValue(ref _Cuentas, value); }
        }
        public double Respuesta
        {
            get { return _Respuesta; }
            set { SetValue(ref _Respuesta, value); }
        }
        public bool Img
        {
            get { return _Img; }
            set { SetValue(ref _Img, value); }
        }
        public bool Img2
        {
            get { return _Img2; }
            set { SetValue(ref _Img2, value); }
        }
        public double MostrarRes
        {
            get { return _MostrarRes; }
            set { SetValue(ref _MostrarRes, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void CalPropina()
        {
            Img = false;
            Img2 = false;

            double porce = MontoTotal / Porcentaje;
            Respuesta = MontoTotal + porce;
            MostrarRes = Respuesta / Cuentas;

            /*
            if (porce >= 10)
            {
                MostrarRes = true;
                Img = true;
            }
            else
            {
                MostrarRes=true;
                Img2= true;
            }*/
        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand Calcularcommand => new Command(CalPropina);
        #endregion
    }
}
