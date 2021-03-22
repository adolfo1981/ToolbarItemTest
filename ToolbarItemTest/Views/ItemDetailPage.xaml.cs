using System.ComponentModel;
using ToolbarItemTest.ViewModels;
using Xamarin.Forms;

namespace ToolbarItemTest.Views
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