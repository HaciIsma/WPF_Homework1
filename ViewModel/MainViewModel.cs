using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfHomework1.Command;
using WpfHomework1.Model;
using WpfHomework1.View;

namespace WpfHomework1.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>
        {
            new Car{Model="BMW",Vendor="X5",Photo="X5.png"}
        };

        public ICommand AddCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new RelayCommand(AddCommandExecute);
        }

        public void AddCommandExecute(object param)
        {
            AddCommandView addView = new AddCommandView(this);
            addView.Show();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
