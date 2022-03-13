using AppPhone.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppPhone.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}