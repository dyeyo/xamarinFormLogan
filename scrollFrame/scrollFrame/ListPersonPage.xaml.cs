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
    public partial class ListPersonPage : ContentPage
    {
        PersonaServices personaServices;
        public ListPersonPage()
        {
            InitializeComponent();
        }

        public void poblarLista()
        {
            personaServices = new PersonaServices();
            //poblar
            list_persons.ItemsSource = personaServices.listPerson();
        }
    }
}