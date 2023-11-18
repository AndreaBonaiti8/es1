using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es1
{
    internal class Program
    {
        public class Prodotto
        {
            private String nome;
            private double prezzo;
            public Prodotto()
            {
                this.nome = "";
                this.prezzo = 0.0;
            }

            public Prodotto(String nome, double prezzo)
            {
                this.nome = nome;
                this.prezzo = prezzo;
            }


            public String getNome()
            {
                return nome;
            }

            public double getPrezzo()
            {
                return prezzo;
            }
            static void Main(string[] args)
            {
                Prodotto prodotto1 = new Prodotto("Prodotto1", 19.99);
                Prodotto prodotto2 = new Prodotto("Prodotto2", 29.99);
                Console.WriteLine("Prodotto 1: " + prodotto1.getNome() + ", Prezzo: " + prodotto1.getPrezzo());
                Console.WriteLine("Prodotto 2: " + prodotto2.getNome() + ", Prezzo: " + prodotto2.getPrezzo());
                Console.Read(); 
            }
        }
    }
}