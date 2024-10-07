using System;

namespace ProjTelevisore
{
    public class Televisore
    {
        public string Marca;
        public string Modello;
        public int Consumo;
        public int Dimensione;
        public bool Stato;
        public int CanaleCorrente;
        public int VolumeCorrente;

        public Televisore(string marca, string modello, int consumo, int dimensione)
        {
            Marca = marca;
            Modello = modello;
            Consumo = consumo;
            Dimensione = dimensione;
  
            CanaleCorrente = 0;
            VolumeCorrente = 50;
            Stato = false;
            
        }

        public void Accendi()
        {
            Stato = true;

            Console.WriteLine("Il televisore e' acceso.");
        }

        public void Spegni()
        {
            Stato = false;
            Console.WriteLine("Il televisore è spento.");
        }

        public void CambiaCanale(int nuovoCanale)
        {
            if (Stato)
            {
                CanaleCorrente = nuovoCanale;
                Console.WriteLine("Canale cambiato a " + CanaleCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }

        public void AumentaDiminuisciCanale(int incremento)
        {
            if (Stato)
            {
                CanaleCorrente += incremento;
                Console.WriteLine("Canale cambiato a " + CanaleCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }

        public void AlzaAbbassaVolume(int incremento)
        {
            if (Stato)
            {
                VolumeCorrente += incremento;
                Console.WriteLine("Volume cambiato a " + VolumeCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }

        public void CambiaVolume(int nuovoVolume)
        {
            if (Stato)
            {
                VolumeCorrente = nuovoVolume;
                Console.WriteLine("Volume cambiato a " + VolumeCorrente + ".");
            }
            else
            {
                Console.WriteLine("Il televisore è spento.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Televisore s1 = new Televisore("Marca1", "Modello1", 120, 390);
            Televisore s2 = new Televisore("Marca2", "Modello2", 130, 600);

            s1.Accendi();
            s1.CambiaCanale(2);
            s1.CambiaVolume(3);

            s2.Accendi();
            s2.CambiaCanale(5);
            s2.CambiaVolume(55);

            Console.WriteLine("Televisore s1: Canale " + s1.CanaleCorrente + ", Volume " + s1.VolumeCorrente);
            Console.WriteLine("Televisore s2: Canale " + s2.CanaleCorrente + ", Volume " + s2.VolumeCorrente);

            Console.ReadLine();
        }
    }
}