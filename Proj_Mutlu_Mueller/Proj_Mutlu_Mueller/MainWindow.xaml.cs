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

            Noten.Aufsteigen(); //Jahrgang + 1

            //Deutschnoten abfragen
            if(DeutschRbNegativ.IsChecked==true && Noten.Jahrgang == 1)
            {
                Noten.D5er1 = true;
            }

            if (DeutschRbNegativ.IsChecked == true && Noten.Jahrgang == 2)
            {
                Noten.D5er2 = true;
            }

            if (DeutschRbNegativ.IsChecked == true && Noten.Jahrgang == 3)
            {
                Noten.D5er3 = true;
            }

            if (DeutschRbNegativ.IsChecked == true && Noten.Jahrgang == 4)
            {
                Noten.D5er4 = true;
            }

            if (DeutschRbNegativ.IsChecked == true && Noten.Jahrgang == 5)
            {
                Noten.D5er5 = true;
            }

            //Mathenoten abfragen
            if (MatheRbNegativ.IsChecked==true && Noten.Jahrgang == 1)
            {
                Noten.M5er1 = true;
            }

            if (MatheRbNegativ.IsChecked == true && Noten.Jahrgang == 2)
            {
                Noten.M5er2 = true;
            }

            if (MatheRbNegativ.IsChecked == true && Noten.Jahrgang == 3)
            {
                Noten.M5er3 = true;
            }

            if (MatheRbNegativ.IsChecked == true && Noten.Jahrgang == 4)
            {
                Noten.M5er4 = true;
            }

            if (MatheRbNegativ.IsChecked == true && Noten.Jahrgang == 5)
            {
                Noten.M5er5 = true;
            }

            //Englischnoten Abfragen
            if (EnglishRbNegativ.IsChecked == true && Noten.Jahrgang == 1)
            {
                Noten.E5er1 = true;
            }

            if (EnglishRbNegativ.IsChecked == true && Noten.Jahrgang == 2)
            {
                Noten.E5er2 = true;
            }

            if (EnglishRbNegativ.IsChecked == true && Noten.Jahrgang == 3)
            {
                Noten.E5er3 = true;
            }

            if (EnglishRbNegativ.IsChecked == true && Noten.Jahrgang == 4)
            {
                Noten.E5er4 = true;
            }

            if (EnglishRbNegativ.IsChecked == true && Noten.Jahrgang == 5)
            {
                Noten.E5er5 = true;
            }


            //Überprüfen ob Schulabbruch

            Label lblfail = new Label();
            lblfail.Content = "FAIL";
            lblfail.FontSize = 200;
            lblfail.Foreground = Brushes.Red;

            if (Noten.Fail == true)
            {
                Canvas.SetLeft(lblfail, 200); //Hier Visuelles Fail symbol einfügen
                Simulator.Children.Add(lblfail);
            }

            Ellipse JahrgangsPUNKT = new Ellipse();
            JahrgangsPUNKT.Width = 10;
            JahrgangsPUNKT.Height = 10;
            JahrgangsPUNKT.Fill = Brushes.Black;
            Canvas.SetLeft(JahrgangsPUNKT, 245);
            Canvas.SetTop(JahrgangsPUNKT, 95);
            Simulator.Children.Add(JahrgangsPUNKT);

            if (Noten.Jahrgang == 1)
                Canvas.SetLeft(JahrgangsPUNKT, 245);
            else if (Noten.Jahrgang == 2)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 50);
            else if (Noten.Jahrgang == 3)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 100);
            else if (Noten.Jahrgang == 4)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 150);
            else if (Noten.Jahrgang == 5)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 200);


        }

        private void BtnWiederholen_Click(object sender, RoutedEventArgs e)
        {
            Noten.Sitzenbleiben(); //wiederholungen +1

            Label lblfail = new Label();
            lblfail.Content = "FAIL";
            lblfail.FontSize = 200;
            lblfail.Foreground = Brushes.Red;

            //Überprüfen ob Schulabbruch
            if (Noten.Fail == true)
            {
                Canvas.SetLeft(lblfail, 200); //Hier Visuelles Fail symbol einfügen
                Simulator.Children.Add(lblfail);
            }

        }

        private void BtnPrüfen_Click(object sender, RoutedEventArgs e)
        {
            int jahrgang = Noten.Jahrgang;
            Noten.Jahrgang = jahrgang--; //Peim Prüfungsknopf wird man in das vorherige Jahr gesetzt und aknn dann seine Korigierten Noten eintragen

            //AN ERAY: Punkt auf der Zeitlinie muss sich zurückbewegen (vieleicht andere Farbe als normal währ cool)

            Ellipse JahrgangsPUNKT = new Ellipse();
            JahrgangsPUNKT.Width = 10;
            JahrgangsPUNKT.Height = 10;
            JahrgangsPUNKT.Fill = Brushes.Blue;
            Canvas.SetLeft(JahrgangsPUNKT, 245);
            Canvas.SetTop(JahrgangsPUNKT, 95);
            Simulator.Children.Add(JahrgangsPUNKT);

            if (Noten.Jahrgang == 1)
                Canvas.SetLeft(JahrgangsPUNKT, 245);
            else if (Noten.Jahrgang == 2)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 50);
            else if (Noten.Jahrgang == 3)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 100);
            else if (Noten.Jahrgang == 4)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 150);
            else if (Noten.Jahrgang == 5)
                Canvas.SetLeft(JahrgangsPUNKT, 245 + 200);
        }
    }
}
