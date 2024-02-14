using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Eugenio.Malenchi._4i.WPFtelefono
{
    public partial class MainWindow : Window
    {
        List<Persona> elencoPersone = new List<Persona>();
        public MainWindow()
        {
            InitializeComponent();

            List<Contatto> elencoContatti = new List<Contatto>();

            StreamReader lettorePersone = new StreamReader("Persone.csv");
            StreamReader lettoreContatti = new StreamReader("Contatti.csv");
            lettoreContatti.ReadLine();
            lettorePersone.ReadLine(); 
            while (!lettorePersone.EndOfStream)
            {
                string rigaPersone = lettorePersone.ReadLine();
                if (rigaPersone.Split(';').Length == 3)
                {
                    elencoContatti.Add(new Contatto(rigaPersone));
                }
            }
            while (!lettoreContatti.EndOfStream)
            {
                string rigaContatti = lettoreContatti.ReadLine();
                elencoPersone.Add(new Persona(Convert.ToInt32(rigaContatti.Split(';')[0]), Enum.Parse<Type>(rigaContatti.Split(';')[1]), rigaContatti.Split(';')[2]));
            }
            dg.ItemsSource = elencoContatti;
        }


        private void dg_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Contatto contatto = e.Row.Item as Contatto;
        }

        private void dg1_LoadingRow(object sender, SelectionChangedEventArgs e)
        {
            Contatto contattoSelezionato = e.AddedItems[0] as Contatto;
            List<Persona> elencoPersoneFiltrato = new List<Persona>();
            foreach (Persona persona in elencoPersone)
            {
                try
                {
                    if (persona.IdPersona == contattoSelezionato.N)
                    {
                        elencoPersoneFiltrato.Add(persona);
                    }
                }
                catch { }
            }
            dg1.ItemsSource = elencoPersoneFiltrato;
        }
    }
}
