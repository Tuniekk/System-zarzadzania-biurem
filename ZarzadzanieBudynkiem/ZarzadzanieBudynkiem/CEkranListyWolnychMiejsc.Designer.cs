namespace ZarzadzanieBudynkiem
{
    partial class CEkranListyWolnychMiejsc
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
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.listViewWolneMiejsca = new System.Windows.Forms.ListView();
            this.numerMiejsca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numerPietra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonZarezerwuj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonAnuluj.Location = new System.Drawing.Point(702, 356);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(128, 48);
            this.buttonAnuluj.TabIndex = 0;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // listViewWolneMiejsca
            // 
            this.listViewWolneMiejsca.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numerMiejsca,
            this.numerPietra});
            this.listViewWolneMiejsca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listViewWolneMiejsca.HideSelection = false;
            this.listViewWolneMiejsca.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.listViewWolneMiejsca.Location = new System.Drawing.Point(12, 12);
            this.listViewWolneMiejsca.MultiSelect = false;
            this.listViewWolneMiejsca.Name = "listViewWolneMiejsca";
            this.listViewWolneMiejsca.Size = new System.Drawing.Size(563, 345);
            this.listViewWolneMiejsca.TabIndex = 1;
            this.listViewWolneMiejsca.UseCompatibleStateImageBehavior = false;
            this.listViewWolneMiejsca.View = System.Windows.Forms.View.Details;
            this.listViewWolneMiejsca.SelectedIndexChanged += new System.EventHandler(this.listViewWolneMiejsca_SelectedIndexChanged);
            // 
            // numerMiejsca
            // 
            this.numerMiejsca.Text = "Numer miejsca";
            this.numerMiejsca.Width = 180;
            // 
            // numerPietra
            // 
            this.numerPietra.Text = "Numer piętra";
            this.numerPietra.Width = 150;
            // 
            // buttonZarezerwuj
            // 
            this.buttonZarezerwuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonZarezerwuj.Location = new System.Drawing.Point(581, 12);
            this.buttonZarezerwuj.Name = "buttonZarezerwuj";
            this.buttonZarezerwuj.Size = new System.Drawing.Size(255, 48);
            this.buttonZarezerwuj.TabIndex = 2;
            this.buttonZarezerwuj.Text = "Zarezerwuj miejsce";
            this.buttonZarezerwuj.UseVisualStyleBackColor = true;
            this.buttonZarezerwuj.Click += new System.EventHandler(this.buttonZarezerwuj_Click);
            // 
            // CEkranListyWolnychMiejsc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 416);
            this.Controls.Add(this.buttonZarezerwuj);
            this.Controls.Add(this.listViewWolneMiejsca);
            this.Controls.Add(this.buttonAnuluj);
            this.Name = "CEkranListyWolnychMiejsc";
            this.Text = "CEkranListyWolnychMiejsc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.ListView listViewWolneMiejsca;
        private System.Windows.Forms.Button buttonZarezerwuj;
        private System.Windows.Forms.ColumnHeader numerMiejsca;
        private System.Windows.Forms.ColumnHeader numerPietra;
    }
}