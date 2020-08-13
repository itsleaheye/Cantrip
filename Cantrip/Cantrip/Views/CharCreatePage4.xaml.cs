using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharCreatePage4 : ContentPage
    {
        public CharCreatePage4()
        {
            this.Title = "Final Touches";
            InitializeComponent();
        }
        private async void Button_Finish(object sender, EventArgs e)
        {
            //Insert character into db
            await Navigation.PushAsync(new MyCharactersPage()); //Navigate to character list view 
        }
    }
}