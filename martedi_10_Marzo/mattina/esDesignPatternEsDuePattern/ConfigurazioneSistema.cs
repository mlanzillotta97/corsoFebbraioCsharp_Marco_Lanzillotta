using System;
using System.Collections.Generic;

namespace SistemaConfigurazione
{
    class ConfigurazioneSistema
    {
        private static ConfigurazioneSistema instance;

        private Dictionary<string, string> configurazioni;

        private ConfigurazioneSistema()
        {
            configurazioni = new Dictionary<string, string>();
        }

        public static ConfigurazioneSistema Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurazioneSistema();
                }
                return instance;
            }
        }

        public void Imposta(string chiave, string valore)
        {
            configurazioni[chiave] = valore;
        }

        public string Leggi(string chiave)
        {
            if (configurazioni.ContainsKey(chiave))
                return configurazioni[chiave];

            return null;
        }

        public void StampaTutte()
        {
            Console.WriteLine("\nConfigurazioni salvate:");

            foreach (var item in configurazioni)
            {
                Console.WriteLine(item.Key + " = " + item.Value);
            }
        }
    }
}