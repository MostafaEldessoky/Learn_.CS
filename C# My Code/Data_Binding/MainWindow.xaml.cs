using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Data_Binding_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person("mostafa",29);

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void ClickMe(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(person.messege());
        }
    }
}