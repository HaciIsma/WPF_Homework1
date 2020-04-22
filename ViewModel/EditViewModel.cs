using System.Windows.Input;
using WpfHomework1.Command;

namespace WpfHomework1.ViewModel
{
    public class EditViewModel
    {
        private readonly MainViewModel mainViewModel;

        public string CarModel  { get; set; }
        public string CarPhoto  { get; set; }
        public string CarVendor { get; set; }

        public ICommand EditCommand { get; set; }

        public EditViewModel(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
            EditCommand = new RelayCommand(EditCommandExecute);
            var Selected = this.mainViewModel.Cars[this.mainViewModel.SelectedCarIndex];
            CarModel = Selected.Model;
            CarVendor = Selected.Vendor;
            CarPhoto = Selected.Photo;
        }

        private void EditCommandExecute(object param)
        {
            mainViewModel.Cars[mainViewModel.SelectedCarIndex] = new Model.Car
            {
                Model = CarModel,
                Vendor = CarVendor,
                Photo = CarPhoto
            };
        }
    }
}
