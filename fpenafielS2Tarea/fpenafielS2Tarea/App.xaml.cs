using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpenafielS2Tarea
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Habilito la navegacion entre pantallas
            MainPage = new NavigationPage(new login()); //Operaciones(); //Constructor
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
