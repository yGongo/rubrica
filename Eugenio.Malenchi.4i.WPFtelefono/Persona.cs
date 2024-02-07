using System;

namespace Eugenio.Malenchi._4i.WPFtelefono
{
    internal class Persona
    {
        public int idPersona { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public Persona() { }

        public Persona(string riga)
        {
            string[] campi = riga.Split(';');

            if (campi.Length >= 3)
            {
                if (int.TryParse(campi[0], out int id))
                {
                    idPersona = id;
                }
                Nome = campi[1];
                Cognome = campi[2];
            }
        }
    }
}
