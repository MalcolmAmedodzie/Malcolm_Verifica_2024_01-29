using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Malcolm_Verifica_2024_01_29
{
    public partial class Form2 : Form
    {
        public string id_Prodotto;
        public Form2(string id)
        {
            InitializeComponent();
            id_Prodotto = id;
            PopolaForm();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string ConnectionString = "server=127.0.0.1;" +
                                  "database=Verifica_Malcolm;" +
                                  "uid=root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();


                string query = $"UPDATE Prodotti " +
                    $"SET " +
                    $"Codice Farnell = '{textBoxFarnell.Text}', " +
                    $"Descrizione = '{textBoxDescrizione.Text}', " +
                    $"Produttore = '{textBoxProduttore.Text}', " +
                    $"Codice Produttore = '{textBoxCodiceProduttore.Text}', " +
                    $"Quantita = '{textBoxQuantita.Text}', " +
                    $"Prezzo = '{textBoxPrezzo.Text}', " +
                    $"WHERE id = {id_Prodotto}";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                cmd.ExecuteNonQuery();

                connessione.Close();
            }
            catch (Exception tipoErrore)
            {
                MessageBox.Show(tipoErrore.Message);
            }

            this.Close();
        }

        public void PopolaForm()
        {
            string ConnectionString = "server=127.0.0.1;" +
                                    "database=Verifica_Malcolm;" +
                                    "uid=root;";
            MySqlConnection connessione = new MySqlConnection(ConnectionString);
            try
            {
                connessione.Open();
                string query = $"SELECT * FROM Prodotti WHERE id = '{id_Prodotto}'";
                MySqlCommand cmd = new MySqlCommand(query, connessione);
                MySqlDataReader dr = cmd.ExecuteReader();

                dr.Read();
                textBoxFarnell.Text = dr.GetInt32("Codice Farnell").ToString();
                textBoxDescrizione.Text = dr.GetString("Descrizione");
                textBoxProduttore.Text = dr.GetString("Produttore");
                textBoxCodiceProduttore.Text = dr.GetString("Codice Produttore");
                textBoxQuantita.Text = dr.GetInt32("Quantita").ToString();
                textBoxPrezzo.Text = dr.GetDecimal("Prezzo").ToString();

                dr.Close();

                connessione.Close();
            }
            catch
            {
                MessageBox.Show("Impossibile stabilire una connessione al DB");
            }
        }


    }

    


}
