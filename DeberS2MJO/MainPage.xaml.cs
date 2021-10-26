using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeberS2MJO
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string user)
        {
            InitializeComponent();

            lblUser.Text = user;
        }

        private void btnNota_Clicked(object sender, EventArgs e)
        {
            //try catch 
            //asignacion de valores ingreso de datos desde xaml para parcial 1
            double dato1 = Convert.ToDouble(TxtDato1.Text);
            double dato2 = Convert.ToDouble(TxtDato2.Text);

            //Accion calculo parcial 1
            double N1 = dato1 * 0.3;
            double N2 = dato2 * 0.2;
            double N3 = N1 + N2;
            TxtNota1.Text = N3.ToString();

            //asignacion de valores ingreso de datos desde xaml para parcial 2
            double dato3 = Convert.ToDouble(TxtDato3.Text);
            double dato4 = Convert.ToDouble(TxtDato4.Text);

            //Accion calculo parcial 2
            double N4 = dato3 * 0.3;
            double N5 = dato4 * 0.2;
            double N6 = N4 + N5;
            TxtNota2.Text = N6.ToString();

            //Accion calculo nota final
            double N7 = N3 + N6;
            txtNOTAF.Text = N7.ToString();

            //variable para condicioanl 
            string resultalado = "";
            if (N7 > 6)
            {
                resultalado = "APROBADO";
            }
            else
            {
                resultalado = "REPROBADO";
            }
            DisplayAlert("USTED ESTA: ", resultalado + N7, "OK");
        }

    }
 }

