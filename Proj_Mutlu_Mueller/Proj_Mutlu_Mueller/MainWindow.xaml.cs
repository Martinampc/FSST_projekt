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
using Proj_Mutlu_Mueller;

namespace Proj_Mutlu_Mueller
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Noten Noten = new Noten();
        
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BtnAufstieg_Click(object sender, RoutedEventArgs e)
        {

            int jahrgang = Noten.Jahrgang; //derzeitigen Jahrgang auslesen
            Noten.Jahrgang = jahrgang++; //Jahrgang aufsteigen

            if(/*RadiobuttonDeutsch = Negativ */ && jahrgang == 1)
            {
                Noten.D5er1 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && jahrgang == 2)
            {
                Noten.D5er2 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && jahrgang == 3)
            {
                Noten.D5er3 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && jahrgang == 4)
            {
                Noten.D5er4 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && jahrgang == 5)
            {
                Noten.D5er5 = true;
            }

        }
    }
}
