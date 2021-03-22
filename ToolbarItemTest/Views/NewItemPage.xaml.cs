using System;
using System.Collections.Generic;
using System.ComponentModel;
using ToolbarItemTest.Models;
using ToolbarItemTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolbarItemTest.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}