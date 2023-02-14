using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarzadzanieBudynkiem
{
    public partial class CEkranTablicRejestracyjnych : Form
    {
        public CEkranTablicRejestracyjnych()
        {
            InitializeComponent();
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void wylaczPrzyciskDodaj()
        {
            if (Program.pracownikAdministracyjny.tabliceRejestracyjne.Count() >= 2)
            {
                this.buttonDodaj.Enabled = false;
            }
            else
                this.buttonDodaj.Enabled = true;
        }
        private bool sprawdzCzyJestNaLiscie(string nowaTablica)
        {
            bool czyJest = false;
            foreach(var tablica in Program.pracownikAdministracyjny.tabliceRejestracyjne)
                if(nowaTablica == tablica.zwrocTabliceRejestracyjna())
                    czyJest = true;
            return czyJest;
        }
        private void buttonZarzadzaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (ListViewItem item in this.listViewTabliceRejestracyjne.SelectedItems)
            {
                foreach (var tablica in Program.pracownikAdministracyjny.tabliceRejestracyjne.ToList())
                {
                    if (listViewTabliceRejestracyjne.SelectedItems[0].Text.ToString() == tablica.zwrocTabliceRejestracyjna().ToString())
                    {
                        CEkranZarzadzaniaTablicamiRejestracyjnymi ekranZTR = new CEkranZarzadzaniaTablicamiRejestracyjnymi(tablica);
                        ekranZTR.ShowDialog();
                    }
                }

            }
            this.Close();
        }


        private void CEkranTablicRejestracyjnych_Load(object sender, EventArgs e)
        {
            this.wylaczPrzyciskDodaj();
            foreach (var tablica in Program.pracownikAdministracyjny.tabliceRejestracyjne)
            {
                var rzad = new string[] { tablica.zwrocTabliceRejestracyjna()};
                var lvi = new ListViewItem(rzad);
                lvi.Tag = tablica;
                listViewTabliceRejestracyjne.Items.Add(lvi);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (Program.pracownikAdministracyjny.tabliceRejestracyjne.Count() < 2)
            {
                string nowaTablica = textBoxNowaTablicaRejestracyjna.Text.ToString();
                if (this.sprawdzCzyJestNaLiscie(nowaTablica) == true)
                    this.textBoxKomunikatOBledzie.Text = "Podana tablica znajduje się już na liście.";
                else if (nowaTablica.Length == 7)
                {
                    this.textBoxKomunikatOBledzie.Clear();
                    Program.pracownikAdministracyjny.tabliceRejestracyjne.Add(new CTablicaRejestracyjna(nowaTablica[0].ToString(), nowaTablica[1].ToString(), nowaTablica[2].ToString() + nowaTablica[3] + nowaTablica[4] + nowaTablica[5] + nowaTablica[6]));
                    listViewTabliceRejestracyjne.Items.Add(nowaTablica);
                }
                else if (nowaTablica.Length == 8)
                {
                    this.textBoxKomunikatOBledzie.Clear();
                    Program.pracownikAdministracyjny.tabliceRejestracyjne.Add(new CTablicaRejestracyjna(nowaTablica[0].ToString(), nowaTablica[1].ToString() + nowaTablica[2].ToString(), nowaTablica[3].ToString() + nowaTablica[4] + nowaTablica[5] + nowaTablica[6] + nowaTablica[7]));
                    listViewTabliceRejestracyjne.Items.Add(nowaTablica);
                }
                else
                    this.textBoxKomunikatOBledzie.Text = "Podana tablica ma zły format.";
                this.wylaczPrzyciskDodaj();
            }
        }
    }
}
