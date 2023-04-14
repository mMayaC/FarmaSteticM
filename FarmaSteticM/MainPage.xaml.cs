using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FarmaSteticM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string docum = Documentotxt.Text;
            string cont = Contraseñatxt.Text;

            if (docum == "43065" && cont == "123")
            {
                Navigation.PushAsync(new Welcome());
            }
                    else
                    {
                        DisplayAlert("Alerta", "Su documento o contraseña no son correctos", "ok");
                    }
                }
            }
        }

