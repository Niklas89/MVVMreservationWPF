using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.ViewModels
{
    // an interface that the view in WPF automaticly hooks into and our ViewModel will be able to raise an event on this interface
    public class ViewModelBase : INotifyPropertyChanged
    {
        // tell the UI what bindings to update
        public event PropertyChangedEventHandler? PropertyChanged;

        // call this method to tell the UI when a property value has changed so that our views can regrab our property value and update the UI
        protected void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
