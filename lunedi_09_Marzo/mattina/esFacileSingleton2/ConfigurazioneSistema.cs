using System;
using System.Collections.Generic;

public class ConfigurazioneSistema
{
    private static ConfigurazioneSistema _instance;

    private Dictionary<string, string> configurazioni = new Dictionary<string, string>();

    private ConfigurazioneSistema()
    {
    }

    public static ConfigurazioneSistema Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ConfigurazioneSistema();
            }
            return _instance;
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

        return "Chiave non trovata";
    }

    public void StampaTutte()
    {
        foreach (var item in configurazioni)
        {
            Console.WriteLine(item.Key + " = " + item.Value);
        }
    }
}