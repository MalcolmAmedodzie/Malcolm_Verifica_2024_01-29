using MySql.Data.MySqlClient;

namespace Malcolm_Verifica_2024_01_29
{
    public partial class Form1 : Form
    {
        string ConnectionString = "server=127.0.0.1;" +
                                    "database=Verifica_Malcolm;" +
                                    "uid=root;";
        public Form1()
        {
            InitializeComponent();
            //TestConnessione();
            PololaTabella();
        }

        public void PololaTabella()
        {
            dataGridView1.Rows.Clear();
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = "SELECT * FROM Prodotti";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dataGridView1.Rows.Add(
                        dr.GetInt32("Id").ToString(),
                        dr.GetInt32("Codice Farnell"),
                        dr.GetString("Codice Produttore"),
                        dr.GetInt32("Quantita"),
                        dr.GetDecimal("Prezzo")
                    );
                }

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }

            

        }

    }
}