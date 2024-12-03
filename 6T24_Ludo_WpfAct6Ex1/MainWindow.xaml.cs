using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _6T24_Ludo_WpfAct6Ex1
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
        public void Grill ()
        {
            this.Width = 660;
            this.Height = 660;
            this.FontSize = 20;
            ColumnDefinition[] colDef = new ColumnDefinition[btn.GetLength(1)];
            RowDefinition[] rowDef = new RowDefinition[btn.GetLength(0)];

            for(int i = 0; i < btn.GetLength(1); i++)
            {
                colDef[i] = new ColumnDefinition();
            }
            for(int i = 0;i < btn.GetLength(1); i++)
            {
                grdMain.ColumnDefinitions.Add(colDef[i]);
            }
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                rowDef[i] = new RowDefinition();
            }
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                grdMain.RowDefinitions.Add(rowDef[i]);
            }
        }
        public void Damier()
        {
            int number = 1; 

            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    
                    Button btn1 = new Button();
                    btn1.Content = number.ToString(); 
                    btn1.Background = (i + j) % 2 == 0 ? Brushes.Black : Brushes.White; 
                    btn1.Foreground = Brushes.Red; 
                    btn1.HorizontalAlignment = HorizontalAlignment.Stretch;
                    btn1.VerticalAlignment = VerticalAlignment.Stretch;
                    btn1.FontSize = 20;
                    btn1.FontWeight = FontWeights.Bold;

                    
                    Grid.SetRow(btn1, i);
                    Grid.SetColumn(btn1, j);
                    grdMain.Children.Add(btn1);
                    

                    
                    btn[i, j] = btn1;

                    
                    number++;
                }
            }
        }



    }
}
