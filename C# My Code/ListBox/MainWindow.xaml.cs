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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static People People1 = new People("mostafa",29);
        public static People People2 = new People("mohamed", 25);
        public static People People3 = new People("Eldesouky", 62);
        public static People People4 = new People("eman", 49);

        public List<People> people = new List<People>() { People1, People2, People3, People4 };
        public MainWindow()
        {
            InitializeComponent();
            ListBoxPeople.ItemsSource = people;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((People)ListBoxPeople.SelectedItem).GetInfo());
        }
    }
}