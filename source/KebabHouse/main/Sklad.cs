namespace main
{
    internal class Sklad
    {
        Dictionary<string, int> listZasob = new Dictionary<string, int>(){
            {"Maso", 50},
            {"Tortila", 50},
            {"Zeli", 50},
            { "Omacka1", 50},
            { "Omacka2", 9}};
        // maso, tortila, chleba, omackaBylina, omackaCesnek

        Dictionary<string, int> listNaDoplneni = new Dictionary<string, int>()
        // list veci co cheff musi koupit
            {
            {"Maso", 0},
            {"Tortila", 0},
            {"Zeli", 0},
            { "Omacka1", 0},
            { "Omacka2", 0}};

        // indexer, povolí pracovat s Sklad objektem a indexovani aka 'sklad[]'
        public int this[string surovina]
        {
            get
            {
                // If the material exists in the stock, return its quantity
                if (listZasob.ContainsKey(surovina))
                {
                    return listZasob[surovina];
                }
                else
                {
                    // If the material doesn't exist, return 0 (indicating no stock)
                    return 0;
                }
            }

            set
            {
                // If the material exists in the stock, update its quantity
                if (listZasob.ContainsKey(surovina))
                {
                    listZasob[surovina] = value;
                }
                else
                {
                    // If the material doesn't exist, add it to the stock with the specified quantity
                    listZasob.Add(surovina, value);
                }
            }
        }


        public void VytisknoutSeznamZasob()
        {
            foreach (KeyValuePair<string, int> item in listZasob)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            Console.WriteLine(); //formating

        }

        public void VytisknoutMaloZasob()
        {
            foreach (KeyValuePair<string, int> item in listZasob)
            {
                if (item.Value <= 10)
                {
                    Console.WriteLine("{0}: {1}", item.Key, item.Value);
                    listNaDoplneni[item.Key] = 20;
                }
            }
            Console.WriteLine();
        }

        public Dictionary<string, int> VratiMaloZasob()
        {
            Dictionary<string, int> ZasobyNaDoplneni = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> item in listZasob)
            {
                if (item.Value <= 10)
                {
                    ZasobyNaDoplneni.Add(item.Key, item.Value);
                }
            }
            return ZasobyNaDoplneni;
        }

    }
}
