using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Eugenio.Malenchi._4i.WPFtelefono
{
    public partial class MainWindow : Window
    {
        private List<Persona> Persone;
        private List<Contatto> Contatti;

        public MainWindow()
        {
            InitializeComponent();
            Persone = new List<Persona>();
            Contatti = new List<Contatto>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // Caricamento Persone
                using (StreamReader fin = new StreamReader("Persone.csv"))
                {
                    fin.ReadLine(); // Salta l'intestazione
                    while (!fin.EndOfStream)
                    {
                        string riga = fin.ReadLine();
                        Persone.Add(new Persona(riga));
                    }
                }
                dgPersone.ItemsSource = Persone;

                // Caricamento Contatti
                using (StreamReader fin = new StreamReader("Contatti.csv"))
                {
                    fin.ReadLine(); // Salta l'intestazione
                    while (!fin.EndOfStream)
                    {
                        string riga = fin.ReadLine();
                        Contatti.Add(new Contatto(riga));
                    }
                }
                dgContatti.ItemsSource = Contatti;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void dgPersone_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Persona c = e.Row.Item as Persona;
        }

        private void dgContatti_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Contatto c = e.Row.Item as Contatto;
        }
    }
}
