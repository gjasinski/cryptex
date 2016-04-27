using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrowanie.Class
{
    #region Legacy
    //class program
    //{
    //    static void main(string[] args)
    //    {
    //        rsa r = new rsa();
    //        console.writeline(r.keygen(20));
    //        console.writeline();
    //        long v = r.encode(93, 143, 7);
    //        console.writeline(v);
    //        console.writeline();
    //        console.writeline(r.encode(v, 143, 103));
    //        console.readline();
    //    }

    //}
    #endregion
    class RSA
    {
        public string TablicaZnakow = "ABCDEFGHIJKLMNOPQRSTUWXYZabcdefghijklmnopqrstuwxyzĘÓĄŚŻŹĆŃŁęóąśżźćńł1234567890 ~!@#$%^&*()_+{}|:\"<>?/.,';][=-`";
        private List<long> factors = new List<long>();
        private List<long> primes = new List<long>();
        Random rnd = new Random();
        private long size=0;
        /////////////////////////////////////diagnostyczne
        public void displayList()
        {
            for (int i = 0; i < this.factors.Count(); i++)
            {
                Console.WriteLine(this.primes[i]);
            }
        }
        /////////////////////////////////////operacyjne
        public void factorize(long liczba)
        { // rozklad liczby na czynniki pierwsze (z powtorzeniami)
            long g = Convert.ToInt64(Math.Ceiling(Math.Sqrt(liczba)));
            long n = liczba;
            for (long i = 2; i <= g; i++)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
                if (n == 1)
                {
                    break;
                }
            }
            factors.Add(n);
        }
        public void getFactors()
        { // pobranie czynnikow pierwszych bez powtoren z listy czynnikow
            List<long> f = new List<long>();
            for (int i = 0; i < this.factors.Count(); i++)
            {
                if (f.Contains(this.factors[i]))
                {
                    continue;
                }
                else
                {
                    f.Add(this.factors[i]);
                }
            }
            this.factors.Clear();
            this.factors.AddRange(f);
        }
        public double eulersPhi(long n) // tocjent Eulera - ilosc liczb wzglednie pierwszych z n
        {
            this.factorize(n);
            this.getFactors();
            double ret = 1;
            if (this.check(n))
            {
                return n - 1;
            }
            else
            {
                for (int i = 0; i < this.factors.Count() - 1; i++)
                {
                    ret *= (Convert.ToDouble(this.factors[i]) - 1);
                }
                return ret * n;
            }
        }
        private bool check(long n)
        { // sprawdzenie pierwszosci liczby n
            long p = 0, liczba = 0;
            bool info = true;
            p = liczba / 2;
            for (int i = 2; i <= p; i++)
            {
                if (liczba % i == 0)
                {
                    info = false;
                    break;
                }
            }
            if (info == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void sieve(long n)
        { // sito erastotenesa - generowanie wektora liczb pierwszych
            this.primes.Clear();
            List<bool> bufor = new List<bool>();
            for (int i = 0; i <= n; i++) bufor.Add(true);
            int k = 0;
            //long max = Convert.ToInt64(Math.Ceiling(Math.Sqrt(n)));
            for (int i = 2; i < n; i++)
            {
                if (bufor[i] == true)
                {
                    k = i;
                    k = k + i;
                    while (k <= n)
                    {
                        bufor[k] = false;
                        k = k + i;
                    }
                }
            }
            for (int i = 2; i <= bufor.Count() - 1; i++)
            {
                if (bufor[i] == true) { this.primes.Add(i); }
            }
        }
        public long moduloInversion(long a, long n)
        {
            long a0, n0, p0, p1, q, r, t;
            p0 = 0;
            p1 = 1;
            a0 = a;
            n0 = n;
            q = n0 / a0;
            r = n0 % a0;
            while (r > 0)
            {
                t = p0 - q * p1;
                if (t >= 0)
                {
                    t = t % n;
                }
                else t = n - ((-t) % n);
                p0 = p1;
                p1 = t;
                n0 = a0;
                a0 = r;
                q = n0 / a0;
                r = n0 % a0;
            }
            return p1;
        }
        public long gcd(long a, long b) // greatest common divisor - najwiekszy wspolny dzielnik - algorytm Euklidesa
        {
            while (b != 0)
            {
                long t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        public long modularPower(long a, long b, long m)
        {
            long i;
            long result = 1;
            long x = a % m;

            for (i = 1; i <= b; i <<= 1)
            {
                x %= m;
                if ((b & i) != 0)
                {
                    result *= x;
                    result %= m;
                }
                x *= x;
            }

            return result;
        }
        public string keygen(long range) // generator kluczy
        {
            if (!(this.size == range))
            {
                this.size = range;
                this.sieve(range);
            }
            long p = this.primes[rnd.Next() % this.primes.Count()];
            long q = this.primes[rnd.Next() % this.primes.Count()];
            long n = (p * q);
            long tocjentN = (p - 1) * (q - 1);
            long e = 0;
            for (long i = (tocjentN - q); i > 0; i--)
            {
                if (this.gcd(i, tocjentN) == 1)
                {
                    e = i;
                    break;
                }
            }
            long d = this.moduloInversion(e, tocjentN);
            return  n + "|" + e + "/" + n + "|" + d;
        }
        public int encode(Int32 x, long n, long e)
        {
            //int tab = Convert.ToInt32(modularPower(Convert.ToInt64(TablicaZnakow.IndexOf(x)), e, n)) % TablicaZnakow.Length;
            //char xyz =  TablicaZnakow[tab];
            int z = Convert.ToInt32(modularPower(x, e, n));
            return z;
        }
    }
}
