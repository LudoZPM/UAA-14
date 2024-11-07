using System.Reflection.Metadata;
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
using _6T24_ludo_FrameEx1.page;

namespace _6T24_ludo_FrameEx1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Frame1();
        }
        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Frame2();
        }
    }
}