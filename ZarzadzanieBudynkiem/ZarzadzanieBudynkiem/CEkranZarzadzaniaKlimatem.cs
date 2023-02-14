using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZarzadzanieBudynkiem
{
    public partial class CEkranZarzadzaniaKlimatem : Form
    {
        public CEkranZarzadzaniaKlimatem()
        {
            InitializeComponent();
        }
        private void dodajPomieszczenieDoListy(CPomieszczenie pomieszczenie)
        {
            var rzad = new string[] { pomieszczenie.ZwrocNumer().ToString(), pomieszczenie.ZwrocObacnaTemperature().ToString(), pomieszczenie.ZwrocWielkosc().ToString(), pomieszczenie.ZwrocMinTemperature().ToString(), pomieszczenie.ZwrocMaxTemperature().ToString() };
            var lvi = new ListViewItem(rzad);
            lvi.Tag = pomieszczenie;
            listViewPomieszczeniaBiurowe.Items.Add(lvi);
        }
        private void EkranZarzadzaniaKlimatem_Load(object sender, EventArgs e)
        {
            foreach (var pomieszczenie in Program.biuro1.listaPomieszczen)
            {
                dodajPomieszczenieDoListy(pomieszczenie);
            }
        }

        private void buttonPowrot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSzczegoly_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (ListViewItem item in listViewPomieszczeniaBiurowe.SelectedItems)
            {
                foreach (var pomieszczenie in Program.biuro1.listaPomieszczen)
                {
                    if (listViewPomieszczeniaBiurowe.SelectedItems[0].SubItems[0].Text.ToString() == pomieszczenie.ZwrocNumer().ToString())
                    {
                        CEkranSzczegolyPomieszczenia ekranSP = new CEkranSzczegolyPomieszczenia(pomieszczenie);
                        ekranSP.ShowDialog();
                    }
                }

            }
            this.Close();
        }

        private void buttonSzukaj_Click(object sender, EventArgs e)
        {
            listViewPomieszczeniaBiurowe.Items.Clear();
            if (this.textBoxSzukajPomieszczenie.Text.Length > 0)
            {
                foreach (var pomieszczenie in Program.biuro1.listaPomieszczen)
                {
                    if (this.textBoxSzukajPomieszczenie.Text.ToString() == pomieszczenie.ZwrocNumer().ToString())
                    {
                        dodajPomieszczenieDoListy(pomieszczenie);
                    }
                }
            }
            else
            {
                foreach (var pomieszczenie in Program.biuro1.listaPomieszczen)
                {
                    dodajPomieszczenieDoListy(pomieszczenie);
                }
            }
        }

        private void buttonLicznikiZuzycia_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (ListViewItem item in listViewPomieszczeniaBiurowe.SelectedItems)
            {
                foreach (var pomieszczenie in Program.biuro1.listaPomieszczen)
                {
                    if (listViewPomieszczeniaBiurowe.SelectedItems[0].SubItems[0].Text.ToString() == pomieszczenie.ZwrocNumer().ToString())
                    {
                        CEkranSzczegolyLicznika ekranSL = new CEkranSzczegolyLicznika(pomieszczenie);
                        ekranSL.ShowDialog();
                    }
                }

            }
            this.Close();
        }
    }
}
