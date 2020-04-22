using System.Windows;
using WpfHomework1.ViewModel;

namespace WpfHomework1.View
{
    public partial class EditView : Window
    {
        public EditView(MainViewModel mainViewModel)
        {
            InitializeComponent();
            DataContext = new EditViewModel(mainViewModel);

            ResizeMode = ResizeMode.CanResize;
            ResizeMode = ResizeMode.NoResize;
        }
    }
}
