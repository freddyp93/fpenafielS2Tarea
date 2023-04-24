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

            MainPage = new Operaciones(); //Constructor
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
