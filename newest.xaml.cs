using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Xamarin.Forms;

namespace form_to_CV
{
    public partial class newest : ContentPage
    {
        public newest(string name, string email, string age, string address, string phone, string career, string educationLevel,string experiencia)
        {
            InitializeComponent();

            NameLabel.Text = $"Nombre: {name}";
            EmailLabel.Text = $"Correo Electrónico: {email}";
            AgeLabel.Text = $"Edad: {age}";
            AddressLabel.Text = $"Dirección: {address}";
            PhoneLabel.Text = $"Teléfono: {phone}";
            CareerLabel.Text = $"Carrera Profesional: {career}";
            educacion.Text = $"Nivel de Estudios: {educationLevel}";
            experiencias.Text = $"Experiencia laboral: {experiencia}";
        }
    }
}