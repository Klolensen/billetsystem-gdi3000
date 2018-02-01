using System;

namespace BilletLib
{
    public class Bil : ZeBaseKlasseHonHonHon
    {
        public string Nummerplade
        {
            get
            {
                return Nummerplade; 
                
            }

            set
            {
                if ((Nummerplade.Length > 0) && (Nummerplade.Length < 7))
                {
                    Nummerplade = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        

        public DateTime Dato { get; set; }

       

        public override int Pris()
        {
            return 240;
            
        }

        public int PrisMedRabat()
        {
            int prismedrabat = Pris();

            int Rabat = 5;

            return prismedrabat * ((100 - Rabat)/100);
        }

        public int PrisMedWeekendRabat()
        {
            int prismedweekendrabat = Pris();

            int Rabat = 20;

            return prismedweekendrabat * ((100 - Rabat) / 100);
        }

        public override string Kørertøj()
        {
            return "Bil";
        }

       

        public Bil()
        {
        }
    }
}