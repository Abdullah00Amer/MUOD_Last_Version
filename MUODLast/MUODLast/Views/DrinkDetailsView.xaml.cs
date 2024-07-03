using MUODLast.Models;
using MUODLast.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MUODLast.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DrinkDetailsView : ContentPage
    {
        DrinkDetailsViewModel ddvm;
        public DrinkDetailsView(Drink drink)
        {
            ddvm = new DrinkDetailsViewModel(drink);
            this.BindingContext = ddvm;
            InitializeComponent();
        }

        
       
    }
}