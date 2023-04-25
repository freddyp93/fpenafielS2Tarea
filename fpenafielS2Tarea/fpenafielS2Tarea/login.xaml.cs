using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace fpenafielS2Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            // acceso a la pantalla Operaciones desde Login
            //Variables
            string usuario = txtUsuario.Text;
            string contrasena = txtPassword.Text;

            //verificacion de datos
            if(usuario == "estudiante2023" && contrasena == "uisrael2023")
            {
                //Llamo a la pantalla de Operaciones
                Navigation.PushAsync(new Operaciones());
            }
            else
            {
                //muestro una alerta en el caso que el usuario o contrasenia sea incorrecto
                DisplayAlert("ERROR", "Usuario/Contrasña Incorrecto", "Cerrar");

                //limpio los campos de texto
                txtUsuario.Text = "";
                txtPassword.Text = "";
            }
        }
    }
}