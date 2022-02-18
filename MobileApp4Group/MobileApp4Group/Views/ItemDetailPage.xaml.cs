using MobileApp4Group.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MobileApp4Group.Views
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