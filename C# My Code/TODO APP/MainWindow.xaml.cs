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

namespace Demo_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
       private void ClickMe(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(intext.Text))
            {
                i++;
                TextBlock textBlock = new TextBlock();
                textBlock.Text = $"{i}-" + intext.Text;
                outtext.Children.Add(textBlock);
            }
            intext.Clear();
        }
    }
}