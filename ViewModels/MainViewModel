using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using MVVMBeispiel.Models;

namespace MVVMBeispiel.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _eingabeText;

        public string EingabeText
        {
            get => _eingabeText;
            set
            {
                if(_eingabeText != value)
                {
                    _eingabeText = value;
                    OnPropertyChanged(nameof(EingabeText));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
