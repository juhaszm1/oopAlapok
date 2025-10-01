using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAlapok
{
    public class Szemely
    {
        private string _nev;
        private int _kor;

        public Szemely(string nev)
        {
            _nev = nev;
        }

        public Szemely(string nev, int kor)
        {
            _nev = nev;
            _kor = kor;
        }

        public string Nev
        {
            get { return _nev; }
        }

        public int Kor
        {
            get { return _kor; }
            set
            {
                if (value >= 0)
                    _kor = value;
                else
                    Console.WriteLine("Hibas kor");
            }
        }

        public override string ToString()
        {
            return $"A tanuló neve {_nev} Életkora {_kor}";
        }
    }

    public class Bankszamla
    {
        private int _egyenleg;

        public int Egyenleg
        {
            set
            {
                if (value >= 0)
                {
                    _egyenleg = value;
                }
                else
                {
                    Console.WriteLine("Az egyenleg nem lehet kisebb nullanal");
                }
            }
        }

        private void Betesz()
        {
        }

        public void Kivesz()
        {
        }
    }

    public class Hallgato : Szemely
    {
        private string _neptunekod;

        public string Neptunkod
        {
            set
            {
                if (value.Length == 6)
                    _neptunekod = value;
            }
        }

        public Hallgato(string nev, int kor) : base(nev, kor)
        {
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Nagy Pista")
            {
                Kor = 44
            };

            Console.WriteLine(tanulo1);

            List<Hallgato> hallgatoLista = new List<Hallgato>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Add meg a hallgato {i + 1} nevet");
                string nev = Console.ReadLine();
                Console.WriteLine($"Add meg a hallgato {i + 1} kort");
                int kor = int.Parse(Console.ReadLine());
                Hallgato hallgato = new Hallgato(nev, kor);
                Console.WriteLine($"Add meg a hallgato {i + 1} neptunkodjat");
                hallgato.Neptunkod = Console.ReadLine();
                hallgatoLista.Add(hallgato);
            }

            foreach (var item in hallgatoLista)
            {
                Console.WriteLine(item.Nev);
            }

        }
    }
}
