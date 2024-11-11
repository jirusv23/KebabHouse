namespace main
{
    internal class Sklad
    {
        Dictionary<string, int> listZasob = new Dictionary<string, int>(){
            {"Maso", 0},
            {"Tortila", 0},
            {"Zeli", 0},
            { "Omacka1", 0},
            { "Omacka2", 0}};
        // maso, tortila, chleba, omackaBylina, omackaCesnek
    

        public void VytisknoutSeznamZasob()
        {
            foreach (KeyValuePair<string, int> item in listZasob)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
        }

    }
}
