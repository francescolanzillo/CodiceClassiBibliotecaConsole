﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBiblioteca
{
     class Libro
    {
        public string Titolo { get; set; }
        public string Autore { get; set; }
        public int Pagine { get; set; }

        public decimal Prezzo { get; set; }

        public int CodiceSegreto { get; }

        public Libro() 
        {
            //questo blocco di codice viene eseguito 
            //alla creazione (new) degli oggetti di questa classe
            CodiceSegreto = 321;
        }
        public decimal PrezzoInDollari()
        {
            decimal prezzoConvertito = Prezzo * 0.89M;
            return prezzoConvertito;
        }

    }
}
