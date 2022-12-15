using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Runtime.InteropServices.ComTypes;
using Xamarin.Forms.PlatformConfiguration;



namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Grid : ContentPage
    {
        public Grid(string Nombre, string Edad, string Pais, string Num, List<String> Ocup)
        {
            InitializeComponent();

            Nombre1.Text = Nombre;
            Edad1.Text = Edad;
            Procedencia.Text = Pais;
            Numero.Text = Num;

            foreach (var i in Ocup)
            {
                var label = new Label { Text = i };
                Ocupaciones.Children.Add(label);
            }

        }

        void GenerarEmail(object sender, System.EventArgs e)
        {
            List<string> toAddress = new List<string>();
            string cuerpo = Nombre1.Text + Edad1.Text + Procedencia.Text + Numero.Text;
            toAddress.Add("jacintopichimawido25@gmail.com");
            EnviarEmail("El CV", cuerpo, toAddress);
        }

        private async void EnviarEmail(string subject, string body, List<string> gente)
        {
            var message = new EmailMessage
            {
                Subject = subject,
                Body = body,
                To = gente,
            };
            await Email.ComposeAsync(message);
        }
            
    }
}