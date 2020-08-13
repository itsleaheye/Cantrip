using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cantrip.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterCreatePage3 : ContentPage
    {
        public CharacterCreatePage3()
        {
            this.Title = "Skills & Proficiency";
            InitializeComponent();
        }
    }
}