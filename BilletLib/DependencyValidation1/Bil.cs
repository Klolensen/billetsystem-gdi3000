using System;

namespace BilletLib
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        public Bil()
        {
            
        }

        public int Pris()
        {
            return 240;
        }

        public string Kørertøj()
        {
            return "Bil";
        }

    }
}