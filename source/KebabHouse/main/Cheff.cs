namespace main
{
    internal class Cheff
    {
        List<int> aktualniObjednavka = new List<int>();

        public void ZiskaObjednavku()
        {

        }

        public void DoplnitZasoby(Sklad sklad, Skladnik skladnik)
        {
            foreach (KeyValuePair<string, int> item in sklad.VratiMaloZasob())
            {
                //Console.WriteLine(item.Key + " " + item.Value);
                skladnik.PridatDoSkladu(sklad, item.Key, 10);
            }
        }
    }
}
