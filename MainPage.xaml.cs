using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace form_to_CV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            string nombre = NameEntry.Text;
            string correo = EmailEntry.Text;
            string edad = AgeEntry.Text;
            string direccion = AddressEntry.Text;
            string telefono = PhoneEntry.Text;
            string carrera = CareerEntry.Text;
            string educacion = EducationLevelPicker.SelectedItem?.ToString();
            string experiencias = experiencia.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombre)||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(edad) ||
                string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(carrera) || string.IsNullOrWhiteSpace(educacion) ||
                string.IsNullOrWhiteSpace(experiencias))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
                return;
            }

            await Navigation.PushAsync(new newest(nombre, correo, edad, direccion, telefono, carrera, educacion, experiencias));
        }
    }
}
