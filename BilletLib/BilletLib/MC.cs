using System;

namespace BilletLib
{
    public class MC : ZeBaseKlasseHonHonHon
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

        public MC()
        {
            
        }

        public override int Pris()
        {
            return 125;
        }

        public override string Kørertøj()
        {
            return "MC";
        }

        public override void NummerpladeForLang()
        {
            throw new NotImplementedException();
        }
    }
}