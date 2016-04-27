using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie
{
    class Keygen
    {
        private long keyLength;
        private long rotorsCount;
        private long rotorSize;
        private long complexity;
        private long Rounds;
        List<long[]> rotors = new List<long[]>();
        /// <summary>
        /// Klasa generatora kluczy szyfrujacych bazujaca na masyznie wirnikowej
        /// </summary>
        /// <param name="mode">Format klucza (binarny/dziesietny/hex)</param>
        /// <param name="keyLength">Dlugosc klucza w bitach</param>
        /// <param name="rotorsCount">Ilosc wirnikow losujacych</param>
        /// <param name="rotorSize">Dlugosc wirnikow losujacych</param>
        /// <param name="complexity">Ziarno losowosci</param>
        public Keygen(long keyLength, long rotorsCount, long rotorSize, long complexity, long Rounds)
        {
            this.keyLength = keyLength; this.rotorsCount = rotorsCount;
            this.rotorSize = rotorSize;
            this.complexity = complexity;
            this.Rounds = Rounds;
            this.initializeRotors();
        }
        public void setRotorsCount(long rotorsCount)
        {
            this.rotorsCount = rotorsCount;
            this.initializeRotors();
        }
        public void setRotorSize(long rotorSize)
        {
            this.rotorSize = rotorSize;
            this.initializeRotors();
        }
        public void setKeyLength(long keyLength)
        {
            this.keyLength = keyLength;
        }
        public void setComplexity(long complexity)
        {
            this.complexity = complexity;
        }
        public void setRounds(long rounds)
        {
            this.Rounds = rounds;
        }
        private void initializeRotors(){
            Random rnd = new Random();
            this.rotors.Clear();
            for (int i = 0; i < this.rotorsCount; i++)
            {
                long[] rotor = new long[this.rotorSize];
                for (int j = 0; j < this.rotorSize; j++)
                {
                    try
                    {
                        rotor[j] = Math.Abs(rnd.Next() % (this.complexity + 1));
                    }
                    catch (DivideByZeroException)
                    {
                        rotor[j] = Math.Abs(rnd.Next() % (this.complexity + 5));
                    }
                }
                this.rotors.Add(rotor);
            }
        }
        public string generateKey()
        {
            string key = "";
            char[] hex= {'A','B','C','D','E','F'};
            long byteLength = this.keyLength;
            long c = new Random().Next() % 10000;
            try
            {
                for (int x = 0; x < this.Rounds; x++)
                {
                    for (int i = 0; i < this.rotorsCount; i++)
                    {
                        for (int j = 0; j < this.rotorSize; j++)
                        {
                            this.rotors[i][j] = Math.Abs(this.rotors[i][(j + 17) % this.rotorSize]);
                            initializeRotors();
                            this.rotors[i][(j + 5) % this.rotorSize] = c + 123;
                            c += Math.Abs(c);
                            c *= (new Random().Next() % 1000);
                            initializeRotors();
                            c += this.rotors[Convert.ToInt32(j % this.rotorsCount)][i % this.rotorSize];
                            c = Math.Abs(c);
                            long v = Math.Abs(new Random().Next() % 100000);
                            initializeRotors();
                            key += Math.Abs((this.rotors[i][j] * c) % 256).ToString("X");
                        }
                    }
                }
            }
            catch (OverflowException ex)
            {
                return "Błąd systemowy - spróbuj ponownie";
            }
            try
            {
                key = key.Remove(Convert.ToInt32(this.keyLength) / 8);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                System.Windows.MessageBox.Show("Dla podanych parametrów nie można wygenerować klucza danej długości", "Błąd", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                return "";
                //1,10,0!!
            }
            return key;   
        }
    }
}
