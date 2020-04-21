using System.Windows;
using WpfHomework1.ViewModel;

namespace WpfHomework1.View
{
    public partial class AddCommandView : Window
    {
        public AddCommandView()
        {
            InitializeComponent();
            DataContext = new AddViewModel();
        }
    }
}
