namespace berek2020
{
    class Berek
    {

        public string Nev { get; set; }
        public string Nem { get; set; }
        public string Reszleg { get; set; }
        public int Belepes { get; set; }
        public int Ber { get; set; }

        public Berek(string sor) 
        {
            string[] b = sor.Split(';');
            Nev = b[0];
            Nem = b[1];
            Reszleg = b[2];
            Belepes = Convert.ToInt32(b[3]);
            Ber = Convert.ToInt32(b[4]);
        }
    }
}
