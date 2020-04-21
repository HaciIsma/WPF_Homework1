using System.Windows;
using WpfHomework1.ViewModel;

namespace WpfHomework1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}
