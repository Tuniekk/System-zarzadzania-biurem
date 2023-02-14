namespace ZarzadzanieBudynkiem
{
    partial class CEkranMenuGlowne
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
            this.buttonWylogujSie = new System.Windows.Forms.Button();
            this.buttonPomieszczenia = new System.Windows.Forms.Button();
            this.buttonMiejsceParkingowe = new System.Windows.Forms.Button();
            this.buttonTabliceRejestracyjne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonWylogujSie
            // 
            this.buttonWylogujSie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonWylogujSie.Location = new System.Drawing.Point(893, 30);
            this.buttonWylogujSie.Name = "buttonWylogujSie";
            this.buttonWylogujSie.Size = new System.Drawing.Size(163, 53);
            this.buttonWylogujSie.TabIndex = 0;
            this.buttonWylogujSie.Text = "Wyloguj się";
            this.buttonWylogujSie.UseVisualStyleBackColor = true;
            this.buttonWylogujSie.Click += new System.EventHandler(this.buttonWylogujSie_Click);
            // 
            // buttonPomieszczenia
            // 
            this.buttonPomieszczenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonPomieszczenia.Location = new System.Drawing.Point(12, 30);
            this.buttonPomieszczenia.Name = "buttonPomieszczenia";
            this.buttonPomieszczenia.Size = new System.Drawing.Size(235, 53);
            this.buttonPomieszczenia.TabIndex = 1;
            this.buttonPomieszczenia.Text = "Pomieszczenia";
            this.buttonPomieszczenia.UseVisualStyleBackColor = true;
            this.buttonPomieszczenia.Click += new System.EventHandler(this.buttonPomieszczenia_Click);
            // 
            // buttonMiejsceParkingowe
            // 
            this.buttonMiejsceParkingowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonMiejsceParkingowe.Location = new System.Drawing.Point(253, 30);
            this.buttonMiejsceParkingowe.Name = "buttonMiejsceParkingowe";
            this.buttonMiejsceParkingowe.Size = new System.Drawing.Size(235, 53);
            this.buttonMiejsceParkingowe.TabIndex = 2;
            this.buttonMiejsceParkingowe.Text = "Miejsce parkingowe";
            this.buttonMiejsceParkingowe.UseVisualStyleBackColor = true;
            this.buttonMiejsceParkingowe.Click += new System.EventHandler(this.buttonMiejsceParkingowe_Click);
            // 
            // buttonTabliceRejestracyjne
            // 
            this.buttonTabliceRejestracyjne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonTabliceRejestracyjne.Location = new System.Drawing.Point(494, 30);
            this.buttonTabliceRejestracyjne.Name = "buttonTabliceRejestracyjne";
            this.buttonTabliceRejestracyjne.Size = new System.Drawing.Size(235, 53);
            this.buttonTabliceRejestracyjne.TabIndex = 3;
            this.buttonTabliceRejestracyjne.Text = "Tablice rejestracyjne";
            this.buttonTabliceRejestracyjne.UseVisualStyleBackColor = true;
            this.buttonTabliceRejestracyjne.Click += new System.EventHandler(this.buttonTabliceRejestracyjne_Click);
            // 
            // CEkranMenuGlowne
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1068, 109);
            this.Controls.Add(this.buttonTabliceRejestracyjne);
            this.Controls.Add(this.buttonMiejsceParkingowe);
            this.Controls.Add(this.buttonPomieszczenia);
            this.Controls.Add(this.buttonWylogujSie);
            this.Name = "CEkranMenuGlowne";
            this.Text = "Menu główne";
            this.Load += new System.EventHandler(this.CEkranMenuGlowne_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonWylogujSie;
        private System.Windows.Forms.Button buttonPomieszczenia;
        private System.Windows.Forms.Button buttonMiejsceParkingowe;
        private System.Windows.Forms.Button buttonTabliceRejestracyjne;
    }
}