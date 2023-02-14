namespace ZarzadzanieBudynkiem
{
    partial class CEkranMiejscParkingowych
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
            this.buttonZwolnijMiejsce = new System.Windows.Forms.Button();
            this.buttonZarezerwujMiejsce = new System.Windows.Forms.Button();
            this.textBoxKomunikatOBledzie = new System.Windows.Forms.TextBox();
            this.buttonPowrot = new System.Windows.Forms.Button();
            this.textBoxZarezerwowaneMiejsce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonZwolnijMiejsce
            // 
            this.buttonZwolnijMiejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonZwolnijMiejsce.Location = new System.Drawing.Point(12, 12);
            this.buttonZwolnijMiejsce.Name = "buttonZwolnijMiejsce";
            this.buttonZwolnijMiejsce.Size = new System.Drawing.Size(478, 37);
            this.buttonZwolnijMiejsce.TabIndex = 0;
            this.buttonZwolnijMiejsce.Text = "Zwolnij obecnie zajmowane miejsce parkingowe";
            this.buttonZwolnijMiejsce.UseVisualStyleBackColor = true;
            this.buttonZwolnijMiejsce.Click += new System.EventHandler(this.buttonZwolnijMiejsce_Click);
            // 
            // buttonZarezerwujMiejsce
            // 
            this.buttonZarezerwujMiejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonZarezerwujMiejsce.Location = new System.Drawing.Point(12, 125);
            this.buttonZarezerwujMiejsce.Name = "buttonZarezerwujMiejsce";
            this.buttonZarezerwujMiejsce.Size = new System.Drawing.Size(478, 38);
            this.buttonZarezerwujMiejsce.TabIndex = 1;
            this.buttonZarezerwujMiejsce.Text = "Zarezerwuj miejsce parkingowe";
            this.buttonZarezerwujMiejsce.UseVisualStyleBackColor = true;
            this.buttonZarezerwujMiejsce.Click += new System.EventHandler(this.buttonZarezerwujMiejsce_Click);
            // 
            // textBoxKomunikatOBledzie
            // 
            this.textBoxKomunikatOBledzie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxKomunikatOBledzie.Location = new System.Drawing.Point(12, 169);
            this.textBoxKomunikatOBledzie.Name = "textBoxKomunikatOBledzie";
            this.textBoxKomunikatOBledzie.ReadOnly = true;
            this.textBoxKomunikatOBledzie.Size = new System.Drawing.Size(478, 32);
            this.textBoxKomunikatOBledzie.TabIndex = 2;
            // 
            // buttonPowrot
            // 
            this.buttonPowrot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonPowrot.Location = new System.Drawing.Point(368, 207);
            this.buttonPowrot.Name = "buttonPowrot";
            this.buttonPowrot.Size = new System.Drawing.Size(122, 38);
            this.buttonPowrot.TabIndex = 3;
            this.buttonPowrot.Text = "Powrót";
            this.buttonPowrot.UseVisualStyleBackColor = true;
            this.buttonPowrot.Click += new System.EventHandler(this.buttonPowrot_Click);
            // 
            // textBoxZarezerwowaneMiejsce
            // 
            this.textBoxZarezerwowaneMiejsce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxZarezerwowaneMiejsce.Location = new System.Drawing.Point(12, 59);
            this.textBoxZarezerwowaneMiejsce.Name = "textBoxZarezerwowaneMiejsce";
            this.textBoxZarezerwowaneMiejsce.ReadOnly = true;
            this.textBoxZarezerwowaneMiejsce.Size = new System.Drawing.Size(478, 32);
            this.textBoxZarezerwowaneMiejsce.TabIndex = 4;
            // 
            // CEkranMiejscParkingowych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 255);
            this.Controls.Add(this.textBoxZarezerwowaneMiejsce);
            this.Controls.Add(this.buttonPowrot);
            this.Controls.Add(this.textBoxKomunikatOBledzie);
            this.Controls.Add(this.buttonZarezerwujMiejsce);
            this.Controls.Add(this.buttonZwolnijMiejsce);
            this.Name = "CEkranMiejscParkingowych";
            this.Text = "CEkranMiejscParkingowych";
            this.Load += new System.EventHandler(this.CEkranMiejscParkingowych_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonZwolnijMiejsce;
        private System.Windows.Forms.Button buttonZarezerwujMiejsce;
        private System.Windows.Forms.TextBox textBoxKomunikatOBledzie;
        private System.Windows.Forms.Button buttonPowrot;
        private System.Windows.Forms.TextBox textBoxZarezerwowaneMiejsce;
    }
}