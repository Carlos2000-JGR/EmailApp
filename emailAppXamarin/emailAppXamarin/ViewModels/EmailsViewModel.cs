using emailAppXamarin.Models;
using emailAppXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace emailAppXamarin.ViewModels
{
    public class EmailsViewModel 
    {
        public ObservableCollection<Email> Emails { get; set; } = new ObservableCollection<Email>();


        private Email _selectedEmail;


        public ICommand DeleteCommand { get; set; }
        public ICommand SelectedEmailCommand { get; set; }
        public ICommand NavigateCommand { get; }

        public EmailsViewModel()
        {
            SelectedEmailCommand = new Command<Email>(EmailsSelected);

            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new AddEmailPage(Emails)));
            });

            DeleteCommand = new Command<Email>(Delete);
        }

       

        private async void EmailsSelected(Email email)
        {
            await App.Current.MainPage.Navigation.PushAsync(new EmailsPage());
        }

        private void Delete(Email email)
        {
            Emails.Remove(email);

        }

        public Email SelectedEmail
        {
            get
            {
                return _selectedEmail;
            }
            set
            {
                _selectedEmail = value;

                if (_selectedEmail != null)
                {
                    SelectedEmailCommand.Execute(_selectedEmail);
                    SelectedEmail = null;
                }
            }
        }

        


    }
}
