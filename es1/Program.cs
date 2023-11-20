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
            private string nome;
            private double prezzo;
            public Prodotto()
            {
                nome = "Prodotto1";
                prezzo = 10.0;
            }

            public Prodotto(string nome, double prezzo)
            {
                this.nome = nome;
                this.prezzo = prezzo;
            }


            public string getNome()
            {
                return nome;
            }

            public double getPrezzo()
            {
                return prezzo;
            }
            static void Main(string[] args)
            {
                Prodotto prodotto1 = new Prodotto();
                Prodotto prodotto2 = new Prodotto("Prodotto2", 29.99);
                Console.WriteLine("Nome: " + prodotto1.getNome() + ", Prezzo: " + prodotto1.getPrezzo());
                Console.WriteLine("Nome: " + prodotto2.getNome() + ", Prezzo: " + prodotto2.getPrezzo());
                Console.Read(); 
            }
        }
    }
}