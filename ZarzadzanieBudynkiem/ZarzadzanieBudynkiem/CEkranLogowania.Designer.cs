namespace ZarzadzanieBudynkiem
{
    partial class CEkranLogowania
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textHaslo = new System.Windows.Forms.TextBox();
            this.buttonZalogujSie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelHaslo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLogin
            // 
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLogin.Location = new System.Drawing.Point(275, 58);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(205, 44);
            this.textLogin.TabIndex = 0;
            // 
            // textHaslo
            // 
            this.textHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textHaslo.Location = new System.Drawing.Point(275, 133);
            this.textHaslo.Name = "textHaslo";
            this.textHaslo.PasswordChar = '*';
            this.textHaslo.Size = new System.Drawing.Size(205, 44);
            this.textHaslo.TabIndex = 1;
            this.textHaslo.UseSystemPasswordChar = true;
            // 
            // buttonZalogujSie
            // 
            this.buttonZalogujSie.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonZalogujSie.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.buttonZalogujSie.Location = new System.Drawing.Point(275, 335);
            this.buttonZalogujSie.Name = "buttonZalogujSie";
            this.buttonZalogujSie.Size = new System.Drawing.Size(205, 59);
            this.buttonZalogujSie.TabIndex = 2;
            this.buttonZalogujSie.Text = "Zaloguj się";
            this.buttonZalogujSie.UseVisualStyleBackColor = false;
            this.buttonZalogujSie.Click += new System.EventHandler(this.buttonZalogujSie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(148, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 3;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelLogin.Location = new System.Drawing.Point(157, 61);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(105, 37);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Login:";
            // 
            // labelHaslo
            // 
            this.labelHaslo.AutoSize = true;
            this.labelHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelHaslo.Location = new System.Drawing.Point(148, 136);
            this.labelHaslo.Name = "labelHaslo";
            this.labelHaslo.Size = new System.Drawing.Size(114, 37);
            this.labelHaslo.TabIndex = 5;
            this.labelHaslo.Text = "Hasło:";
            // 
            // CEkranLogowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.labelHaslo);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonZalogujSie);
            this.Controls.Add(this.textHaslo);
            this.Controls.Add(this.textLogin);
            this.Name = "CEkranLogowania";
            this.Text = "Logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textHaslo;
        private System.Windows.Forms.Button buttonZalogujSie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelHaslo;
    }
}

