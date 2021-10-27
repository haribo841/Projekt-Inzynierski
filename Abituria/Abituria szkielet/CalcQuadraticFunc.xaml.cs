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
using System.Windows.Shapes;

namespace Abituria
{
    /// <summary>
    /// Interaction logic for CalcQuadraticFunc.xaml
    /// </summary>
    public partial class CalcQuadraticFunc : Window
    {
        public CalcQuadraticFunc()
        {
            InitializeComponent();
        }

        private void Przelicz(object sender, RoutedEventArgs e)
        {
            //zastąpić to casem po postawieniu też iloczynej i kanocznicznej, mlem
            //i oczywiście trzeba dodać weryfikację
            if (this.pOgolna.Visibility == Visibility.Visible)
            {
                double a = double.Parse(fieldA.Text);
                double b = double.Parse(fieldB.Text);
                double c = double.Parse(fieldC.Text);
                FunKwadratOgolna(a, b, c);
            }
            else 
            {
                MessageBox.Show("wiadomość testowa Ten warunek nie działa byku");
            }
            
        }

        private void Reset(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sashku mlemaj gdzie indziej");
        }

        private void ButtonOgolna(object sender, RoutedEventArgs e)
        {
            if (this.pOgolna.Visibility == Visibility.Collapsed && this.buttonPrzelicz.Visibility == Visibility.Collapsed && this.buttonReset.Visibility == Visibility.Collapsed)
            {
                this.pOgolna.Visibility = Visibility.Visible;
                this.buttonPrzelicz.Visibility = Visibility.Visible;
                this.buttonReset.Visibility = Visibility.Visible;
            }
            else
            {
                this.pOgolna.Visibility = Visibility.Collapsed;
                this.buttonPrzelicz.Visibility = Visibility.Collapsed;
                this.buttonReset.Visibility = Visibility.Collapsed;
                this.resultHead.Visibility = Visibility.Collapsed;
                this.result.Visibility = Visibility.Collapsed;
            }
        }

        private void ButtonIloczynowa(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }
        private void ButtonKanoniczna(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
        }

        private void FunKwadratOgolna(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double x0 = (-b) / (2 * a);
            double x1 = Math.Round(((-b) - Math.Sqrt(delta)) / (2 * a), 2);
            double x2 = Math.Round(((-b) + Math.Sqrt(delta)) / (2 * a), 2);


            if (delta < 0)
            {
                string resultTxt = "Δ < 0, funkcja nie posiada miejsc zerowych";
                result.Text = resultTxt;
            }
            else if (delta == 0)
            {
                string resultTxt = "Δ = 0, funkcja posiada jedno miejsce zerowe, gdzie wierzchołek dotyka osi x";
                result.Text = resultTxt;
            }
            else
            {
                string resultTxt = $"Δ > 0, funkcja posiada dwa miejsca zerowe: x1 = {x1} i x2 = {x2}";
                result.Text = resultTxt;
            }

            this.resultHead.Visibility = Visibility.Visible;
            this.result.Visibility = Visibility.Visible;
            

        }

    }
}

