using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace emailAppXamarin.ViewModels
{
    public abstract class BaseViewModel 
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}
