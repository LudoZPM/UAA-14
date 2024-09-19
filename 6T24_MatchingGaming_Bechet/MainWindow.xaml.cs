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
using System.Windows.Threading;

namespace _6T24_MatchingGaming_Bechet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        int tempsEcoule = 0;
        int nbPairesTrouves = 0;
        
        public MainWindow()
        {
            timer.Interval = TimeSpan.FromSeconds(.1);
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            
        }
        private void SetUpGame()
        {
            int index;
            string nextEmoji;
            Random nbAlea = new Random();

            List<string> animalEmoji = new List<string>
            {
                "🐈","🐈",
                "🐷","🐷",
                "🐐","🐐",
                "🦊","🦊",
                "🐴","🐴",
                "🦨","🦨",
                "🦉","🦉",
                "🐀","🐀",
            };
            foreach (TextBlock textBlock in grdMain.Children.OfType<TextBlock>())
            {
                if (textBlock.Name != "txtTemps")
                {
                    index = nbAlea.Next(animalEmoji.Count);
                    nextEmoji = animalEmoji[index];
                    textBlock.Text = nextEmoji;
                    animalEmoji.RemoveAt(index);
                }
                

            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tempsEcoule = 0;
            nbPairesTrouves = 0;
            timer.Start();

            tempsEcoule++;
            txtTemps.Text = (tempsEcoule / 10F).ToString("0.0s");
            if (nbPairesTrouves == 8)
            {
                timer.Stop();
                txtTemps.Text = txtTemps.Text + " - Rejouer ma bichette ?";
            }


        }
        private void txtTemps_MouseDown(object sender, MouseEventArgs e)
        {
            if (nbPairesTrouves == 8)
            {
                SetUpGame();
                nbPairesTrouves = 0;
                tempsEcoule = 0;
                timer.Start();
            }
        }

        TextBlock derniereTBClique;
        bool trouvePaire = false;
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlockActif = sender as TextBlock;
            if (!trouvePaire)
            {
                textBlockActif.Visibility = Visibility.Hidden;
                derniereTBClique = textBlockActif;
                trouvePaire = true;
            }
            else if (textBlockActif.Text == derniereTBClique.Text)
            {
                nbPairesTrouves++;
                textBlockActif.Visibility = Visibility.Hidden;
                trouvePaire = false;
            }
            else
            {
                derniereTBClique.Visibility = Visibility.Visible;
                trouvePaire = false;
            }
        }

    }
}