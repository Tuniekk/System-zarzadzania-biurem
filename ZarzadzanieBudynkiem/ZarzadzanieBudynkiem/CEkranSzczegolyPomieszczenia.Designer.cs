namespace ZarzadzanieBudynkiem
{
    partial class CEkranSzczegolyPomieszczenia
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
            this.labelObecnaTemperatura = new System.Windows.Forms.Label();
            this.textBoxObecnaTemperatura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNowaTemperatura = new System.Windows.Forms.TextBox();
            this.buttonZatwierdzZmiane = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.textBoxKomunikatOBledzieTemp = new System.Windows.Forms.TextBox();
            this.buttonSzczegoly = new System.Windows.Forms.Button();
            this.listViewListaRolet = new System.Windows.Forms.ListView();
            this.NumerRolet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ObecnyPoziomWysuniecia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelObecnaTemperatura
            // 
            this.labelObecnaTemperatura.AutoSize = true;
            this.labelObecnaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelObecnaTemperatura.Location = new System.Drawing.Point(12, 22);
            this.labelObecnaTemperatura.Name = "labelObecnaTemperatura";
            this.labelObecnaTemperatura.Size = new System.Drawing.Size(390, 26);
            this.labelObecnaTemperatura.TabIndex = 0;
            this.labelObecnaTemperatura.Text = "Obecna temperatura w pomieszczeniu:";
            // 
            // textBoxObecnaTemperatura
            // 
            this.textBoxObecnaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxObecnaTemperatura.Location = new System.Drawing.Point(408, 19);
            this.textBoxObecnaTemperatura.Name = "textBoxObecnaTemperatura";
            this.textBoxObecnaTemperatura.ReadOnly = true;
            this.textBoxObecnaTemperatura.Size = new System.Drawing.Size(79, 32);
            this.textBoxObecnaTemperatura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(493, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nowa temperatura w pomieszczeniu:";
            // 
            // textBoxNowaTemperatura
            // 
            this.textBoxNowaTemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxNowaTemperatura.Location = new System.Drawing.Point(869, 19);
            this.textBoxNowaTemperatura.Name = "textBoxNowaTemperatura";
            this.textBoxNowaTemperatura.Size = new System.Drawing.Size(79, 32);
            this.textBoxNowaTemperatura.TabIndex = 3;
            // 
            // buttonZatwierdzZmiane
            // 
            this.buttonZatwierdzZmiane.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonZatwierdzZmiane.Location = new System.Drawing.Point(999, 12);
            this.buttonZatwierdzZmiane.Name = "buttonZatwierdzZmiane";
            this.buttonZatwierdzZmiane.Size = new System.Drawing.Size(206, 44);
            this.buttonZatwierdzZmiane.TabIndex = 4;
            this.buttonZatwierdzZmiane.Text = "Zatwierdź zmianę";
            this.buttonZatwierdzZmiane.UseVisualStyleBackColor = true;
            this.buttonZatwierdzZmiane.Click += new System.EventHandler(this.buttonZatwierdzZmiane_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonPowrot.Location = new System.Drawing.Point(1082, 392);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(123, 46);
            this.buttonPowrot.TabIndex = 5;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // textBoxKomunikatOBledzieTemp
            // 
            this.textBoxKomunikatOBledzieTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxKomunikatOBledzieTemp.Location = new System.Drawing.Point(18, 62);
            this.textBoxKomunikatOBledzieTemp.Name = "textBoxKomunikatOBledzieTemp";
            this.textBoxKomunikatOBledzieTemp.ReadOnly = true;
            this.textBoxKomunikatOBledzieTemp.Size = new System.Drawing.Size(930, 32);
            this.textBoxKomunikatOBledzieTemp.TabIndex = 6;
            // 
            // buttonSzczegoly
            // 
            this.buttonSzczegoly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonSzczegoly.Location = new System.Drawing.Point(999, 110);
            this.buttonSzczegoly.Name = "buttonSzczegoly";
            this.buttonSzczegoly.Size = new System.Drawing.Size(206, 44);
            this.buttonSzczegoly.TabIndex = 7;
            this.buttonSzczegoly.Text = "Szczegóły";
            this.buttonSzczegoly.UseVisualStyleBackColor = true;
            this.buttonSzczegoly.Click += new System.EventHandler(this.buttonSzczegoly_Click);
            // 
            // listViewListaRolet
            // 
            this.listViewListaRolet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumerRolet,
            this.ObecnyPoziomWysuniecia});
            this.listViewListaRolet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listViewListaRolet.HideSelection = false;
            this.listViewListaRolet.Location = new System.Drawing.Point(18, 110);
            this.listViewListaRolet.MultiSelect = false;
            this.listViewListaRolet.Name = "listViewListaRolet";
            this.listViewListaRolet.Size = new System.Drawing.Size(929, 284);
            this.listViewListaRolet.TabIndex = 8;
            this.listViewListaRolet.UseCompatibleStateImageBehavior = false;
            this.listViewListaRolet.View = System.Windows.Forms.View.Details;
            // 
            // NumerRolet
            // 
            this.NumerRolet.Text = "Numer rolet";
            this.NumerRolet.Width = 126;
            // 
            // ObecnyPoziomWysuniecia
            // 
            this.ObecnyPoziomWysuniecia.Text = "Obecny poziom wysunięcia";
            this.ObecnyPoziomWysuniecia.Width = 276;
            // 
            // CEkranSzczegolyPomieszczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 450);
            this.Controls.Add(this.listViewListaRolet);
            this.Controls.Add(this.buttonSzczegoly);
            this.Controls.Add(this.textBoxKomunikatOBledzieTemp);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonZatwierdzZmiane);
            this.Controls.Add(this.textBoxNowaTemperatura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxObecnaTemperatura);
            this.Controls.Add(this.labelObecnaTemperatura);
            this.Name = "CEkranSzczegolyPomieszczenia";
            this.Text = "CEkranSzczegolyPomieszczenia";
            this.Load += new System.EventHandler(this.CEkranSzczegolyPomieszczenia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelObecnaTemperatura;
        private System.Windows.Forms.TextBox textBoxObecnaTemperatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNowaTemperatura;
        private System.Windows.Forms.Button buttonZatwierdzZmiane;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.TextBox textBoxKomunikatOBledzieTemp;
        private System.Windows.Forms.Button buttonSzczegoly;
        private System.Windows.Forms.ListView listViewListaRolet;
        private System.Windows.Forms.ColumnHeader NumerRolet;
        private System.Windows.Forms.ColumnHeader ObecnyPoziomWysuniecia;
    }
}