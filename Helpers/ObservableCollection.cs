using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WpfObservableCollectionBeispiel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<string> _namen;
        public ObservableCollection<string> Namen
        {
            get { return _namen; }
            set
            {
                _namen = value;
                OnPropertyChanged("Namen");
            }
        }

        public MainViewModel()
        {
            Namen = new ObservableCollection<string>
            {
                "Anna",
                "Bernd",
                "Clara"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
