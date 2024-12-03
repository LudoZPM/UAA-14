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

namespace _6T24_ludo_WpfAct5Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
   
    public partial class MainWindow : Window
    {
        Button[,] btn = new Button[10,10];
        public MainWindow()
        {
            InitializeComponent();
            Grill();
            Damier();
        }
        public void Grill()
        {
            this.Width = 660;
            this.Height = 660;
            ColumnDefinition[] colDef = new ColumnDefinition[btn.GetLength(1)];
            RowDefinition[] rowDef = new RowDefinition[btn.GetLength(0)];

            for(int i = 0; i < btn.GetLength(0); i++)
            {
                colDef[i] = new ColumnDefinition();
            }
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                grdMain.ColumnDefinitions.Add(colDef[i]);
            }
            for(int j = 0; j < btn.GetLength(1); j++)
            {
                rowDef[j] = new RowDefinition();
            }
            for(int j = 0; j < btn.GetLength(0); j++)
            {
                grdMain.RowDefinitions.Add(rowDef[j]);
            }
        }
        public void  Damier()
        {
            int number = 1;
            for(int i = 0; i < btn.GetLength(0); i++)
            {
                for(int j = 0; j < btn.GetLength(1); j++)
                {
                    int columnIndex = (i % 2 == 0) ? j : (btn.GetLength(1) - 1 - j);

                    
                    Button btn1 = new Button();
                    btn1.Content = number.ToString(); 
                    btn1.Background = (i + columnIndex) % 2 == 0 ? Brushes.Black : Brushes.White;
                    btn1.VerticalAlignment = VerticalAlignment.Stretch;
                    btn1.HorizontalAlignment = HorizontalAlignment.Stretch;
                    btn1.Foreground = Brushes.Red; 
                    btn1.FontSize = 21;
                    btn1.FontWeight = FontWeights.Bold;
                    btn1.Click += onClick;

                   
                    Grid.SetColumn(btn1, columnIndex);
                    Grid.SetRow(btn1, i);
                    grdMain.Children.Add(btn1);

                    
                    btn[i, columnIndex] = btn1;

                    
                    number++;
                }
            }
        }
        public void onClick(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "";
        }
    }
}