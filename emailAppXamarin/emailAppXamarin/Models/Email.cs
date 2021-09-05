using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace emailAppXamarin.Models
{
    public class Email :INotifyPropertyChanged
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public string Compose { get; set; }

        public string To { get; set; }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        public Email(string title, string description, string to, string body)
        {
            Title = title;
            Description = description;
            To = to;
            Compose = body;

            Date = DateTime.Now;
           
        }

    }
}