using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        private int kontonummer;
        private static int lastKontonummer;

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public int KontoNr
        {
            get
            {
                return kontonummer;
            }
        }

        public Konto(int guthaben)
        {
            if (guthaben >= 0)
            {
                this.guthaben = guthaben;
                this.kontonummer = lastKontonummer + 1;
                lastKontonummer = this.kontonummer;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben kann nicht negativ sein.");
            }            

        }

        public void Einzahlen(int betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }

        public void Aufloesen()
        {
            Auszahlen(Guthaben);
            Console.WriteLine("Konto wurde aufgelößt");
        }
    }
}
