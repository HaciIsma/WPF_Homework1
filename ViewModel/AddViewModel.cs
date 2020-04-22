using System.Windows.Input;
using WpfHomework1.Command;
using WpfHomework1.Model;

namespace WpfHomework1.ViewModel
{
    class AddViewModel
    {
        private readonly MainViewModel mainViewModel;

        public string CarModel  { get; set; }
        public string CarPhoto { get; set; } = string.Empty;
        public string CarVendor { get; set; }

        public ICommand SaveCommand { get; set; }

        public AddViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            SaveCommand = new RelayCommand(SaveCommandExecute);
        }

        public void SaveCommandExecute(object param)
        {
            Car car = new Car { Model = CarModel, Vendor = CarVendor, Photo = CarPhoto };
            mainViewModel.Cars.Add(car);
        }
    }
}
