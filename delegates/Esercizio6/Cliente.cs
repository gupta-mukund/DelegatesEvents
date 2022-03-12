using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio6
{
    class Cliente
    {
        public Cliente(string nome, string cognome, string indirizzo)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            Saldo = 0;
        }

        public string Nome { get; set; }
        public string Cognome{ get; set; }
        public string Indirizzo { get; set; }
        public double Saldo { get; set; }
        public event EventHandler Errore;

        public void Versamento(int somma)
        {
            Saldo += somma;
        }
        public void Prelevamento(int somma)
        {
            if (somma <= Saldo)
            {
                Saldo -= somma;
            } else
            {
                Errore?.Invoke(this, new ErrorMessage { Message = "Saldo insufficiente"});
            }
        }
        

    }    
}

