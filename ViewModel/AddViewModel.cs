using System.Windows;
using System.Windows.Input;
using WpfHomework1.Command;
using WpfHomework1.Model;

namespace WpfHomework1.ViewModel
{
    class AddViewModel
    {
        public Car CarExample { get; set; }
        public ICommand SaveCommand { get; set; }
        public AddViewModel()
        {
            SaveCommand = new RelayCommand(SaveCommandExecute);
        }
        public void SaveCommandExecute(object param)
        {
            MessageBox.Show("Saved");
        }
    }
}
