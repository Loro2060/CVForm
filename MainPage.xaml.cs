using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            string edad = Edad.Text;
            string pais = Pais.Text;
            string numero = Numero.Text;

            List<String> Ocupaciones = new List<String>();

            var Ocup = ocupacion.Children.ToList();

            foreach (var i in Ocup)
            {
                var myEntry = i as Entry;
                Ocupaciones.Add(myEntry.Text);
            }

            Application.Current.MainPage.Navigation.PushModalAsync(new Grid(nombre, edad, pais, numero, Ocupaciones), true);
        }
        private void Button_Ocupacion(object sender, EventArgs e)
        {
            var entry = new Entry() {};
            ocupacion.Children.Add(entry);

        }

    }
}
