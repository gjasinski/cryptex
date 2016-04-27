using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Szyfrowanie.Class
{
    public class Quiz
    {
        /// <summary>
        /// Klasa Quiz jest odpowiedzialna za obsluge testu. Pole tablicowe "pytania" zawiera pytania załadowane z pliku Data/Data.txt
        /// natomiast pole "index" zawiera indeksy pytań wylosowanych generatorem
        /// </summary>
        /// 
        public string[,] pytania; // pytania z pliku Data/Data.txt
        public int pL = 0; // ilosc pytan
        public byte[] index = new byte[6]; // indeksy z tablicy pytania
        public Quiz() // konstruktor
        {
            if (System.IO.File.Exists("Data/Data.txt"))
            {
                this.init();
                this.generator();
            }
            else
            {
                MessageBox.Show("Nie odnaleziono pliku z pytaniami!", "Błąd", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public void init(){ // Metoda init pobiera dane z pliku tekstowego oraz wypełnia nimi tabele pytania
            string lines = System.IO.File.ReadAllText("Data/Data.txt");
            string[] ptable;
            string[] htable = lines.Split('#'); // pytania oddzielone są od siebie znakiem #
            this.pytania = new string[htable.Length, 5];
            this.pL = htable.Length;
            for (int i = 0; i < htable.Length-1; i++)
            {
                ptable = htable[i].Split(';'); // tresc pytania oraz odpowiedzi oddzielone sa znakiem ; 
                for (int j = 0; j < 5; j++) {
                    this.pytania[i, j] = ptable[j];
                }
            }
           
        }
        /// <summary>
        /// Metoda generator generuje losowo 5 pytań bez powtórzeń i zapisuje indeksy, pod ktorymi znajduja sie w tablicy pytania w tablicy index
        /// </summary>
        public void generator()
        { 
            this.index = new byte[6];
            Random rnd = new Random();
            int i = 0;
            while (i < 6)
            {
                byte v = Convert.ToByte(rnd.Next() % this.pL);
                bool znalezione = false;
                for (int x = 0; x < 6; x++)
                {
                    if (this.index[x] == v)
                    {
                        znalezione = true;
                    }

                }
                if (!znalezione)
                {
                    this.index[i] = v;
                    i++;
                }
                continue;
            }
        }
        /// <summary>
        ///  Metoda checkAnswer sprawdza poprawnosc odpowiedzi udzielonej na pytanie.
        ///  Kazda odpowiedz posiada na koncu znak //0 lub //1 bedacy informacja, czy dana opcja jest prawidlowa
        /// </summary>
        /// <param name="index">Indeks pytania w tablicy "pytania"</param>
        /// <param name="odp">Numer odpowiedzi</param>
        /// <returns></returns>
        public bool checkAnswer(byte index, byte odp)
        {
            if (this.pytania[index, odp][this.pytania[index, odp].Length - 1] == '1') { return true; } // odcinamy ostatni znak w celu sprawdzenia poprawnosci
            else { return false; }
        }
    }
}
