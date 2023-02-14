namespace ZarzadzanieBudynkiem
{
    partial class CEkranSzczegolyLicznika
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
            this.dateTimePickerOdKiedy = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDoKiedy = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFiltruj = new System.Windows.Forms.Button();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.textBoxZuzycieWody = new System.Windows.Forms.TextBox();
            this.textBoxZuzycieCiepla = new System.Windows.Forms.TextBox();
            this.textBoxZuzyciePradu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePickerOdKiedy
            // 
            this.dateTimePickerOdKiedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePickerOdKiedy.Location = new System.Drawing.Point(59, 12);
            this.dateTimePickerOdKiedy.Name = "dateTimePickerOdKiedy";
            this.dateTimePickerOdKiedy.Size = new System.Drawing.Size(365, 32);
            this.dateTimePickerOdKiedy.TabIndex = 0;
            // 
            // dateTimePickerDoKiedy
            // 
            this.dateTimePickerDoKiedy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePickerDoKiedy.Location = new System.Drawing.Point(472, 12);
            this.dateTimePickerDoKiedy.Name = "dateTimePickerDoKiedy";
            this.dateTimePickerDoKiedy.Size = new System.Drawing.Size(365, 32);
            this.dateTimePickerDoKiedy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(430, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "do";
            // 
            // buttonFiltruj
            // 
            this.buttonFiltruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonFiltruj.Location = new System.Drawing.Point(895, 10);
            this.buttonFiltruj.Name = "buttonFiltruj";
            this.buttonFiltruj.Size = new System.Drawing.Size(126, 34);
            this.buttonFiltruj.TabIndex = 4;
            this.buttonFiltruj.Text = "Filtruj";
            this.buttonFiltruj.UseVisualStyleBackColor = true;
            this.buttonFiltruj.Click += new System.EventHandler(this.buttonFiltruj_Click);
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonPowrot.Location = new System.Drawing.Point(895, 227);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(126, 39);
            this.buttonPowrot.TabIndex = 5;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // textBoxZuzycieWody
            // 
            this.textBoxZuzycieWody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxZuzycieWody.Location = new System.Drawing.Point(19, 70);
            this.textBoxZuzycieWody.Name = "textBoxZuzycieWody";
            this.textBoxZuzycieWody.ReadOnly = true;
            this.textBoxZuzycieWody.Size = new System.Drawing.Size(818, 32);
            this.textBoxZuzycieWody.TabIndex = 6;
            // 
            // textBoxZuzycieCiepla
            // 
            this.textBoxZuzycieCiepla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxZuzycieCiepla.Location = new System.Drawing.Point(19, 128);
            this.textBoxZuzycieCiepla.Name = "textBoxZuzycieCiepla";
            this.textBoxZuzycieCiepla.ReadOnly = true;
            this.textBoxZuzycieCiepla.Size = new System.Drawing.Size(818, 32);
            this.textBoxZuzycieCiepla.TabIndex = 7;
            // 
            // textBoxZuzyciePradu
            // 
            this.textBoxZuzyciePradu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxZuzyciePradu.Location = new System.Drawing.Point(19, 187);
            this.textBoxZuzyciePradu.Name = "textBoxZuzyciePradu";
            this.textBoxZuzyciePradu.ReadOnly = true;
            this.textBoxZuzyciePradu.Size = new System.Drawing.Size(818, 32);
            this.textBoxZuzyciePradu.TabIndex = 8;
            // 
            // CEkranSzczegolyLicznika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 278);
            this.Controls.Add(this.textBoxZuzyciePradu);
            this.Controls.Add(this.textBoxZuzycieCiepla);
            this.Controls.Add(this.textBoxZuzycieWody);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.buttonFiltruj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDoKiedy);
            this.Controls.Add(this.dateTimePickerOdKiedy);
            this.Name = "CEkranSzczegolyLicznika";
            this.Text = "CEkranSzczegolyLicznika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerOdKiedy;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoKiedy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFiltruj;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.TextBox textBoxZuzycieWody;
        private System.Windows.Forms.TextBox textBoxZuzycieCiepla;
        private System.Windows.Forms.TextBox textBoxZuzyciePradu;
    }
}