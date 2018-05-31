using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialListView.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TutorialListView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewPlantilla : ContentPage
	{
        public List<Coche> Coches { get; set; }

        public ListViewPlantilla()
        {
            InitializeComponent();
            this.Coches = new List<Coche>();
            Coche coche = new Coche()
            {
                Nombre = "Ferrari FXX",
                Imagen = "https://icdn-4.motor1.com/images/mgl/KKMyA/s3/ferrari-fxx-k-evo-street-legal-concept.jpg"
            };
            this.Coches.Add(coche);
            coche = new Coche()
            {
                Nombre = "Opel Zafira",
                Imagen = "https://upload.wikimedia.org/wikipedia/commons/7/7f/Opel_Zafira_A_Facelift_front_20091022.jpg"
            };
            this.Coches.Add(coche);
            coche = new Coche()
            {
                Nombre = "Peugeot 208",
                Imagen = "http://media.peugeot.es/image/41/5/peugeot_208gti_1502pc002.22415.17.jpg"
            };
            this.Coches.Add(coche);
            this.lsvcoches.ItemsSource = this.Coches;
        }
	}
}