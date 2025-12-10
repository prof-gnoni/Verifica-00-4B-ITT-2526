using LibreriaVeicoli;

namespace Esercizio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Pulsante "Aggiungi Veicolo"
        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            // Controllo veloce se i campi sono pieni
            if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtModello.Text))
            {
                MessageBox.Show("Inserisci tutti i dati!");
                return;
            }

            string marca = txtMarca.Text;
            string modello = txtModello.Text;
            int anno = int.Parse(txtAnno.Text);

            Veicolo nuovoVeicolo = new Veicolo(marca, modello, anno);

            // Aggiunge l'intero oggetto alla ListBox
            // La ListBox userà il ToString() per decidere cosa mostrare a video
            lstVeicoli.Items.Add(nuovoVeicolo);

            // Pulisco le caselle
            txtMarca.Clear();
            txtModello.Clear();
            txtAnno.Clear();
        }

        // 2. Evento cambio selezione nella ListBox
        private void lstVeicoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVeicoli.SelectedItem != null)
            {
                // L'elemento è un generico 'object', devo castarlo a 'Veicolo'
                Veicolo veicoloSelezionato = (Veicolo)lstVeicoli.SelectedItem;

                // Aggiorno la label con il Guid
                lblId.Text = "ID: " + veicoloSelezionato.Id.ToString();
            }
        }

        // 3. Pulsante "Salva su File"
        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("garage.csv"))
                {
                    foreach (var item in lstVeicoli.Items)
                    {
                        Veicolo v = (Veicolo)item;
                        // Formato CSV: Marca;Modello;Anno
                        string riga = $"{v.Marca};{v.Modello};{v.Anno}";
                        sw.WriteLine(riga);
                    }
                }
                MessageBox.Show("Salvataggio completato!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante il salvataggio: " + ex.Message);
            }
        }

        // 4. Pulsante "Carica da File"
        private void btnCarica_Click(object sender, EventArgs e)
        {
            if (File.Exists("garage.csv"))
            {
                // Pulisco la lista attuale
                lstVeicoli.Items.Clear();

                // Leggo tutte le righe
                string[] linee = File.ReadAllLines("garage.csv");

                foreach (string riga in linee)
                {
                    // Separo i dati col punto e virgola
                    string[] pezzi = riga.Split(';');

                    // Controllo che ci siano i 3 pezzi (Marca, Modello, Anno)
                    if (pezzi.Length == 3)
                    {
                        string marca = pezzi[0];
                        string modello = pezzi[1];
                        int anno = int.Parse(pezzi[2]);

                        // Creo e aggiungo
                        Veicolo v = new Veicolo(marca, modello, anno);
                        lstVeicoli.Items.Add(v);
                    }
                }
                MessageBox.Show("Caricamento completato!");
            }
            else
            {
                MessageBox.Show("File 'garage.csv' non trovato.");
            }
        }
    }
}