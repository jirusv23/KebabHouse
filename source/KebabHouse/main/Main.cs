namespace main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sklad sklad = new Sklad(); // 1 instance
            Cheff cheff = new Cheff(); // 1 instance
            Skladnik skladnik = new Skladnik(); // 1 instance

            sklad.VytisknoutSeznamZasob();
            sklad.VytisknoutMaloZasob();

            cheff.DoplnitZasoby(sklad, skladnik);

            sklad.VytisknoutSeznamZasob();

        }
    }
}
