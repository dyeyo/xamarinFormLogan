using scrollFrame.Models;
using scrollFrame.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scrollFrame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormularioPage : ContentPage
    {
        PersonaServices personaServices;
        PersonaModel personaModel;

        public FormularioPage()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            personaServices = new PersonaServices();
            personaModel = new PersonaModel();
            personaModel.nombre = nombre.Text.Trim();
            personaModel.numIdentificacion = identificacion.Text.Trim();
            personaModel.tipoIdentificacion = tipoIdentificacion.SelectedItem.ToString();
            personaModel.telefono = telefono.Text.Trim();
            personaModel.terminos = chkTerminosyCondiciones.IsChecked;
            //guardar
            personaServices.createPerson(personaModel);
            DisplayAlert("Persona", "Persona guardada con exito", "ok");
            nombre.Text = string.Empty;
            identificacion.Text = string.Empty;
            telefono.Text = string.Empty;
            chkTerminosyCondiciones.IsChecked = false;
        }
    }
}