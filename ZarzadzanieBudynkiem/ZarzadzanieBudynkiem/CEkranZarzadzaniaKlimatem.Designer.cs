namespace ZarzadzanieBudynkiem
{
    partial class CEkranZarzadzaniaKlimatem
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
            this.textBoxSzukajPomieszczenie = new System.Windows.Forms.TextBox();
            this.buttonSzukaj = new System.Windows.Forms.Button();
            this.listViewPomieszczeniaBiurowe = new System.Windows.Forms.ListView();
            this.NumerPomieszczenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObecnaTemperatura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rozmiar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.buttonSzczegoly = new System.Windows.Forms.Button();
            this.buttonLicznikiZuzycia = new System.Windows.Forms.Button();
            this.labelNumerPomieszczenia = new System.Windows.Forms.Label();
            this.columnHeaderMinTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMaxTemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBoxSzukajPomieszczenie
            // 
            this.textBoxSzukajPomieszczenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxSzukajPomieszczenie.Location = new System.Drawing.Point(253, 18);
            this.textBoxSzukajPomieszczenie.Name = "textBoxSzukajPomieszczenie";
            this.textBoxSzukajPomieszczenie.Size = new System.Drawing.Size(239, 32);
            this.textBoxSzukajPomieszczenie.TabIndex = 0;
            this.textBoxSzukajPomieszczenie.TabStop = false;
            // 
            // buttonSzukaj
            // 
            this.buttonSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSzukaj.Location = new System.Drawing.Point(897, 14);
            this.buttonSzukaj.Name = "buttonSzukaj";
            this.buttonSzukaj.Size = new System.Drawing.Size(153, 38);
            this.buttonSzukaj.TabIndex = 1;
            this.buttonSzukaj.Text = "Szukaj";
            this.buttonSzukaj.UseVisualStyleBackColor = true;
            this.buttonSzukaj.Click += new System.EventHandler(this.buttonSzukaj_Click);
            // 
            // listViewPomieszczeniaBiurowe
            // 
            this.listViewPomieszczeniaBiurowe.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewPomieszczeniaBiurowe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumerPomieszczenia,
            this.ObecnaTemperatura,
            this.Rozmiar,
            this.columnHeaderMinTemp,
            this.columnHeaderMaxTemp});
            this.listViewPomieszczeniaBiurowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listViewPomieszczeniaBiurowe.FullRowSelect = true;
            this.listViewPomieszczeniaBiurowe.HideSelection = false;
            this.listViewPomieszczeniaBiurowe.HoverSelection = true;
            this.listViewPomieszczeniaBiurowe.Location = new System.Drawing.Point(13, 73);
            this.listViewPomieszczeniaBiurowe.MultiSelect = false;
            this.listViewPomieszczeniaBiurowe.Name = "listViewPomieszczeniaBiurowe";
            this.listViewPomieszczeniaBiurowe.Size = new System.Drawing.Size(783, 281);
            this.listViewPomieszczeniaBiurowe.TabIndex = 2;
            this.listViewPomieszczeniaBiurowe.UseCompatibleStateImageBehavior = false;
            this.listViewPomieszczeniaBiurowe.View = System.Windows.Forms.View.Details;
            // 
            // NumerPomieszczenia
            // 
            this.NumerPomieszczenia.Text = "Numer pomieszczenia";
            this.NumerPomieszczenia.Width = 145;
            // 
            // ObecnaTemperatura
            // 
            this.ObecnaTemperatura.Text = "Obecna temperatura [C]";
            this.ObecnaTemperatura.Width = 158;
            // 
            // Rozmiar
            // 
            this.Rozmiar.Text = "Rozmiar [m^2]";
            this.Rozmiar.Width = 100;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonPowrot.Location = new System.Drawing.Point(897, 365);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(153, 38);
            this.buttonPowrot.TabIndex = 3;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // buttonSzczegoly
            // 
            this.buttonSzczegoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSzczegoly.Location = new System.Drawing.Point(804, 73);
            this.buttonSzczegoly.Name = "buttonSzczegoly";
            this.buttonSzczegoly.Size = new System.Drawing.Size(246, 38);
            this.buttonSzczegoly.TabIndex = 4;
            this.buttonSzczegoly.Text = "Szczegóły/Zarządzaj";
            this.buttonSzczegoly.UseVisualStyleBackColor = true;
            this.buttonSzczegoly.Click += new System.EventHandler(this.buttonSzczegoly_Click);
            // 
            // buttonLicznikiZuzycia
            // 
            this.buttonLicznikiZuzycia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonLicznikiZuzycia.Location = new System.Drawing.Point(804, 129);
            this.buttonLicznikiZuzycia.Name = "buttonLicznikiZuzycia";
            this.buttonLicznikiZuzycia.Size = new System.Drawing.Size(246, 38);
            this.buttonLicznikiZuzycia.TabIndex = 5;
            this.buttonLicznikiZuzycia.Text = "Liczniki zużycia";
            this.buttonLicznikiZuzycia.UseVisualStyleBackColor = true;
            this.buttonLicznikiZuzycia.Click += new System.EventHandler(this.buttonLicznikiZuzycia_Click);
            // 
            // labelNumerPomieszczenia
            // 
            this.labelNumerPomieszczenia.AutoSize = true;
            this.labelNumerPomieszczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNumerPomieszczenia.Location = new System.Drawing.Point(12, 21);
            this.labelNumerPomieszczenia.Name = "labelNumerPomieszczenia";
            this.labelNumerPomieszczenia.Size = new System.Drawing.Size(235, 26);
            this.labelNumerPomieszczenia.TabIndex = 6;
            this.labelNumerPomieszczenia.Text = "Numer pomieszczenia:";
            // 
            // columnHeaderMinTemp
            // 
            this.columnHeaderMinTemp.Text = "Minimalna temperatura [C]";
            this.columnHeaderMinTemp.Width = 176;
            // 
            // columnHeaderMaxTemp
            // 
            this.columnHeaderMaxTemp.Text = "Maksymalna temperatura [C]";
            this.columnHeaderMaxTemp.Width = 191;
            // 
            // CEkranZarzadzaniaKlimatem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 415);
            this.Controls.Add(this.labelNumerPomieszczenia);
            this.Controls.Add(this.buttonLicznikiZuzycia);
            this.Controls.Add(this.buttonSzczegoly);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.listViewPomieszczeniaBiurowe);
            this.Controls.Add(this.buttonSzukaj);
            this.Controls.Add(this.textBoxSzukajPomieszczenie);
            this.Name = "CEkranZarzadzaniaKlimatem";
            this.Text = "EkranZarzadzaniaKlimatem";
            this.Load += new System.EventHandler(this.EkranZarzadzaniaKlimatem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSzukajPomieszczenie;
        private System.Windows.Forms.Button buttonSzukaj;
        private System.Windows.Forms.ListView listViewPomieszczeniaBiurowe;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.ColumnHeader NumerPomieszczenia;
        private System.Windows.Forms.ColumnHeader ObecnaTemperatura;
        private System.Windows.Forms.ColumnHeader Rozmiar;
        private System.Windows.Forms.Button buttonSzczegoly;
        private System.Windows.Forms.Button buttonLicznikiZuzycia;
        private System.Windows.Forms.Label labelNumerPomieszczenia;
        private System.Windows.Forms.ColumnHeader columnHeaderMinTemp;
        private System.Windows.Forms.ColumnHeader columnHeaderMaxTemp;
    }
}