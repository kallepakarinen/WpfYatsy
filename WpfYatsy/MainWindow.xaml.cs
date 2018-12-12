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

namespace WpfYatsy
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
        int counter = 0;
        private void Throw_Click(object sender, RoutedEventArgs e)
        {           
            Random rnd = new Random();
            counter = counter + 1;
            //
           // peli loppuu, nollataan ja piilotetaan checkboxit.
            if (counter == 3)
            {
                counter = 0;
                Tulos.Visibility = Visibility;
                Throw.Content = "Uusi peli";
                cBox1.IsChecked = false;
                cBox2.IsChecked = false;
                cBox3.IsChecked = false;
                cBox4.IsChecked = false;
                cBox5.IsChecked = false;
                cBox1.Visibility = Visibility.Hidden;
                cBox2.Visibility = Visibility.Hidden;
                cBox3.Visibility = Visibility.Hidden;
                cBox4.Visibility = Visibility.Hidden;
                cBox5.Visibility = Visibility.Hidden;                              
            }
            else
            
                // Tulos on huono nimi labelin nimi!!
                Tulos.Visibility = Visibility.Hidden;
                cBox1.Visibility = Visibility.Visible;
                cBox2.Visibility = Visibility.Visible;
                cBox3.Visibility = Visibility.Visible;
                cBox4.Visibility = Visibility.Visible;
                cBox5.Visibility = Visibility.Visible;
                Throw.Content = "Heitä";

                // Checkboxin liitetyt nappulat vaihtuu, jos ei ole checkbox valittu.
                // Dice = nappulan teksti.
                if (cBox1.IsChecked != true)
                {
                    Dice1.Content = rnd.Next(1, 7);
                }
                if (cBox2.IsChecked != true)
                {
                    Dice2.Content = rnd.Next(1, 7);
                }
                if (cBox3.IsChecked != true)
                {
                    Dice3.Content = rnd.Next(1, 7);
                }
                if (cBox4.IsChecked != true)
                {
                    Dice4.Content = rnd.Next(1, 7);
                }
                if (cBox5.IsChecked != true)
                {
                    Dice5.Content = rnd.Next(1, 7);
                }
            }
        }
    }

