using emailAppXamarin.Models;
using emailAppXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emailAppXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailsPage : ContentPage
    {
        

        public EmailsPage()
        {
            InitializeComponent();                                
        }

        //private void OnDelete(object sender, EventArgs e)
        //{
        //    SwipeItem item = sender as SwipeItem;
        //    MainModel model = item.BindingContext as MainModel;
        //    viewModel.Items.Remove(model);
        //}

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {

        }
    }
}