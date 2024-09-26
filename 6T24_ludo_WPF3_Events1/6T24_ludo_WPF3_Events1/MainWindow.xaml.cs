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

namespace _6T24_ludo_WPF3_Events1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Methodes Methodes = new Methodes();

        public MainWindow()
        {
            InitializeComponent();
            BtnV.Visibility = Visibility.Hidden;
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBouton);
            BtnCalculer.MouseLeave += new MouseEventHandler(QuitterBouton);
            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);


            TxtA.PreviewTextInput += new TextCompositionEventHandler(Txt_Preview);
            TxtB.PreviewTextInput += new TextCompositionEventHandler(Txt_Preview);
            TxtC.PreviewTextInput += new TextCompositionEventHandler(Txt_Preview);
        }

        private bool EstEntier(string texteUser)
        {
            
            return int.TryParse(texteUser, out _);
        }

        private void Txt_Preview(object sender, TextCompositionEventArgs e)
        {
            
            if (e.Text != "," && !EstEntier(e.Text))
            {
                e.Handled = true;  
            }

            
            if (e.Text == "," && ((TextBox)sender).Text.IndexOf(",") > -1)
            {
                e.Handled = true;  
            }
        }
        private void SurvolBouton(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Visible;  
            BtnV.Background = Brushes.Red;         
        }

        
        private void QuitterBouton(object sender, MouseEventArgs e)
        {
            BtnV.Visibility = Visibility.Hidden;   
        }

        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double c;
            double b;
            string reponse;
            double.TryParse(TxtA.Text, out a);
            double.TryParse(TxtB.Text, out b);
            double.TryParse(TxtC.Text, out c);
            Methodes.ResoudTrinome(a, b, c, out reponse);
            SecondePage.LblResultat.Text = reponse;
            SecondePage.Show();


        }

    }
}

