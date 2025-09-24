using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopAlapok
{
    public class Szemely
    {
        public string _nev = "Nagy Pista";
        public int _kor = 40;

        public Szemely()
        {
        }

        public Szemely(string nev)
        {
            _nev = nev;
            
        }

        public string Nev
        {
            get { return _nev; }
            //set { _nev = value; }
                
            
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


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Nagy Pista");
            tanulo1.Kor = 44;
            Console.WriteLine(tanulo1.Nev + tanulo1.Kor);
        }
    }
}
