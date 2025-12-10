namespace Esercizio_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMarca = new TextBox();
            txtModello = new TextBox();
            lblMarca = new Label();
            lblModello = new Label();
            lblAnno = new Label();
            txtAnno = new TextBox();
            btnAggiungi = new Button();
            btnCarica = new Button();
            btnSalva = new Button();
            lstVeicoli = new ListBox();
            lblId = new Label();
            lblLista = new Label();
            SuspendLayout();
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(54, 101);
            txtMarca.Margin = new Padding(6, 7, 6, 7);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(196, 42);
            txtMarca.TabIndex = 0;
            // 
            // txtModello
            // 
            txtModello.Location = new Point(54, 245);
            txtModello.Margin = new Padding(6, 7, 6, 7);
            txtModello.Name = "txtModello";
            txtModello.Size = new Size(196, 42);
            txtModello.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(54, 53);
            lblMarca.Margin = new Padding(6, 0, 6, 0);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(85, 36);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // lblModello
            // 
            lblModello.AutoSize = true;
            lblModello.Location = new Point(54, 197);
            lblModello.Margin = new Padding(6, 0, 6, 0);
            lblModello.Name = "lblModello";
            lblModello.Size = new Size(109, 36);
            lblModello.TabIndex = 3;
            lblModello.Text = "Modello";
            // 
            // lblAnno
            // 
            lblAnno.AutoSize = true;
            lblAnno.Location = new Point(54, 341);
            lblAnno.Margin = new Padding(6, 0, 6, 0);
            lblAnno.Name = "lblAnno";
            lblAnno.Size = new Size(77, 36);
            lblAnno.TabIndex = 5;
            lblAnno.Text = "Anno";
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(54, 389);
            txtAnno.Margin = new Padding(6, 7, 6, 7);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(196, 42);
            txtAnno.TabIndex = 4;
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(294, 98);
            btnAggiungi.Margin = new Padding(6, 7, 6, 7);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(278, 346);
            btnAggiungi.TabIndex = 6;
            btnAggiungi.Text = "Aggiungi alla ListBox";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // btnCarica
            // 
            btnCarica.Location = new Point(54, 626);
            btnCarica.Margin = new Padding(6, 7, 6, 7);
            btnCarica.Name = "btnCarica";
            btnCarica.Size = new Size(196, 55);
            btnCarica.TabIndex = 7;
            btnCarica.Text = "Carica CSV...";
            btnCarica.UseVisualStyleBackColor = true;
            btnCarica.Click += btnCarica_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(294, 626);
            btnSalva.Margin = new Padding(6, 7, 6, 7);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(196, 55);
            btnSalva.TabIndex = 8;
            btnSalva.Text = "Salva CSV...";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // lstVeicoli
            // 
            lstVeicoli.FormattingEnabled = true;
            lstVeicoli.ItemHeight = 36;
            lstVeicoli.Location = new Point(664, 96);
            lstVeicoli.Margin = new Padding(6, 7, 6, 7);
            lstVeicoli.Name = "lstVeicoli";
            lstVeicoli.Size = new Size(450, 580);
            lstVeicoli.TabIndex = 9;
            lstVeicoli.SelectedIndexChanged += lstVeicoli_SelectedIndexChanged;
            // 
            // lblId
            // 
            lblId.BackColor = SystemColors.ActiveCaption;
            lblId.BorderStyle = BorderStyle.FixedSingle;
            lblId.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.White;
            lblId.Location = new Point(56, 826);
            lblId.Margin = new Padding(6, 0, 6, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(1060, 175);
            lblId.TabIndex = 10;
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Location = new Point(664, 53);
            lblLista.Margin = new Padding(6, 0, 6, 0);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(146, 36);
            lblLista.TabIndex = 11;
            lblLista.Text = "Lista Veicoli";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1222, 1080);
            Controls.Add(lblLista);
            Controls.Add(lblId);
            Controls.Add(lstVeicoli);
            Controls.Add(btnSalva);
            Controls.Add(btnCarica);
            Controls.Add(btnAggiungi);
            Controls.Add(lblAnno);
            Controls.Add(txtAnno);
            Controls.Add(lblModello);
            Controls.Add(lblMarca);
            Controls.Add(txtModello);
            Controls.Add(txtMarca);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "Gestione Veicoli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarca;
        private TextBox txtModello;
        private Label lblMarca;
        private Label lblModello;
        private Label lblAnno;
        private TextBox txtAnno;
        private Button btnAggiungi;
        private Button btnCarica;
        private Button btnSalva;
        private ListBox lstVeicoli;
        private Label lblId;
        private Label lblLista;
    }
}
