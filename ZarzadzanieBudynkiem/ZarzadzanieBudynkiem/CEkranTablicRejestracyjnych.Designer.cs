namespace ZarzadzanieBudynkiem
{
    partial class CEkranTablicRejestracyjnych
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
            this.textBoxNowaTablicaRejestracyjna = new System.Windows.Forms.TextBox();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.listViewTabliceRejestracyjne = new System.Windows.Forms.ListView();
            this.columnHeaderTablicaRejestracyjna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonZarzadzaj = new System.Windows.Forms.Button();
            this.textBoxKomunikatOBledzie = new System.Windows.Forms.TextBox();
            this.labelNowaTablica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNowaTablicaRejestracyjna
            // 
            this.textBoxNowaTablicaRejestracyjna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxNowaTablicaRejestracyjna.Location = new System.Drawing.Point(285, 15);
            this.textBoxNowaTablicaRejestracyjna.Name = "textBoxNowaTablicaRejestracyjna";
            this.textBoxNowaTablicaRejestracyjna.Size = new System.Drawing.Size(259, 32);
            this.textBoxNowaTablicaRejestracyjna.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonDodaj.Location = new System.Drawing.Point(562, 12);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(122, 36);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonPowrot.Location = new System.Drawing.Point(562, 267);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(122, 36);
            this.buttonPowrot.TabIndex = 2;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // listViewTabliceRejestracyjne
            // 
            this.listViewTabliceRejestracyjne.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTablicaRejestracyjna});
            this.listViewTabliceRejestracyjne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listViewTabliceRejestracyjne.HideSelection = false;
            this.listViewTabliceRejestracyjne.Location = new System.Drawing.Point(12, 64);
            this.listViewTabliceRejestracyjne.MultiSelect = false;
            this.listViewTabliceRejestracyjne.Name = "listViewTabliceRejestracyjne";
            this.listViewTabliceRejestracyjne.Size = new System.Drawing.Size(532, 150);
            this.listViewTabliceRejestracyjne.TabIndex = 3;
            this.listViewTabliceRejestracyjne.UseCompatibleStateImageBehavior = false;
            this.listViewTabliceRejestracyjne.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTablicaRejestracyjna
            // 
            this.columnHeaderTablicaRejestracyjna.Text = "Tablica rejestracyjna";
            this.columnHeaderTablicaRejestracyjna.Width = 300;
            // 
            // buttonZarzadzaj
            // 
            this.buttonZarzadzaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonZarzadzaj.Location = new System.Drawing.Point(562, 64);
            this.buttonZarzadzaj.Name = "buttonZarzadzaj";
            this.buttonZarzadzaj.Size = new System.Drawing.Size(122, 36);
            this.buttonZarzadzaj.TabIndex = 4;
            this.buttonZarzadzaj.Text = "Zarządzaj";
            this.buttonZarzadzaj.UseVisualStyleBackColor = true;
            this.buttonZarzadzaj.Click += new System.EventHandler(this.buttonZarzadzaj_Click);
            // 
            // textBoxKomunikatOBledzie
            // 
            this.textBoxKomunikatOBledzie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxKomunikatOBledzie.Location = new System.Drawing.Point(12, 234);
            this.textBoxKomunikatOBledzie.Name = "textBoxKomunikatOBledzie";
            this.textBoxKomunikatOBledzie.ReadOnly = true;
            this.textBoxKomunikatOBledzie.Size = new System.Drawing.Size(532, 32);
            this.textBoxKomunikatOBledzie.TabIndex = 5;
            // 
            // labelNowaTablica
            // 
            this.labelNowaTablica.AutoSize = true;
            this.labelNowaTablica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNowaTablica.Location = new System.Drawing.Point(7, 18);
            this.labelNowaTablica.Name = "labelNowaTablica";
            this.labelNowaTablica.Size = new System.Drawing.Size(272, 26);
            this.labelNowaTablica.TabIndex = 6;
            this.labelNowaTablica.Text = "Nowa tablica rejestracyjna:";
            // 
            // CEkranTablicRejestracyjnych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 315);
            this.Controls.Add(this.labelNowaTablica);
            this.Controls.Add(this.textBoxKomunikatOBledzie);
            this.Controls.Add(this.buttonZarzadzaj);
            this.Controls.Add(this.listViewTabliceRejestracyjne);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.textBoxNowaTablicaRejestracyjna);
            this.Name = "CEkranTablicRejestracyjnych";
            this.Text = "CEkranTablicRejestracyjnych";
            this.Load += new System.EventHandler(this.CEkranTablicRejestracyjnych_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNowaTablicaRejestracyjna;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.ListView listViewTabliceRejestracyjne;
        private System.Windows.Forms.Button buttonZarzadzaj;
        private System.Windows.Forms.ColumnHeader columnHeaderTablicaRejestracyjna;
        private System.Windows.Forms.TextBox textBoxKomunikatOBledzie;
        private System.Windows.Forms.Label labelNowaTablica;
    }
}