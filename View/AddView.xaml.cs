using System.Windows;
using WpfHomework1.ViewModel;

namespace WpfHomework1.View
{
    public partial class AddCommandView : Window
    {
        public AddCommandView(MainViewModel mainViewModel)
        {
            InitializeComponent();
            DataContext = new AddViewModel(mainViewModel);
        }
    }
}
