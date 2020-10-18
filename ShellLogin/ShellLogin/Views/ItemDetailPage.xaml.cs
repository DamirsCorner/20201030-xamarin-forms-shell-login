using System.ComponentModel;
using Xamarin.Forms;
using ShellLogin.ViewModels;

namespace ShellLogin.Views
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