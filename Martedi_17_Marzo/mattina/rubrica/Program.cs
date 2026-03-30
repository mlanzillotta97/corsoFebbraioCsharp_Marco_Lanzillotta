using System;
using MySql.Data.MySqlClient;

class Program
{
    static string connString = "server=127.0.0.1;port=3306;database=rubrica_db;user=root;password=Milan1997.;";

    static void Main()
    {
        int scelta = 0;

        do
        {
            Console.WriteLine("\n--- RUBRICA CONTATTI ---");
            Console.WriteLine("1. Inserisci nuovo contatto");
            Console.WriteLine("2. Visualizza contatti");
            Console.WriteLine("3. Elimina contatto per nome");
            Console.WriteLine("4. Esci");
            Console.Write("Scelta: ");

            int.TryParse(Console.ReadLine(), out scelta);

            switch (scelta)
            {
                case 1:
                    InserisciContatto();
                    break;

                case 2:
                    VisualizzaContatti();
                    break;

                case 3:
                    EliminaContatto();
                    break;

                case 4:
                    Console.WriteLine("Uscita...");
                    break;

                default:
                    Console.WriteLine("Scelta non valida!");
                    break;
            }

        } while (scelta != 4);
    }

    // 🔹 INSERT
    static void InserisciContatto()
    {
        Console.Write("Inserisci nome: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Inserisci telefono: ");
        string telefono = Console.ReadLine() ?? "";

        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO contatti (nome, telefono) VALUES (@nome, @telefono)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefono", telefono);

                cmd.ExecuteNonQuery();

                Console.WriteLine("✅ Contatto inserito!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Errore: " + ex.Message);
            }
        }
    }

    // 🔹 SELECT
    static void VisualizzaContatti()
    {
        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM contatti";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\n--- ELENCO CONTATTI ---");

                    if (!reader.HasRows)
                    {
                        Console.WriteLine("Nessun contatto trovato.");
                        return;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            $"ID: {reader["id"]} | Nome: {reader["nome"]} | Telefono: {reader["telefono"]}"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Errore: " + ex.Message);
            }
        }
    }

    // 🔹 DELETE
    static void EliminaContatto()
    {
        Console.Write("Inserisci il nome da eliminare: ");
        string nome = Console.ReadLine() ?? "";

        using (MySqlConnection conn = new MySqlConnection(connString))
        {
            try
            {
                conn.Open();

                string query = "DELETE FROM contatti WHERE nome = @nome";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", nome);

                int righe = cmd.ExecuteNonQuery();

                if (righe > 0)
                    Console.WriteLine("✅ Contatto eliminato!");
                else
                    Console.WriteLine("⚠️ Nessun contatto trovato.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Errore: " + ex.Message);
            }
        }
    }
}