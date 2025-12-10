namespace LibreriaVeicoli
{
    public class Veicolo
    {
        public Guid Id { get; private set; }
        public string Marca { get; set; }    // [cite: 17]
        public string Modello { get; set; }  // [cite: 19]
        public int Anno { get; set; }        // [cite: 20]

        public Veicolo(string marca, string modello, int anno)
        {
            this.Id = Guid.NewGuid();
            this.Marca = marca;
            this.Modello = modello;
            this.Anno = anno;
        }

        public override string ToString()
        {
            // Formato richiesto es: "Fiat Panda (2010)"
            return $"{Marca} {Modello} ({Anno})";
        }
    }
}
