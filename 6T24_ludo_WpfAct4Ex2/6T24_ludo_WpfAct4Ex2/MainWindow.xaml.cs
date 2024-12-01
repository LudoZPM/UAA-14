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

namespace _6T24_ludo_WpfAct4Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock[,] txt = new TextBlock[4, 4]; 
        public MainWindow()
        {
            InitializeComponent();

            
            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            ColumnDefinition col3 = new ColumnDefinition();
            ColumnDefinition col4 = new ColumnDefinition();
            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            RowDefinition row4 = new RowDefinition();
            grdMain.ColumnDefinitions.Add(col1);
            grdMain.ColumnDefinitions.Add(col2);
            grdMain.ColumnDefinitions.Add(col3);
            grdMain.ColumnDefinitions.Add(col4);
            grdMain.RowDefinitions.Add(row1);
            grdMain.RowDefinitions.Add(row2);
            grdMain.RowDefinitions.Add(row3);
            grdMain.RowDefinitions.Add(row4);

            

            

            for (int i = 0; i < txt.GetLength(0); i++)
            {
                for(int j = 0; j < txt.GetLength(1); j++)
                {
                    
                    txt[i, j] = new TextBlock();
                    txt[i, j].Text = "?";
                    txt[i, j].Width = 50;
                    txt[i, j].Height = 50;
                    txt[i, j].FontSize = 20;
                    txt[i, j].FontWeight = FontWeights.Bold;
                    txt[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    txt[i, j].VerticalAlignment = VerticalAlignment.Center;
                    Grid.SetColumn(txt[i, j],i);
                    Grid.SetRow(txt[i, j],j);
                    grdMain.Children.Add(txt[i, j]);
                    txt[i, j].MouseDown += new MouseButtonEventHandler(point);
                }
                
            }

        }
        
        private void point(object sender, MouseButtonEventArgs e)
        {
            ((TextBlock)sender).Text = "X";
        }
    }
}
