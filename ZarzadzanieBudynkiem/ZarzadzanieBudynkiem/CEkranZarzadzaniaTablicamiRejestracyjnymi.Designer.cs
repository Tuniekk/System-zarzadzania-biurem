namespace ZarzadzanieBudynkiem
{
    partial class CEkranZarzadzaniaTablicamiRejestracyjnymi
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
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.buttonUsunTabliceZListy = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.textBoxKomunikatOBledzie = new System.Windows.Forms.TextBox();
            this.labelNowaTablica = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNowaTablicaRejestracyjna
            // 
            this.textBoxNowaTablicaRejestracyjna.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxNowaTablicaRejestracyjna.Location = new System.Drawing.Point(285, 17);
            this.textBoxNowaTablicaRejestracyjna.Name = "textBoxNowaTablicaRejestracyjna";
            this.textBoxNowaTablicaRejestracyjna.Size = new System.Drawing.Size(288, 32);
            this.textBoxNowaTablicaRejestracyjna.TabIndex = 0;
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonZatwierdz.Location = new System.Drawing.Point(619, 12);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(230, 40);
            this.buttonZatwierdz.TabIndex = 1;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // buttonUsunTabliceZListy
            // 
            this.buttonUsunTabliceZListy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonUsunTabliceZListy.Location = new System.Drawing.Point(619, 77);
            this.buttonUsunTabliceZListy.Name = "buttonUsunTabliceZListy";
            this.buttonUsunTabliceZListy.Size = new System.Drawing.Size(230, 40);
            this.buttonUsunTabliceZListy.TabIndex = 2;
            this.buttonUsunTabliceZListy.Text = "Usuń tablicę z listy";
            this.buttonUsunTabliceZListy.UseVisualStyleBackColor = true;
            this.buttonUsunTabliceZListy.Click += new System.EventHandler(this.buttonUsunTabliceZListy_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAnuluj.Location = new System.Drawing.Point(735, 142);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(114, 40);
            this.buttonAnuluj.TabIndex = 3;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // textBoxKomunikatOBledzie
            // 
            this.textBoxKomunikatOBledzie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxKomunikatOBledzie.Location = new System.Drawing.Point(12, 82);
            this.textBoxKomunikatOBledzie.Name = "textBoxKomunikatOBledzie";
            this.textBoxKomunikatOBledzie.ReadOnly = true;
            this.textBoxKomunikatOBledzie.Size = new System.Drawing.Size(561, 32);
            this.textBoxKomunikatOBledzie.TabIndex = 4;
            // 
            // labelNowaTablica
            // 
            this.labelNowaTablica.AutoSize = true;
            this.labelNowaTablica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNowaTablica.Location = new System.Drawing.Point(7, 20);
            this.labelNowaTablica.Name = "labelNowaTablica";
            this.labelNowaTablica.Size = new System.Drawing.Size(272, 26);
            this.labelNowaTablica.TabIndex = 5;
            this.labelNowaTablica.Text = "Nowa tablica rejestracyjna:";
            // 
            // CEkranZarzadzaniaTablicamiRejestracyjnymi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 194);
            this.Controls.Add(this.labelNowaTablica);
            this.Controls.Add(this.textBoxKomunikatOBledzie);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonUsunTabliceZListy);
            this.Controls.Add(this.buttonZatwierdz);
            this.Controls.Add(this.textBoxNowaTablicaRejestracyjna);
            this.Name = "CEkranZarzadzaniaTablicamiRejestracyjnymi";
            this.Text = "CEkranZarzadzaniaTablicamiRejestracyjnymi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNowaTablicaRejestracyjna;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.Button buttonUsunTabliceZListy;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.TextBox textBoxKomunikatOBledzie;
        private System.Windows.Forms.Label labelNowaTablica;
    }
}