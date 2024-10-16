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

namespace _6T24_ludo_WPFAct3BisEvant2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CalendarDateRange blackoutDays = new CalendarDateRange(new DateTime(0001,01,01), DateTime.Now.AddDays(-1)) ;
            arrivee.BlackoutDates.Add(blackoutDays);
            txtChiffre.PreviewTextInput += new TextCompositionEventHandler(Txt_Preview);
            duree.Click += new RoutedEventHandler(duree_Click);
            arrivee.SelectedDate = DateTime.Now;
        }
        
        private void A (object sender, DateTime e)
        {
            DateTime newDate;
            DatePicker datePickerObj = sender as DatePicker;

           
        }
        public void duree_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan semaines = sortie.SelectedDate.Value - arrivee.SelectedDate.Value;
            temps.Text = (semaines.Days / 7).ToString();
            

        }

        private bool EstEntier(string texteUser)
        {

            return int.TryParse(texteUser, out _);
        }
        

        private void Txt_Preview(object sender, TextCompositionEventArgs e)
        {

            if (!int.TryParse(e.Text, out int value))
            {
                e.Handled = true;
            }
            if (!int.TryParse(e.Text, out  value) || value < 0 || value > 6)
            {
                e.Handled = true;
            }
            else
            { 
                var textBox = sender as TextBox;
                if (textBox != null && textBox.Text.Length >= 1)
                {
                    e.Handled = true; 
                }
            }

        }

    }
}