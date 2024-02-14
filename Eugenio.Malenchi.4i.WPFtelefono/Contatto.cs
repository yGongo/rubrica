﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eugenio.Malenchi._4i.WPFtelefono
{
    internal class Contatto
    {
        private int n;
        private string nome;
        private string cognome;

        public Contatto(string s)
        {
            string[] s1 = s.Split(';');
            n = Convert.ToInt32(s1[0]);
            nome = s1[1];
            cognome = s1[2];
        }

        public Contatto(int n)
        {
            this.n = n;
        }

        public Contatto(int n, string nome, string cognome)
        {
            this.n = n;
            this.nome = nome;
            this.cognome = cognome;
        }

        public int N { get => n; set => n = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }



    }
}
