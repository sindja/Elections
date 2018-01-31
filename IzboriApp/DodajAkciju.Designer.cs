namespace IzboriApp
{
    partial class DodajAkciju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajAkciju));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLokacija = new System.Windows.Forms.Label();
            this.labelTrajanje = new System.Windows.Forms.Label();
            this.buttonDodajAkciju = new System.Windows.Forms.Button();
            this.radioButtonSusK = new System.Windows.Forms.RadioButton();
            this.radioButtonPolM = new System.Windows.Forms.RadioButton();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxGrad = new System.Windows.Forms.TextBox();
            this.textBoxLokacija = new System.Windows.Forms.TextBox();
            this.textBoxTrajanje = new System.Windows.Forms.TextBox();
            this.groupBoxZatvori = new System.Windows.Forms.GroupBox();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.textBoxIznajmlj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxZatvoren = new System.Windows.Forms.CheckBox();
            this.labelZatvoren = new System.Windows.Forms.Label();
            this.radioButtonDeljeLet = new System.Windows.Forms.RadioButton();
            this.groupBoxZatvori.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grad:";
            // 
            // labelLokacija
            // 
            this.labelLokacija.AutoSize = true;
            this.labelLokacija.Location = new System.Drawing.Point(48, 119);
            this.labelLokacija.Name = "labelLokacija";
            this.labelLokacija.Size = new System.Drawing.Size(50, 13);
            this.labelLokacija.TabIndex = 2;
            this.labelLokacija.Text = "Lokacija:";
            this.labelLokacija.Visible = false;
            // 
            // labelTrajanje
            // 
            this.labelTrajanje.AutoSize = true;
            this.labelTrajanje.Location = new System.Drawing.Point(50, 151);
            this.labelTrajanje.Name = "labelTrajanje";
            this.labelTrajanje.Size = new System.Drawing.Size(48, 13);
            this.labelTrajanje.TabIndex = 3;
            this.labelTrajanje.Text = "Trajanje:";
            this.labelTrajanje.Visible = false;
            // 
            // buttonDodajAkciju
            // 
            this.buttonDodajAkciju.Location = new System.Drawing.Point(113, 260);
            this.buttonDodajAkciju.Name = "buttonDodajAkciju";
            this.buttonDodajAkciju.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajAkciju.TabIndex = 5;
            this.buttonDodajAkciju.Text = "Dodaj";
            this.buttonDodajAkciju.UseVisualStyleBackColor = true;
            this.buttonDodajAkciju.Click += new System.EventHandler(this.buttonDodajAkciju_Click);
            // 
            // radioButtonSusK
            // 
            this.radioButtonSusK.AutoSize = true;
            this.radioButtonSusK.Location = new System.Drawing.Point(89, 87);
            this.radioButtonSusK.Name = "radioButtonSusK";
            this.radioButtonSusK.Size = new System.Drawing.Size(107, 17);
            this.radioButtonSusK.TabIndex = 7;
            this.radioButtonSusK.TabStop = true;
            this.radioButtonSusK.Text = "Susreti kandidata";
            this.radioButtonSusK.UseVisualStyleBackColor = true;
            this.radioButtonSusK.CheckedChanged += new System.EventHandler(this.radioButtonSusK_CheckedChanged);
            // 
            // radioButtonPolM
            // 
            this.radioButtonPolM.AutoSize = true;
            this.radioButtonPolM.Location = new System.Drawing.Point(200, 87);
            this.radioButtonPolM.Name = "radioButtonPolM";
            this.radioButtonPolM.Size = new System.Drawing.Size(91, 17);
            this.radioButtonPolM.TabIndex = 8;
            this.radioButtonPolM.TabStop = true;
            this.radioButtonPolM.Text = "Politički miting";
            this.radioButtonPolM.UseVisualStyleBackColor = true;
            this.radioButtonPolM.CheckedChanged += new System.EventHandler(this.radioButtonPolM_CheckedChanged);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(125, 26);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(121, 20);
            this.textBoxNaziv.TabIndex = 9;
            // 
            // textBoxGrad
            // 
            this.textBoxGrad.Location = new System.Drawing.Point(125, 55);
            this.textBoxGrad.Name = "textBoxGrad";
            this.textBoxGrad.Size = new System.Drawing.Size(121, 20);
            this.textBoxGrad.TabIndex = 10;
            // 
            // textBoxLokacija
            // 
            this.textBoxLokacija.Location = new System.Drawing.Point(125, 116);
            this.textBoxLokacija.Name = "textBoxLokacija";
            this.textBoxLokacija.Size = new System.Drawing.Size(121, 20);
            this.textBoxLokacija.TabIndex = 11;
            this.textBoxLokacija.Visible = false;
            this.textBoxLokacija.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLokacija_KeyPress);
            // 
            // textBoxTrajanje
            // 
            this.textBoxTrajanje.Location = new System.Drawing.Point(125, 144);
            this.textBoxTrajanje.Name = "textBoxTrajanje";
            this.textBoxTrajanje.Size = new System.Drawing.Size(121, 20);
            this.textBoxTrajanje.TabIndex = 12;
            this.textBoxTrajanje.Visible = false;
            // 
            // groupBoxZatvori
            // 
            this.groupBoxZatvori.Controls.Add(this.textBoxCena);
            this.groupBoxZatvori.Controls.Add(this.textBoxIznajmlj);
            this.groupBoxZatvori.Controls.Add(this.label8);
            this.groupBoxZatvori.Controls.Add(this.label9);
            this.groupBoxZatvori.Location = new System.Drawing.Point(53, 175);
            this.groupBoxZatvori.Name = "groupBoxZatvori";
            this.groupBoxZatvori.Size = new System.Drawing.Size(226, 79);
            this.groupBoxZatvori.TabIndex = 16;
            this.groupBoxZatvori.TabStop = false;
            this.groupBoxZatvori.Text = "Miting u zatvorenom";
            this.groupBoxZatvori.Visible = false;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(117, 41);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(100, 20);
            this.textBoxCena.TabIndex = 3;
            // 
            // textBoxIznajmlj
            // 
            this.textBoxIznajmlj.Location = new System.Drawing.Point(117, 15);
            this.textBoxIznajmlj.Name = "textBoxIznajmlj";
            this.textBoxIznajmlj.Size = new System.Drawing.Size(100, 20);
            this.textBoxIznajmlj.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cena iznajmljivanja:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Iznajmljivač:";
            // 
            // checkBoxZatvoren
            // 
            this.checkBoxZatvoren.AutoSize = true;
            this.checkBoxZatvoren.Location = new System.Drawing.Point(173, 155);
            this.checkBoxZatvoren.Name = "checkBoxZatvoren";
            this.checkBoxZatvoren.Size = new System.Drawing.Size(15, 14);
            this.checkBoxZatvoren.TabIndex = 17;
            this.checkBoxZatvoren.UseVisualStyleBackColor = true;
            this.checkBoxZatvoren.Visible = false;
            this.checkBoxZatvoren.CheckedChanged += new System.EventHandler(this.checkBoxZatvoren_CheckedChanged);
            // 
            // labelZatvoren
            // 
            this.labelZatvoren.AutoSize = true;
            this.labelZatvoren.Location = new System.Drawing.Point(158, 139);
            this.labelZatvoren.Name = "labelZatvoren";
            this.labelZatvoren.Size = new System.Drawing.Size(50, 13);
            this.labelZatvoren.TabIndex = 18;
            this.labelZatvoren.Text = "Zatvoren";
            this.labelZatvoren.Visible = false;
            // 
            // radioButtonDeljeLet
            // 
            this.radioButtonDeljeLet.AutoSize = true;
            this.radioButtonDeljeLet.Location = new System.Drawing.Point(13, 87);
            this.radioButtonDeljeLet.Name = "radioButtonDeljeLet";
            this.radioButtonDeljeLet.Size = new System.Drawing.Size(95, 17);
            this.radioButtonDeljeLet.TabIndex = 19;
            this.radioButtonDeljeLet.TabStop = true;
            this.radioButtonDeljeLet.Text = "Deljenje letaka";
            this.radioButtonDeljeLet.UseVisualStyleBackColor = true;
            this.radioButtonDeljeLet.CheckedChanged += new System.EventHandler(this.radioButtonDeljeLet_CheckedChanged);
            // 
            // DodajAkciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 287);
            this.Controls.Add(this.radioButtonDeljeLet);
            this.Controls.Add(this.labelZatvoren);
            this.Controls.Add(this.checkBoxZatvoren);
            this.Controls.Add(this.groupBoxZatvori);
            this.Controls.Add(this.textBoxTrajanje);
            this.Controls.Add(this.textBoxLokacija);
            this.Controls.Add(this.textBoxGrad);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.radioButtonPolM);
            this.Controls.Add(this.radioButtonSusK);
            this.Controls.Add(this.buttonDodajAkciju);
            this.Controls.Add(this.labelTrajanje);
            this.Controls.Add(this.labelLokacija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajAkciju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje akcije";
            this.groupBoxZatvori.ResumeLayout(false);
            this.groupBoxZatvori.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLokacija;
        private System.Windows.Forms.Label labelTrajanje;
        private System.Windows.Forms.Button buttonDodajAkciju;
        private System.Windows.Forms.RadioButton radioButtonSusK;
        private System.Windows.Forms.RadioButton radioButtonPolM;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxGrad;
        private System.Windows.Forms.TextBox textBoxLokacija;
        private System.Windows.Forms.TextBox textBoxTrajanje;
        private System.Windows.Forms.GroupBox groupBoxZatvori;
        private System.Windows.Forms.TextBox textBoxCena;
        private System.Windows.Forms.TextBox textBoxIznajmlj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxZatvoren;
        private System.Windows.Forms.Label labelZatvoren;
        private System.Windows.Forms.RadioButton radioButtonDeljeLet;
    }
}