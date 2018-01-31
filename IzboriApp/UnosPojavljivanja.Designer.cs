namespace IzboriApp
{
    partial class UnosPojavljivanja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnosPojavljivanja));
            this.btnAddIntervjui = new System.Windows.Forms.Button();
            this.btnAddRTV = new System.Windows.Forms.Button();
            this.btnAddDuel = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxEmisija = new System.Windows.Forms.TextBox();
            this.textBoxImeVoditelja = new System.Windows.Forms.TextBox();
            this.textBoxGledanost = new System.Windows.Forms.TextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnIntervjuiPotvrda = new System.Windows.Forms.Button();
            this.btnRTVPotvrda = new System.Windows.Forms.Button();
            this.labelNazivLista = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.labelDatumIntervjua = new System.Windows.Forms.Label();
            this.labelEmisija = new System.Windows.Forms.Label();
            this.labelDatumObjave = new System.Windows.Forms.Label();
            this.labelImeVoditelja = new System.Windows.Forms.Label();
            this.labelGledanost = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxNazivLista = new System.Windows.Forms.TextBox();
            this.btnPotvrdaDuel = new System.Windows.Forms.Button();
            this.listBoxPitanja = new System.Windows.Forms.ListBox();
            this.listBoxPkandidati = new System.Windows.Forms.ListBox();
            this.btnAddPitanje = new System.Windows.Forms.Button();
            this.btnAddPk = new System.Windows.Forms.Button();
            this.textBoxPitanje = new System.Windows.Forms.TextBox();
            this.textBoxPkandidat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddIntervjui
            // 
            this.btnAddIntervjui.Location = new System.Drawing.Point(20, 18);
            this.btnAddIntervjui.Name = "btnAddIntervjui";
            this.btnAddIntervjui.Size = new System.Drawing.Size(65, 23);
            this.btnAddIntervjui.TabIndex = 0;
            this.btnAddIntervjui.Text = "Intervjui";
            this.btnAddIntervjui.UseVisualStyleBackColor = true;
            this.btnAddIntervjui.Click += new System.EventHandler(this.btnAddIntervjui_Click);
            // 
            // btnAddRTV
            // 
            this.btnAddRTV.Location = new System.Drawing.Point(102, 18);
            this.btnAddRTV.Name = "btnAddRTV";
            this.btnAddRTV.Size = new System.Drawing.Size(75, 23);
            this.btnAddRTV.TabIndex = 1;
            this.btnAddRTV.Text = "RTV";
            this.btnAddRTV.UseVisualStyleBackColor = true;
            this.btnAddRTV.Click += new System.EventHandler(this.btnAddRTV_Click);
            // 
            // btnAddDuel
            // 
            this.btnAddDuel.Location = new System.Drawing.Point(191, 18);
            this.btnAddDuel.Name = "btnAddDuel";
            this.btnAddDuel.Size = new System.Drawing.Size(75, 23);
            this.btnAddDuel.TabIndex = 2;
            this.btnAddDuel.Text = "Duel";
            this.btnAddDuel.UseVisualStyleBackColor = true;
            this.btnAddDuel.Click += new System.EventHandler(this.btnAddDuel_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(43, 83);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(177, 20);
            this.textBoxNaziv.TabIndex = 3;
            this.textBoxNaziv.Visible = false;
            // 
            // textBoxEmisija
            // 
            this.textBoxEmisija.Location = new System.Drawing.Point(43, 141);
            this.textBoxEmisija.Name = "textBoxEmisija";
            this.textBoxEmisija.Size = new System.Drawing.Size(177, 20);
            this.textBoxEmisija.TabIndex = 4;
            this.textBoxEmisija.Visible = false;
            // 
            // textBoxImeVoditelja
            // 
            this.textBoxImeVoditelja.Location = new System.Drawing.Point(43, 206);
            this.textBoxImeVoditelja.Name = "textBoxImeVoditelja";
            this.textBoxImeVoditelja.Size = new System.Drawing.Size(177, 20);
            this.textBoxImeVoditelja.TabIndex = 5;
            this.textBoxImeVoditelja.Visible = false;
            this.textBoxImeVoditelja.WordWrap = false;
            // 
            // textBoxGledanost
            // 
            this.textBoxGledanost.Location = new System.Drawing.Point(43, 256);
            this.textBoxGledanost.Name = "textBoxGledanost";
            this.textBoxGledanost.Size = new System.Drawing.Size(177, 20);
            this.textBoxGledanost.TabIndex = 6;
            this.textBoxGledanost.Visible = false;
            this.textBoxGledanost.WordWrap = false;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(192, 295);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(80, 23);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Visible = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnIntervjuiPotvrda
            // 
            this.btnIntervjuiPotvrda.Location = new System.Drawing.Point(111, 295);
            this.btnIntervjuiPotvrda.Name = "btnIntervjuiPotvrda";
            this.btnIntervjuiPotvrda.Size = new System.Drawing.Size(75, 23);
            this.btnIntervjuiPotvrda.TabIndex = 8;
            this.btnIntervjuiPotvrda.Text = "Potvrda";
            this.btnIntervjuiPotvrda.UseVisualStyleBackColor = true;
            this.btnIntervjuiPotvrda.Visible = false;
            this.btnIntervjuiPotvrda.Click += new System.EventHandler(this.btnIntervjuiPotvrda_Click);
            // 
            // btnRTVPotvrda
            // 
            this.btnRTVPotvrda.Location = new System.Drawing.Point(111, 295);
            this.btnRTVPotvrda.Name = "btnRTVPotvrda";
            this.btnRTVPotvrda.Size = new System.Drawing.Size(75, 23);
            this.btnRTVPotvrda.TabIndex = 9;
            this.btnRTVPotvrda.Text = "Potvrda";
            this.btnRTVPotvrda.UseVisualStyleBackColor = true;
            this.btnRTVPotvrda.Visible = false;
            this.btnRTVPotvrda.Click += new System.EventHandler(this.btnRTVPotvrda_Click);
            // 
            // labelNazivLista
            // 
            this.labelNazivLista.AutoSize = true;
            this.labelNazivLista.Location = new System.Drawing.Point(40, 60);
            this.labelNazivLista.Name = "labelNazivLista";
            this.labelNazivLista.Size = new System.Drawing.Size(55, 13);
            this.labelNazivLista.TabIndex = 10;
            this.labelNazivLista.Text = "Naziv lista";
            this.labelNazivLista.Visible = false;
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(108, 60);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 11;
            this.labelNaziv.Text = "Naziv";
            this.labelNaziv.Visible = false;
            // 
            // labelDatumIntervjua
            // 
            this.labelDatumIntervjua.AutoSize = true;
            this.labelDatumIntervjua.Location = new System.Drawing.Point(40, 109);
            this.labelDatumIntervjua.Name = "labelDatumIntervjua";
            this.labelDatumIntervjua.Size = new System.Drawing.Size(81, 13);
            this.labelDatumIntervjua.TabIndex = 12;
            this.labelDatumIntervjua.Text = "Datum intervjua";
            this.labelDatumIntervjua.Visible = false;
            // 
            // labelEmisija
            // 
            this.labelEmisija.AutoSize = true;
            this.labelEmisija.Location = new System.Drawing.Point(103, 109);
            this.labelEmisija.Name = "labelEmisija";
            this.labelEmisija.Size = new System.Drawing.Size(39, 13);
            this.labelEmisija.TabIndex = 13;
            this.labelEmisija.Text = "Emisija";
            this.labelEmisija.Visible = false;
            // 
            // labelDatumObjave
            // 
            this.labelDatumObjave.AutoSize = true;
            this.labelDatumObjave.Location = new System.Drawing.Point(40, 178);
            this.labelDatumObjave.Name = "labelDatumObjave";
            this.labelDatumObjave.Size = new System.Drawing.Size(101, 13);
            this.labelDatumObjave.TabIndex = 14;
            this.labelDatumObjave.Text = "Datum Objavljivanja";
            this.labelDatumObjave.Visible = false;
            // 
            // labelImeVoditelja
            // 
            this.labelImeVoditelja.AutoSize = true;
            this.labelImeVoditelja.Location = new System.Drawing.Point(96, 178);
            this.labelImeVoditelja.Name = "labelImeVoditelja";
            this.labelImeVoditelja.Size = new System.Drawing.Size(69, 13);
            this.labelImeVoditelja.TabIndex = 15;
            this.labelImeVoditelja.Text = " Ime voditelja";
            this.labelImeVoditelja.Visible = false;
            // 
            // labelGledanost
            // 
            this.labelGledanost.AutoSize = true;
            this.labelGledanost.Location = new System.Drawing.Point(103, 229);
            this.labelGledanost.Name = "labelGledanost";
            this.labelGledanost.Size = new System.Drawing.Size(55, 13);
            this.labelGledanost.TabIndex = 17;
            this.labelGledanost.Text = "Gledanost";
            this.labelGledanost.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(43, 206);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 20);
            this.dateTimePicker2.TabIndex = 19;
            this.dateTimePicker2.Visible = false;
            // 
            // textBoxNazivLista
            // 
            this.textBoxNazivLista.Location = new System.Drawing.Point(43, 83);
            this.textBoxNazivLista.Name = "textBoxNazivLista";
            this.textBoxNazivLista.Size = new System.Drawing.Size(177, 20);
            this.textBoxNazivLista.TabIndex = 20;
            this.textBoxNazivLista.Visible = false;
            // 
            // btnPotvrdaDuel
            // 
            this.btnPotvrdaDuel.Location = new System.Drawing.Point(90, 295);
            this.btnPotvrdaDuel.Name = "btnPotvrdaDuel";
            this.btnPotvrdaDuel.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdaDuel.TabIndex = 23;
            this.btnPotvrdaDuel.Text = "Potvrda";
            this.btnPotvrdaDuel.UseVisualStyleBackColor = true;
            this.btnPotvrdaDuel.Click += new System.EventHandler(this.btnPotvrdaDuel_Click);
            // 
            // listBoxPitanja
            // 
            this.listBoxPitanja.FormattingEnabled = true;
            this.listBoxPitanja.Location = new System.Drawing.Point(24, 181);
            this.listBoxPitanja.Name = "listBoxPitanja";
            this.listBoxPitanja.Size = new System.Drawing.Size(120, 95);
            this.listBoxPitanja.TabIndex = 24;
            this.listBoxPitanja.Visible = false;
            // 
            // listBoxPkandidati
            // 
            this.listBoxPkandidati.FormattingEnabled = true;
            this.listBoxPkandidati.Location = new System.Drawing.Point(152, 181);
            this.listBoxPkandidati.Name = "listBoxPkandidati";
            this.listBoxPkandidati.Size = new System.Drawing.Size(120, 95);
            this.listBoxPkandidati.TabIndex = 25;
            this.listBoxPkandidati.Visible = false;
            // 
            // btnAddPitanje
            // 
            this.btnAddPitanje.Location = new System.Drawing.Point(20, 83);
            this.btnAddPitanje.Name = "btnAddPitanje";
            this.btnAddPitanje.Size = new System.Drawing.Size(75, 23);
            this.btnAddPitanje.TabIndex = 26;
            this.btnAddPitanje.Text = "+Pitanje";
            this.btnAddPitanje.UseVisualStyleBackColor = true;
            this.btnAddPitanje.Visible = false;
            this.btnAddPitanje.Click += new System.EventHandler(this.btnAddPitanje_Click);
            // 
            // btnAddPk
            // 
            this.btnAddPk.Location = new System.Drawing.Point(175, 83);
            this.btnAddPk.Name = "btnAddPk";
            this.btnAddPk.Size = new System.Drawing.Size(92, 23);
            this.btnAddPk.TabIndex = 27;
            this.btnAddPk.Text = "+Protivkandidat";
            this.btnAddPk.UseVisualStyleBackColor = true;
            this.btnAddPk.Visible = false;
            this.btnAddPk.Click += new System.EventHandler(this.btnAddPk_Click);
            // 
            // textBoxPitanje
            // 
            this.textBoxPitanje.Location = new System.Drawing.Point(24, 125);
            this.textBoxPitanje.Name = "textBoxPitanje";
            this.textBoxPitanje.Size = new System.Drawing.Size(100, 20);
            this.textBoxPitanje.TabIndex = 28;
            this.textBoxPitanje.Visible = false;
            // 
            // textBoxPkandidat
            // 
            this.textBoxPkandidat.Location = new System.Drawing.Point(167, 125);
            this.textBoxPkandidat.Name = "textBoxPkandidat";
            this.textBoxPkandidat.Size = new System.Drawing.Size(100, 20);
            this.textBoxPkandidat.TabIndex = 29;
            this.textBoxPkandidat.Visible = false;
            // 
            // UnosPojavljivanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 335);
            this.Controls.Add(this.textBoxPkandidat);
            this.Controls.Add(this.textBoxPitanje);
            this.Controls.Add(this.btnAddPk);
            this.Controls.Add(this.btnAddPitanje);
            this.Controls.Add(this.listBoxPkandidati);
            this.Controls.Add(this.listBoxPitanja);
            this.Controls.Add(this.btnPotvrdaDuel);
            this.Controls.Add(this.textBoxNazivLista);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelGledanost);
            this.Controls.Add(this.labelImeVoditelja);
            this.Controls.Add(this.labelDatumObjave);
            this.Controls.Add(this.labelEmisija);
            this.Controls.Add(this.labelDatumIntervjua);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.labelNazivLista);
            this.Controls.Add(this.btnRTVPotvrda);
            this.Controls.Add(this.btnIntervjuiPotvrda);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.textBoxGledanost);
            this.Controls.Add(this.textBoxImeVoditelja);
            this.Controls.Add(this.textBoxEmisija);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.btnAddDuel);
            this.Controls.Add(this.btnAddRTV);
            this.Controls.Add(this.btnAddIntervjui);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UnosPojavljivanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje pojavljivanja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddIntervjui;
        private System.Windows.Forms.Button btnAddRTV;
        private System.Windows.Forms.Button btnAddDuel;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxEmisija;
        private System.Windows.Forms.TextBox textBoxImeVoditelja;
        private System.Windows.Forms.TextBox textBoxGledanost;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnIntervjuiPotvrda;
        private System.Windows.Forms.Button btnRTVPotvrda;
        private System.Windows.Forms.Label labelNazivLista;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Label labelDatumIntervjua;
        private System.Windows.Forms.Label labelEmisija;
        private System.Windows.Forms.Label labelDatumObjave;
        private System.Windows.Forms.Label labelImeVoditelja;
        private System.Windows.Forms.Label labelGledanost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxNazivLista;
        private System.Windows.Forms.Button btnPotvrdaDuel;
        private System.Windows.Forms.ListBox listBoxPitanja;
        private System.Windows.Forms.ListBox listBoxPkandidati;
        private System.Windows.Forms.Button btnAddPitanje;
        private System.Windows.Forms.Button btnAddPk;
        private System.Windows.Forms.TextBox textBoxPitanje;
        private System.Windows.Forms.TextBox textBoxPkandidat;
    }
}