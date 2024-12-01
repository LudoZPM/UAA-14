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

namespace _6T24_Ludo_WpfAct4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ColumnDefinition col1 = new ColumnDefinition();
            ColumnDefinition col2 = new ColumnDefinition();
            ColumnDefinition col3 = new ColumnDefinition();
            RowDefinition row1 = new RowDefinition();
            RowDefinition row2 = new RowDefinition();
            RowDefinition row3 = new RowDefinition();
            grdMain.ColumnDefinitions.Add(col1);
            grdMain.ColumnDefinitions.Add(col2);
            grdMain.ColumnDefinitions.Add(col3);
            grdMain.RowDefinitions.Add(row1);
            grdMain.RowDefinitions.Add(row2);
            grdMain.RowDefinitions.Add(row3);
            

            TextBlock txtblock = new TextBlock();
            txtblock.Height = 50;
            txtblock.Width = 10000;
            txtblock.HorizontalAlignment = 0;
            txtblock.VerticalAlignment = VerticalAlignment.Center;
            txtblock.Text = "TextBlock créé dynamiquement";
            txtblock.Foreground = Brushes.Red;
            txtblock.Background = Brushes.Yellow;
            txtblock.FontSize = 25;
            txtblock.FontWeight = FontWeights.Bold;
            Grid.SetColumnSpan(txtblock, 3);
            Grid.SetRow(txtblock, 0);
            grdMain.Children.Add(txtblock);
            

            Button btn1 = new Button();
            Button btn2 = new Button();
            Button btn3 = new Button();

            btn1.Foreground = Brushes.Red;
            btn2.Foreground = Brushes.Red;
            btn3.Foreground = Brushes.Red;
            btn1.Background = Brushes.Yellow;
            btn2.Background = Brushes.Yellow;
            btn3.Background = Brushes.Yellow;
            btn1.Height = 100;
            btn2.Height = 100;
            btn3.Height = 100;
            btn1.Width = 140;
            btn2.Width = 140;
            btn3.Width = 140;
            btn1.VerticalAlignment = VerticalAlignment.Center;
            btn2.VerticalAlignment = VerticalAlignment.Center;
            btn3.VerticalAlignment = VerticalAlignment.Center;
            btn1.Content = "boutton 1";
            btn2.Content = "boutton 2";
            btn3.Content = "boutton 3";
            btn1.FontSize = 20;
            btn2.FontSize = 20;
            btn3.FontSize = 20;
            Grid.SetColumn(btn1, 0);
            Grid.SetColumn(btn2, 1);
            Grid.SetColumn(btn3, 2);
            Grid.SetRow(btn1, 1);
            Grid.SetRow(btn2, 1);
            Grid.SetRow(btn3, 1);
            grdMain.Children.Add(btn1);
            grdMain.Children.Add(btn2);
            grdMain.Children.Add(btn3);

            TextBlock txtblock2 = new TextBlock();
            txtblock2.Height = 50;
            txtblock2.Width = 10000;
            txtblock2.HorizontalAlignment = 0;
            txtblock2.VerticalAlignment = VerticalAlignment.Center;
            txtblock2.Text = "Infos :";
            txtblock2.Foreground = Brushes.Black;
            txtblock2.Background = Brushes.Yellow;
            txtblock2.FontSize = 18;
            txtblock2.FontWeight = FontWeights.Bold;

            TextBox txtbox = new TextBox();
            
            txtbox.Foreground = Brushes.Black;
            txtbox.Text = "J attends vos infos";
            StackPanel stack = new StackPanel();
            stack.Children.Add(txtblock2);
            stack.Children.Add(txtbox);
            Grid.SetRow(stack, 2);
            Grid.SetColumnSpan(stack, 2);
            grdMain.Children.Add(stack);

            ComboBox combo = new ComboBox();
            combo.FontSize = 20;
            combo.FontWeight = FontWeights.Bold;
            combo.Width = 100;
            combo.Height = 100;
            Grid.SetColumn(combo, 2);
            Grid.SetRow(combo, 2);
            grdMain.Children.Add(combo);
            


        }
    }
}
