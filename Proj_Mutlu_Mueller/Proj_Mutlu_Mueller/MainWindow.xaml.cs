﻿using System;
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
            if(/*RadiobuttonDeutsch = Negativ */ && Noten.Jahrgang == 1)
            {
                Noten.D5er1 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && Noten.Jahrgang == 2)
            {
                Noten.D5er2 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && Noten.Jahrgang == 3)
            {
                Noten.D5er3 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && Noten.Jahrgang == 4)
            {
                Noten.D5er4 = true;
            }

            if (/*RadiobuttonDeutsch = Negativ */ && Noten.Jahrgang == 5)
            {
                Noten.D5er5 = true;
            }

            //Mathenoten abfragen
            if (/*RadiobuttonMathe = Negativ */ && Noten.Jahrgang == 1)
            {
                Noten.M5er1 = true;
            }

            if (/*RadiobuttonMathe = Negativ */ && Noten.Jahrgang == 2)
            {
                Noten.M5er2 = true;
            }

            if (/*RadiobuttonMathe = Negativ */ && Noten.Jahrgang == 3)
            {
                Noten.M5er3 = true;
            }

            if (/*RadiobuttonMathe = Negativ */ && Noten.Jahrgang == 4)
            {
                Noten.M5er4 = true;
            }

            if (/*RadiobuttonMathe = Negativ */ && Noten.Jahrgang == 5)
            {
                Noten.M5er5 = true;
            }

            //Englischnoten Abfragen
            if (/*RadiobuttonEnglisch = Negativ */ && Noten.Jahrgang == 1)
            {
                Noten.E5er1 = true;
            }

            if (/*RadiobuttonEnglisch = Negativ */ && Noten.Jahrgang == 2)
            {
                Noten.E5er2 = true;
            }

            if (/*RadiobuttonEnglisch = Negativ */ && Noten.Jahrgang == 3)
            {
                Noten.E5er3 = true;
            }

            if (/*RadiobuttonEnglisch = Negativ */ && Noten.Jahrgang == 4)
            {
                Noten.E5er4 = true;
            }

            if (/*RadiobuttonEnglisch = Negativ */ && Noten.Jahrgang == 5)
            {
                Noten.E5er5 = true;
            }


            //Überprüfen ob Schulabbruch
            if(Noten.Fail == true)
            {
                //Hier Visuelles Fail symbol einfügen
            }

            //Jahrgang2Pkt.Visibility = Visibility;
            //int counter = 0;

            //for (int i = 0; i < 6; i++)
            //{
            //    counter++;
            //}

            //if (counter == 1)
            //    Jahrgang1Pkt.Visibility == true;

            //(Noten.Jahrgang == 1)

        }

        private void BtnWiederholen_Click(object sender, RoutedEventArgs e)
        {
            Noten.Sitzenbleiben(); //wiederholungen +1

            //Überprüfen ob Schulabbruch
            if (Noten.Fail == true)
            {
                lblFail.Visible = "false";//Hier Visuelles Fail symbol einfügen
            }

        }

        private void BtnPrüfen_Click(object sender, RoutedEventArgs e)
        {
            int jahrgang = Noten.Jahrgang;
            Noten.Jahrgang = jahrgang--; //Peim Prüfungsknopf wird man in das vorherige Jahr gesetzt und aknn dann seine Korigierten Noten eintragen

            //AN ERAY: Punkt auf der Zeitlinie muss sich zurückbewegen (vieleicht andere Farbe als normal währ cool)
        }
    }
}
