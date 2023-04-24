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
    public partial class Operaciones : ContentPage
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            //Variables
            double nota_seguimiento1 = Convert.ToDouble(txtNotaS1.Text)*0.3;
            double nota_examen1 = Convert.ToDouble(txtNotaE1.Text)*0.2;

            double nota_seguimiento2 = Convert.ToDouble(txtNotaS2.Text) * 0.3;
            double nota_examen2 = Convert.ToDouble(txtNotaE2.Text) * 0.2;

            //Proceso, suma de calificaciones
            double sumap1 = nota_seguimiento1 + nota_examen1;
            double sumap2 = nota_seguimiento2 + nota_examen2;

            double nota_final = sumap1 + sumap2;

            //Muestro el resultado de los parciales
            lblNotaP1.Text = sumap1.ToString();
            lblNotaP2.Text = sumap2.ToString();
            txtNotaFinal.Text = nota_final.ToString();

            //Verificar si el estudiante pasa de semestre
            if (nota_final >= 7)
            {
                txtEstado.Text = "APROBADO";
            }
            else
            {
                if(nota_final>=5 && nota_final <= 6.9)
                {
                    txtEstado.Text = "COMPLEMENTARIO";
                }
                else
                {
                    txtEstado.Text = "REPROBADO";
                }
            }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            //Boton Limpiar
            txtNotaS1.Text = "";
            txtNotaE1.Text = "";
            
            txtNotaS2.Text = "";
            txtNotaE2.Text = "";

            lblNotaP1.Text = "";
            lblNotaP2.Text = "";

            txtNotaFinal.Text = "";
            txtEstado.Text = "";
        }
    }
}