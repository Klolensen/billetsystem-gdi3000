namespace BilletLib
{
    public abstract class ZeBaseKlasseHonHonHon
    {
        public abstract int Pris();

        public abstract string Kørertøj();


        public int Rabat { get; set; }

        

        public ZeBaseKlasseHonHonHon()
        {
            
        }

        public int PrisMedRabat()
        {
            int prismedrabat = Pris();

            int Rabat = 5;

            return prismedrabat * ((100 - Rabat) / 100);
        }
    }
}