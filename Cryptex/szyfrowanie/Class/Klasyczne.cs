using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Szyfrowanie.Class
{
    class Szyfr
    {
        public string TablicaZnakow = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz1234567890 ";
        /// <summary>
        /// Szyfrowanie tekstu szyfrem Cezara
        /// </summary>
        /// <param name="tekst">Tekst do zaszyfrowania</param>
        /// <param name="tekst">Klucz</param>
        /// <returns>Funkcja zwraca zaszyfrowany tekst</returns> 
        public string cezar_e(String tekst, int klucz){
            string ret = null;
            //zmniejszamy klucz za pomocą modulo wielkości tablicy znaków
            klucz = klucz % this.TablicaZnakow.Length;
            //wykonuje się tyle razy jak długi jest tekst
            for (int i = 0; i < tekst.Length; i++){
                if(this.TablicaZnakow.Contains(tekst[i]))
                {
                    ret += this.TablicaZnakow[(this.TablicaZnakow.IndexOf(tekst[i]) + klucz + this.TablicaZnakow.Length) % this.TablicaZnakow.Length];
                }
            }
            //zwraca zaszyfrowany tekst
            return ret;
        }
        /// <summary>
        /// Odszyfrowanie tekstu szyfrem Cezara
        /// </summary>
        /// <param name="tekst">Tekst do odszyfrowania</param>
        /// <param name="tekst">Klucz</param>
        /// <returns>Funkcja zwraca odszyfrowany tekst</returns> 
        public string cezar_d(String tekst, int klucz)
        {
            string ret = null;
            //zmniejszamy klucz za pomocą modulo wielkości tablicy znaków
            klucz = klucz % this.TablicaZnakow.Length;
            //wykonuje się tyle razy jak długi jest tekst
            for (int i = 0; i < tekst.Length; i++)
            {
                if(this.TablicaZnakow.Contains(tekst[i]))
                {
                    ret += this.TablicaZnakow[(this.TablicaZnakow.IndexOf(tekst[i]) - klucz + this.TablicaZnakow.Length) % this.TablicaZnakow.Length];
                }
            }
            //zwraca odszyfrowany tekst
            return ret;
        }
        /// <summary>
        /// Szyfrowanie tekstu szyfrem Vigenera
        /// </summary>
        /// <param name="tekst">Tekst do zaszyfrowania</param>
        /// <param name="tekst">Klucz w formie tekstu</param>
        /// <returns>Funkcja zwraca zaszyfrowany tekst</returns> 
        public string vigenere_e(string text, string key)
        {
            string TablicaZnakow = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyz1234567890 ";
            int n;
            string bufor = "";
            string ret = "";
            //wykonuje się tyle razy jak długi jest tekst
            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                    if (j == key.Length) j = 0;
                    bufor = Convert.ToString(text[i]);
                    switch (bufor)
                    {
                        default: break;
                        case "Ą": bufor = "A";
                            break;
                        case "Ć": bufor = "B";
                            break;
                        case "Ę": bufor = "E";
                            break;
                        case "Ł": bufor = "L";
                            break;
                        case "Ń": bufor = "N";
                            break;
                        case "Ó": bufor = "O";
                            break;
                        case "Ś": bufor = "S";
                            break;
                        case "Ź": bufor = "Z";
                            break;
                        case "Ż": bufor = "Z";
                            break;
                        case "ą": bufor = "a";
                            break;
                        case "ć": bufor = "b";
                            break;
                        case "ę": bufor = "e";
                            break;
                        case "ł": bufor = "l";
                            break;
                        case "ń": bufor = "n";
                            break;
                        case "ó": bufor = "o";
                            break;
                        case "ś": bufor = "s";
                            break;
                        case "ź": bufor = "z";
                            break;
                        case "ż": bufor = "z";
                            break;
                    }
                    if(!TablicaZnakow.Contains(bufor)) bufor = " ";
                    n = this.TablicaZnakow.IndexOf(key[j]);
                    //do zaszyfrowania używamy szyfru Cezara
                    bufor = cezar_e(bufor, n);
                    ret = ret + bufor;
            }
            //zwraca zaszyfrowany tekst
            return ret;
        }
        /// <summary>
        /// Odszfrowanie tekstu szyfrem Vigenera
        /// </summary>
        /// <param name="tekst">Tekst do odszyfrowania</param>
        /// <param name="tekst">Klucz w formie tekstu</param>
        /// <returns>Funkcja zwraca odszyfrowany tekst</returns> 
        public string vigenere_d(string text, string key)
        {
            int n;
            string bufor = "";
            string ret = "";
            //wykonuje się tyle razy jak długi jest tekst
            for (int i = 0, j = 0; i < text.Length; i++, j++)
            {
                    if (j == key.Length) j = 0;
                    bufor = Convert.ToString(text[i]);
                    n = this.TablicaZnakow.IndexOf(key[j]);
                    //do odszyforawnia używamy szyfru Cezara
                    bufor = cezar_d(bufor, n);
                    ret = ret + bufor;
            }
            //zwraca zaszyfrowany tekst
            return ret;
        }
    }
}