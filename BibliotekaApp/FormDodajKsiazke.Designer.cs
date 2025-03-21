namespace BibliotekaApp
{
    partial class FormDodajKsiazke
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtRok;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblRok;

        private void InitializeComponent()
        {
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();

            // Etykiety
            this.lblTytul.Text = "Tytuł:";
            this.lblAutor.Text = "Autor:";
            this.lblRok.Text = "Rok wydania:";

            this.lblTytul.Location = new System.Drawing.Point(20, 20);
            this.lblAutor.Location = new System.Drawing.Point(20, 60);
            this.lblRok.Location = new System.Drawing.Point(20, 100);

            // Pola tekstowe
            this.txtTytul.Location = new System.Drawing.Point(120, 20);
            this.txtAutor.Location = new System.Drawing.Point(120, 60);
            this.txtRok.Location = new System.Drawing.Point(120, 100);

            // Przycisk zapisania
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.Location = new System.Drawing.Point(120, 140);
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);

            // Konfiguracja formularza
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblRok);
            this.Controls.Add(this.txtTytul);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtRok);
            this.Controls.Add(this.btnZapisz);
            this.Text = "Dodaj książkę";
        }
    }
}
