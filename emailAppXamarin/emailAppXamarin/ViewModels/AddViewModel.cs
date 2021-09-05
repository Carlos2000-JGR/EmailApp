using emailAppXamarin.Models;
using emailAppXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace emailAppXamarin.ViewModels
{
    public class AddViewModel : BaseViewModel
    {
        public ICommand AddEmailCommand { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string To { get; set; }
        public string Compose { get; set; }



        private ObservableCollection<Email> _referenceEmail;
        

        public AddViewModel(ObservableCollection<Email> emails)
        {
            _referenceEmail = emails;
            AddEmailCommand = new Command(Add);
        }

        private async void Add()
        {
            
            var newEmail = new Email(Title, Description, To, Compose);
            _referenceEmail.Add(newEmail);
            await App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
