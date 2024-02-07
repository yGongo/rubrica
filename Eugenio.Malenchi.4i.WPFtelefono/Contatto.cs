using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eugenio.Malenchi._4i.WPFtelefono
{
    internal class Contatto
    {
        public string id;
        private string nome;
        private string cognome;

        public string Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }


        public Contatto(string riga)
        {

            string[] campi = riga.Split(';');

            if (int.TryParse(campi[0], out int res) && campi.Length == 3)
            {
                this.id = res.ToString();
                this.Nome = campi[1];
                this.Cognome = campi[2];
            }
            else
                this.id = "0";

        }

        public Contatto()
        {
        }
    }
}
