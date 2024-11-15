namespace main
{
    internal class Skladnik
    {

        public void PridatDoSkladu(Sklad sklad, string surovina, int pocetPridaneSuroviny)
        {
            sklad[surovina] += pocetPridaneSuroviny;
        }

    }
}
