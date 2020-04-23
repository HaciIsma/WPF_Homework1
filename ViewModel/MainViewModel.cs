using Microsoft.Win32;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
            new Car{Model="BMW",Vendor="X5",Photo=@"Resource/X5.png"},
        };

        private string saveButtonVisible = "Hidden";
        public string SaveButtonVisible
        {
            get
            {
                return saveButtonVisible;
            }
            set
            {
                saveButtonVisible = value;
                OnPropertyChanged();
            }
        }

        public int SelectedCarIndex { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand SaveCommand { get; set; }

        public MainViewModel()
        {
            AddCommand = new RelayCommand(AddCommandExecute);
            EditCommand = new RelayCommand(EditCommandExecute);
            SaveCommand = new RelayCommand(SaveCommandExecute);
            SaveButtonVisible = Cars.Count >= 10 ? "Visible" : "Hidden";
        }

        public void AddCommandExecute(object param)
        {
            AddCommandView addView = new AddCommandView(this);
            addView.ShowDialog();

            if (Cars.Count >= 10)
            {
                SaveButtonVisible = "Visible";
            }
        }
        public void EditCommandExecute(object param)
        {
            EditView editView = new EditView(this);
            editView.ShowDialog();
        }

        public void SaveCommandExecute(object param)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Json file (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(Cars));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
