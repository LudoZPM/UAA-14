using System;
using System.Collections.Generic;
using System.Data;
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

namespace CE_UAA14WPF_Dec_Bechet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] btn = new Button[7,7];
        public MainWindow()
        {
            InitializeComponent();
            Ligne.PreviewTextInput += new TextCompositionEventHandler(Txt_Preview);
            Colonne.PreviewTextInput += new TextCompositionEventHandler(Txt_Preview);   
            Marelle();
            Solitaire();
           // Croix();


            
            



        }
        
       // private void Croix()//fonction pour faire le quadrillage de rectangle jaune avec une croix rouge 
        //{
            //for (int i = 0; i < btn.GetLength(0); i++)
            //{
               // for (int j = 0; j < btn.GetLength(1); j++)
               // {

                  //  Button btn1 = new Button();
                  //  btn1.Background = Brushes.Yellow;
                 //   btn1.Content = "X";
                  //  btn1.Foreground = Brushes.Red;
                 //   btn1.HorizontalAlignment = HorizontalAlignment.Stretch;
                 //   btn1.VerticalAlignment = VerticalAlignment.Stretch;
                 //   btn1.FontSize = 21;
                 //   btn1.FontWeight = FontWeights.Bold;
                   


                 //   Grid.SetRow(btn1, 2);
                 //   Grid.SetColumn(btn1, 3);
                 //   grdMain.Children.Add(btn1);

            

                 //   btn[i, j] = btn1;


                  
               // }
           // }
      //  }
        private void Solitaire()//fontion solitaire
        {
            for (int i = 0; i < btn.GetLength(0); i++)
            {
                for (int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();
                    BitmapImage imgR = new BitmapImage();
                    if (j == 0 || j == 5)
                    {
                        imgR.UriSource = new Uri("rouge.png", UriKind.Relative);
                    }
                }
            }
        }
        
        private void Marelle()//fonction Marelle pour afficher la partie Marelle
        {
            for(int i = 0; i < btn.GetLength(0); i++)//contruction de la matrice
            {
                for(int j = 0; j < btn.GetLength(1); j++)
                {
                    btn[i, j] = new Button();//Creation boutton
                    BitmapImage imgR = new BitmapImage();//creation image
                    btn[i, j].Height = 20;
                    if (j == 0 || j == 5)//condition if pour afficher une image
                    {
                        imgR.UriSource = new Uri("rouge.png", UriKind.Relative);//affiche l image rouge
                    }
                    if (i == 4 || j == 0)
                    {
                        imgR.UriSource = new Uri("rouge.png", UriKind.Relative);
                    }
                    if (i == 4 || j == 1)
                    {
                        imgR.UriSource = new Uri("rouge.png", UriKind.Relative);
                    }
                    if (i == 4 || j == 3)
                    {
                        imgR.UriSource = new Uri("rouge.png", UriKind.Relative);
                    }
                    if(i == 4 || j == 2)
                    {
                        imgR.UriSource = new Uri("rouge.png", UriKind.Relative);
                    }
                    if (i == 5 || j == 4)
                    {
                        imgR.UriSource = new Uri("blanc.png", UriKind.Relative);//affiche l image blanc
                    }
                }
            }
            //Grid.SetRow(btn[i, j], i);
            //Grid.SetColumn(btn[i, j], j);
            //grdMain.Children.Add(btn[i, j]);
            //btn[i, j].HorizontalAlignment = HorizontalAlignment.Center;
            //btn[i, j].VerticalAlignment = VerticalAlignment.Center;

        }
        public void onClick(object sender, RoutedEventArgs e)//fonction pour emplacer le texte en bas
        {
            ((Button)sender).Content = "Veuillez encodez des diemntion entre 1 et 12";
        }





        private void Txt_Preview(object sender, TextCompositionEventArgs e)//fontion pour limiter l ecriture des extbox
        {

            if (!int.TryParse(e.Text, out int value))
            {
                e.Handled = true;
            }
            if (!int.TryParse(e.Text, out value) || value < 0 || value > 9)//verifie l entré des chiffre min : 0 et max : 9
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
